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

namespace Clinica_Veterinaria
{
    public partial class FormVerMascotas : Form
    {
        SqlConnection cnx;

        public FormVerMascotas(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
            CargarMascotas();
        }

        private void CargarMascotas()
        {
            try
            {
                // Consulta a la vista VistaMascotasConClientes
                string query = "SELECT * FROM VistaMascotasConClientes";

                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Asignar los datos al DataGridView
                    dgvProductos.DataSource = dt;

                    // Configurar columnas del DataGridView
                    dgvProductos.Columns["Mascota_ID"].HeaderText = "ID";
                    dgvProductos.Columns["NombreMascota"].HeaderText = "Nombre de la Mascota";
                    dgvProductos.Columns["Especie"].HeaderText = "Especie";
                    dgvProductos.Columns["Raza"].HeaderText = "Raza";
                    dgvProductos.Columns["Peso"].HeaderText = "Peso (kg)";
                    dgvProductos.Columns["Genero"].HeaderText = "Género";
                    dgvProductos.Columns["Fecha_nacimiento"].HeaderText = "Fecha de Nacimiento";
                    dgvProductos.Columns["NombreCliente"].HeaderText = "Nombre del Cliente";

                    // Opcional: Ocultar la columna MascotaID si no es necesaria
                    dgvProductos.Columns["Mascota_ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las mascotas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
