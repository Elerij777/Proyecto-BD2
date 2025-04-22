using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Clinica_Veterinaria
{
    public partial class FormSeleccionarMascotaEditar : Form
    {
        SqlConnection cnx;
        private FormAgMascotas formAgMascotas;

        public FormSeleccionarMascotaEditar(SqlConnection cnx, FormAgMascotas formAgMascotas)
        {
            InitializeComponent();
            this.cnx = cnx;
            this.formAgMascotas = formAgMascotas;
            CargarMascotas("");
        }

        private void CargarMascotas(string filtro)
        {
            try
            {
                string query = "SELECT * FROM VistaMascotasConClientes";

                if (!string.IsNullOrEmpty(filtro))
                {
                    query += " WHERE Nombre LIKE @Filtro"; // Cambiado de NombreMascota a Nombre
                }

                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {
                    if (!string.IsNullOrEmpty(filtro))
                    {
                        cmd.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvMascotas.DataSource = dt;

                    dgvMascotas.Columns["Mascota_id"].HeaderText = "ID";
                    dgvMascotas.Columns["Nombre"].HeaderText = "Nombre de la Mascota"; // Cambiado de NombreMascota a Nombre
                    dgvMascotas.Columns["Especie"].HeaderText = "Especie";
                    dgvMascotas.Columns["Raza"].HeaderText = "Raza";
                    dgvMascotas.Columns["Peso"].HeaderText = "Peso (kg)";
                    dgvMascotas.Columns["Genero"].HeaderText = "Género";
                    dgvMascotas.Columns["Fecha_nacimiento"].HeaderText = "Fecha de Nacimiento";
                    dgvMascotas.Columns["NombreCliente"].HeaderText = "Nombre del Cliente";
                    dgvMascotas.Columns["Cliente_id"].HeaderText = "ID del Cliente";
                    dgvMascotas.Columns["Foto"].HeaderText = "Foto";

                    dgvMascotas.Columns["Mascota_id"].Visible = false;
                   // dgvMascotas.Columns["Cliente_id"].Visible = false;
                    dgvMascotas.Columns["Foto"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las mascotas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvMascotas.CurrentRow != null)
            {
                try
                {
                    int idMascota = Convert.ToInt32(dgvMascotas.CurrentRow.Cells["Mascota_id"].Value);
                    int idCliente = Convert.ToInt32(dgvMascotas.CurrentRow.Cells["Cliente_id"].Value);
                    string nombreMascota = dgvMascotas.CurrentRow.Cells["Nombre"].Value.ToString();
                    string especie = dgvMascotas.CurrentRow.Cells["Especie"].Value.ToString();
                    string raza = dgvMascotas.CurrentRow.Cells["Raza"].Value.ToString();
                    decimal peso = Convert.ToDecimal(dgvMascotas.CurrentRow.Cells["Peso"].Value);
                    string genero = dgvMascotas.CurrentRow.Cells["Genero"].Value.ToString();
                    DateTime fechaNacimiento = Convert.ToDateTime(dgvMascotas.CurrentRow.Cells["Fecha_nacimiento"].Value);
                    string nombreCliente = dgvMascotas.CurrentRow.Cells["NombreCliente"].Value.ToString(); // Obtener el nombre del cliente
                    byte[] foto = null;

                    // Verificar si la columna Foto existe y contiene datos
                    if (dgvMascotas.Columns.Contains("Foto") && dgvMascotas.CurrentRow.Cells["Foto"].Value != DBNull.Value)
                    {
                        foto = dgvMascotas.CurrentRow.Cells["Foto"].Value as byte[];
                    }

                    // Pasar todos los parámetros requeridos a LlenarCamposMascota
                    formAgMascotas.LlenarCamposMascota(idMascota, idCliente, nombreMascota, especie, raza, peso, genero, fechaNacimiento, foto, nombreCliente);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar la mascota: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una mascota.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarMascotas(txtBuscar.Text.Trim());
        }
    }
}
