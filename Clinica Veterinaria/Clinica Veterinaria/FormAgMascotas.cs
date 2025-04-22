using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Media;


namespace Clinica_Veterinaria
{
    public partial class FormAgMascotas : Form
    {
        SqlConnection cnx;
        public int clienteId = 0; // ID del cliente seleccionado
        public int mascotaId = 0; // ID of the selected pet

        public FormAgMascotas(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;

            cbxGenero.Items.Add("Macho");
            cbxGenero.Items.Add("Hembra");
            cbxRaza.Items.Add("Comun Europeo");

            CargarEspecies();
        }

        public FormAgMascotas()
        {
            InitializeComponent();
        }

        public void CargarEspecies()
        {
            try
            {
                if (cnx.State != ConnectionState.Open)
                {
                    cnx.Open();
                }

                SqlCommand cmd = new SqlCommand("Sp_Leer_Razas", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataTable uniqueSpecies = dt.DefaultView.ToTable(true, "especie");

                cbxEspecie.DataSource = uniqueSpecies;
                cbxEspecie.DisplayMember = "especie";
                cbxEspecie.ValueMember = "especie";

                int index = cbxEspecie.FindStringExact("Gato");
                cbxEspecie.SelectedIndex = index >= 0 ? index : 0;
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar especies: " + ex.Message);
            }
        }

        private void cbxEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEspecie.SelectedItem != null)
            {
                string especieSeleccionada = cbxEspecie.Text.ToString();
                CargarRazasPorEspecie(especieSeleccionada);
            }
        }

        private void CargarRazasPorEspecie(string especie)
        {
            if (string.IsNullOrEmpty(especie))
            {
                MessageBox.Show("Por favor, seleccione una especie.");
                return;
            }

            SqlCommand cmd = new SqlCommand("Sp_Leer_RazasPorEspecie", cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Especie", especie);

            try
            {
                if (cnx.State != ConnectionState.Open)
                {
                    cnx.Open();
                }

                SqlDataReader reader = cmd.ExecuteReader();

                cbxRaza.Items.Clear();

                bool razasEncontradas = false;
                while (reader.Read())
                {
                    string raza = reader["raza"].ToString();
                    cbxRaza.Items.Add(raza);
                    razasEncontradas = true;
                }

                if (!razasEncontradas)
                {
                    cbxRaza.Items.Add("No hay razas disponibles");
                }

                if (cbxRaza.Items.Count > 0)
                {
                    cbxRaza.SelectedIndex = 0;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las razas: " + ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        private void PlayAnimalSound(string animalType)
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, "Sounds", $"{animalType}.wav");
                if (File.Exists(path))
                {
                    SoundPlayer player = new SoundPlayer(path);
                    player.Play();
                }
                else
                {
                    MessageBox.Show($"Sound file not found for animal: {animalType}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sound: " + ex.Message);
            }
        }

        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccionar una imagen";
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaImagen = openFileDialog.FileName;
                    pictureBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxImagen.Image = Image.FromFile(rutaImagen);
                }
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                btnAgregar.Enabled = false;

                // Validar que un cliente haya sido seleccionado
                if (clienteId == 0)
                {
                    MessageBox.Show("Debe seleccionar un cliente válido antes de guardar la mascota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que todos los campos estén completos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    cbxEspecie.SelectedItem == null ||
                    cbxRaza.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtPeso.Text) ||
                    cbxGenero.SelectedItem == null ||
                    pictureBoxImagen.Image == null)
                {
                    MessageBox.Show("Por favor, complete todos los campos y seleccione una imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nombre = txtNombre.Text;
                string especie = cbxEspecie.Text;
                string raza = cbxRaza.Text;
                decimal peso = Convert.ToDecimal(txtPeso.Text);
                string genero = cbxGenero.SelectedItem.ToString() == "Macho" ? "M" : "F";
                DateTime fechaNacimiento = dtpFechaNacimiento.SelectionStart;

                byte[] imagenBytes = null;
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                {
                    // Crear una copia de la imagen en memoria para evitar problemas de bloqueo
                    using (Image imagenCopia = new Bitmap(pictureBoxImagen.Image))
                    {
                        imagenCopia.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imagenBytes = ms.ToArray();
                    }
                }

                // Ejecutar el procedimiento almacenado
                await Task.Run(() =>
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("spInsertarActualizarMascota", cnx))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Pasar todos los parámetros necesarios
                            cmd.Parameters.AddWithValue("@Mascota_id", mascotaId); // ID de la mascota (0 si es nueva)
                            cmd.Parameters.AddWithValue("@Cliente_id", clienteId); // ID del cliente
                            cmd.Parameters.AddWithValue("@Nombre", nombre);
                            cmd.Parameters.AddWithValue("@Especie", especie);
                            cmd.Parameters.AddWithValue("@Raza", raza);
                            cmd.Parameters.AddWithValue("@Peso", peso);
                            cmd.Parameters.AddWithValue("@Genero", genero);
                            cmd.Parameters.AddWithValue("@Fecha_nacimiento", fechaNacimiento);
                            cmd.Parameters.AddWithValue("@Foto", imagenBytes);

                            if (cnx.State != ConnectionState.Open)
                                cnx.Open();

                            cmd.ExecuteNonQuery();
                            cnx.Close();
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("Error en la base de datos: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al ejecutar el procedimiento almacenado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });

                MessageBox.Show("Mascota guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los controles
                txtNombre.Clear();
                cbxEspecie.SelectedIndex = -1;
                cbxRaza.SelectedIndex = -1;
                txtPeso.Clear();
                cbxGenero.SelectedIndex = -1;
                dtpFechaNacimiento.SelectionStart = DateTime.Now;
                pictureBoxImagen.Image = null;
                txtCliente.Clear();
                clienteId = 0; // Reiniciar el ID del cliente
                mascotaId = 0; // Reiniciar el ID de la mascota
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la mascota: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnAgregar.Enabled = true;
            }
        }

        private void BtnElegirCliente_Click(object sender, EventArgs e)
        {
            FormSeleccionarCliente_Mascotas formSeleccionarCliente = new FormSeleccionarCliente_Mascotas(this, cnx);
            formSeleccionarCliente.ShowDialog();
        }

        public void SetClienteSeleccionado(int id, string nombre)
        {
            clienteId = id; // Guardar el ID del cliente seleccionado
            txtCliente.Text = nombre; // Mostrar el nombre del cliente en el TextBox
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para seleccionar la mascota a editar
            FormSeleccionarMascotaEditar formSeleccionarMascotaEditar = new FormSeleccionarMascotaEditar(cnx, this);
            formSeleccionarMascotaEditar.ShowDialog();

            // No es necesario cargar datos adicionales, ya que todos los datos se pasan desde FormSeleccionarMascotaEditar
        }

        // Método para llenar los campos con los datos de la mascota seleccionada
        public void LlenarCamposMascota(int mascotaId, int clienteId, string nombre, string especie, string raza, decimal peso, string genero, DateTime fechaNacimiento, byte[] foto, string nombreCliente)
        {
            this.mascotaId = mascotaId; // Guardar el ID de la mascota seleccionada
            this.clienteId = clienteId; // Guardar el ID del cliente asociado
            txtNombre.Text = nombre;
            cbxEspecie.Text = especie;
            cbxRaza.Text = raza;
            txtPeso.Text = peso.ToString();
            cbxGenero.SelectedItem = genero == "M" ? "Macho" : "Hembra";
            dtpFechaNacimiento.SelectionStart = fechaNacimiento;

            // Llenar el nombre del cliente en el campo correspondiente
            txtCliente.Text = nombreCliente;

            if (foto != null && foto.Length > 0)
            {
                try
                {
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(foto))
                    {
                        pictureBoxImagen.Image = Image.FromStream(ms);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pictureBoxImagen.Image = null; // Limpiar la imagen en caso de error
                }
            }
            else
            {
                pictureBoxImagen.Image = null; // Limpiar la imagen si no hay datos disponibles
            }
        }
    }
}
