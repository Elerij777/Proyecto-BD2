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
    public partial class FormSeleccionarProducto_Ventas : Form
    {
        SqlConnection cnx;
        FormVentas formVentas;
        public FormSeleccionarProducto_Ventas(SqlConnection cnx, FormVentas formVentas)
        {
            InitializeComponent();
            this.cnx = cnx;
            this.formVentas = formVentas;
            CargarProductos();
        }
        public void CargarProductos()
        {

            {
                try
                {
                    cnx.Open();
                    using (SqlCommand cmd = new SqlCommand("SPCargarProductosVenta", cnx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

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
                int id = Convert.ToInt32(dgvProducto.CurrentRow.Cells["Cliente_id"].Value?.ToString());
                string Nombre = dgvProducto.CurrentRow.Cells["Nombre"].Value?.ToString();
                formVentas.clienteId = id;
                formVentas.setTxtCliente(Nombre);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
