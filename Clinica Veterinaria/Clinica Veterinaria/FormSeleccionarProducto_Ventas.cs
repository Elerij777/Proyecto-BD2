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
using Microsoft.VisualBasic;

namespace Clinica_Veterinaria
{
    public partial class FormSeleccionarProducto_Ventas : Form
    {
        SqlConnection cnx;
        FormVentas formVentas;
        int numero = 0;
        string input = "";

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
            while (true)
            {
                input = Interaction.InputBox("Ingrese La cantidad del producto que se va a vender", "Cantidad del producto", "");

                if (string.IsNullOrWhiteSpace(input))
                {
                    return;
                }
                if (int.TryParse(input, out numero) && numero > 0)
                    break;
                else
                    MessageBox.Show("Debe ingresar un número entero válido mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dgvProducto.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvProducto.CurrentRow.Cells["Producto_id"].Value?.ToString());
                string Nombre = dgvProducto.CurrentRow.Cells["Nombre"].Value?.ToString();
                decimal costo = Convert.ToDecimal(dgvProducto.CurrentRow.Cells["Costo"].Value?.ToString());
                formVentas.AgregarProducto(Nombre,numero,costo,0.15m , id);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
