using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_Veterinaria
{
    public partial class FormSeleccionarClienteVehiculo : Form
    {
        SqlConnection cnx;
        FormVehiculo formVehiculo;
        public FormSeleccionarClienteVehiculo(SqlConnection cnx,FormVehiculo formVehiculo)
        {
            InitializeComponent();
            this.cnx = cnx;
            this.formVehiculo = formVehiculo;
            CargarClientes();
        }
        public void CargarClientes()
        {
            try
            {
                cnx.Open();
                using (SqlCommand cmd = new SqlCommand("SPCargarHumanos", cnx)) // Asume que el SP es el mismo
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvCliente.DataSource = dt; // Asume que tienes un DataGridView llamado dgvCliente
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAcceptar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvCliente.CurrentRow.Cells["Cliente_id"].Value?.ToString());
                string nombre = dgvCliente.CurrentRow.Cells["Nombre"].Value?.ToString();

                // Pasar los datos al formulario principal
                formVehiculo.SetClienteSeleccionado(id, nombre);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
