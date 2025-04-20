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
using PdfSharp.Pdf.Content.Objects;


namespace Clinica_Veterinaria
{
    public partial class FormSeleccionarProducto : Form
    {
        SqlConnection cnx;
        private object formOrigen;
        public FormSeleccionarProducto(SqlConnection cnx, object formOrigen)
        {
            InitializeComponent();
            this.cnx = cnx;
            this.formOrigen = formOrigen;
            CargarProductos("");
        }
        private void CargarProductos(string filtro)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spCargarProductos", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@Filtro", string.IsNullOrEmpty(filtro) ? (object)DBNull.Value : filtro);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvProductos.DataSource = dt;

                    dgvProductos.Columns["Producto_id"].HeaderText = "ID";
                    dgvProductos.Columns["Nombre"].HeaderText = "Nombre";
                    dgvProductos.Columns["Existencias"].HeaderText = "Existencias";
                    dgvProductos.Columns["Costo"].HeaderText = "Costo";
                    dgvProductos.Columns["Precio"].HeaderText = "Precio";
                    dgvProductos.Columns["Fecha_caducidad"].HeaderText = "Fecha_caducidad";
                    dgvProductos.Columns["Tipo_producto"].HeaderText = "Tipo_producto";

                    dgvProductos.Columns["Producto_id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {

            if (dgvProductos.CurrentRow != null)
            {
                int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Producto_id"].Value);
                string nombreProducto = dgvProductos.CurrentRow.Cells["Nombre"].Value.ToString();

                if (formOrigen is FormCompras formCompras)
                {
                    formCompras.ProductoId = idProducto;
                    formCompras.txtProductoSetText(nombreProducto);
                }
                else if (formOrigen is FormCompraExistente formComprasExistente)
                {
                    formComprasExistente.ProductoId = idProducto;
                    formComprasExistente.txtProductoSetText(nombreProducto);
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Producto.", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(txtBuscar.Text.Trim());
        }

    }
}
