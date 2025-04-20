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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Clinica_Veterinaria
{
    public partial class FormSeleccionarServicio_Venta : Form
    {
        SqlConnection cnx;
        FormVentas formVentas;
        int ClienteId;
        public FormSeleccionarServicio_Venta(SqlConnection cnx,FormVentas formVentas, int clienteId)
        {
            this.cnx = cnx;
            this.formVentas = formVentas;
            InitializeComponent();
            ClienteId = clienteId;
            CargarServicio();
        }
        public void CargarServicio()
        {

            {
                try
                {
                    cnx.Open();
                    using (SqlCommand cmd = new SqlCommand("SPCargarServiciosVenta", cnx))

                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ClienteId", ClienteId);


                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvProducto.DataSource = dt;
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
            if (dgvProducto.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvProducto.CurrentRow.Cells["Id"].Value?.ToString());
                string Nombre = dgvProducto.CurrentRow.Cells["Descripcion"].Value?.ToString();
                decimal costo = Convert.ToDecimal(dgvProducto.CurrentRow.Cells["CostoUnitario"].Value?.ToString());
                int empleadoId = Convert.ToInt32(dgvProducto.CurrentRow.Cells["EmpleadoId"].Value.ToString());
                formVentas.AgregarServicio(Nombre, 1, costo, 0.15m,empleadoId, id);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
