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
        private Dictionary<string, int> clientesDict = new Dictionary<string, int>();

        public FormAgMascotas(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;

            cbxGenero.Items.Add("Macho");
            cbxGenero.Items.Add("Hembra");
            cbxRaza.Items.Add("Comun Europeo");

            // Cargar clientes al combobox
            CargarClientes();
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



        private void CargarClientes()
        {
            try
            {
                clientesDict.Clear();
                cbxClientes.Items.Clear();

                using (SqlCommand cmd = new SqlCommand("SELECT  Cliente_id, Nombre FROM Clientes ORDER BY Nombre", cnx))
                {
                    if (cnx.State != ConnectionState.Open)
                    {
                        cnx.Open();
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["Cliente_id"]);
                            string nombre = reader["Nombre"].ToString();

                            // Guardar la relación nombre-id en el diccionario
                            clientesDict[nombre] = id;

                            // Agregar el nombre al combobox
                            cbxClientes.Items.Add(nombre);
                        }
                    }
                    cnx.Close();
                }

                cbxClientes.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Validar que todos los campos estén llenos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    cbxEspecie.SelectedItem == null ||
                    cbxRaza.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtPeso.Text) ||
                    cbxGenero.SelectedItem == null ||
                    pictureBoxImagen.Image == null ||
                    cbxClientes.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, complete todos los campos y seleccione una imagen y un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nombre = txtNombre.Text;
                string especie = cbxEspecie.Text;
                string raza = cbxRaza.Text;
                decimal peso = Convert.ToDecimal(txtPeso.Text);
                string genero = cbxGenero.SelectedItem.ToString() == "Macho" ? "M" : "F";
                DateTime fechaNacimiento = dtpFechaNacimiento.SelectionStart;
                int clienteId = clientesDict[cbxClientes.SelectedItem.ToString()];

                byte[] imagenBytes = null;
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                {
                    pictureBoxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imagenBytes = ms.ToArray();
                }

                await Task.Run(() =>
                {
                    using (SqlCommand cmd = new SqlCommand("spInsertarMascota", cnx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Cliente_id", clienteId);
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
                });

                MessageBox.Show("Mascota agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                PlayAnimalSound(especie);

                // Limpiar controles
                txtNombre.Clear();
                cbxEspecie.SelectedIndex = -1;
                cbxRaza.SelectedIndex = -1;
                txtPeso.Clear();
                cbxGenero.SelectedIndex = -1;
                dtpFechaNacimiento.SelectionStart = DateTime.Now;
                pictureBoxImagen.Image = null;
                cbxClientes.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la mascota: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnAgregar.Enabled = true;
            }
        }



    }
}
