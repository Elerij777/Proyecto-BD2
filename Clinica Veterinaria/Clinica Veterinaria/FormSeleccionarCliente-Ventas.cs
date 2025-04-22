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
using System.Windows.Forms.VisualStyles;

namespace Clinica_Veterinaria
{
    public partial class FormSeleccionarCliente_Ventas : Form
    {
        FormVentas formVentas;
        SqlConnection cnx;
        public FormSeleccionarCliente_Ventas(FormVentas formVentas, SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
            this.formVentas = formVentas;
            CargarHumanos();
        }
        public void CargarHumanos()
        {

            {
                try
                {
                    cnx.Open();
                    using (SqlCommand cmd = new SqlCommand("SPCargarHumanos", cnx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvCliente.DataSource = dt;
                    }
                    cnx.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        private void BtnAcceptar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvCliente.CurrentRow.Cells["Cliente_id"].Value?.ToString());
                string Nombre = dgvCliente.CurrentRow.Cells["Nombre"].Value?.ToString();
                formVentas.clienteId = id;
                formVentas.setTxtCliente(Nombre);
                formVentas.CargarFacturasPendientesYAgregarServicio(id);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
