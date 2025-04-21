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

namespace Clinica_Veterinaria
{
    public partial class FormSeleccionarCliente_Mascotas : Form
    {
        private FormAgMascotas formAgMascotas; // Referencia al formulario principal
        private SqlConnection cnx;

        public FormSeleccionarCliente_Mascotas(FormAgMascotas formAgMascotas, SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
            this.formAgMascotas = formAgMascotas;
            CargarClientes();
        }

        // Método para cargar los clientes en el DataGridView
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

        // Método para manejar la selección del cliente
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvCliente.CurrentRow.Cells["Cliente_id"].Value?.ToString());
                string nombre = dgvCliente.CurrentRow.Cells["Nombre"].Value?.ToString();

                // Pasar los datos al formulario principal
                formAgMascotas.SetClienteSeleccionado(id, nombre);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
