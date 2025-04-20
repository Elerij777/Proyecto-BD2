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
    public partial class FormCompraExistente : Form
    {
        SqlConnection cnx;
        SqlDataAdapter adpCompraExistente;
        DataTable tabCompraExistente;
        public int ProveedorId = 0;
        public int ProductoId = 0;
        public FormCompraExistente(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProveedorId == 0)
                {
                    MessageBox.Show("Debe seleccionar un proveedor primero.");
                    return;
                }

                if (string.IsNullOrEmpty(txtProducto.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre de producto.");
                    return;
                }

                if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser un número mayor a cero.");
                    return;
                }

                if (!float.TryParse(txtPrecio.Text, out float costo) || costo <= 0)
                {
                    MessageBox.Show("El costo debe ser un número mayor a cero.");
                    return;
                }

                if (!float.TryParse(txtPrecio.Text, out float precio) || precio <= 0)
                {
                    MessageBox.Show("El precio debe ser un número mayor a cero.");
                    return;
                }
                if (cnx.State != ConnectionState.Open)
                {
                    cnx.Open();
                }


                using (SqlCommand cmd = new SqlCommand("ActualizarCompraExistente", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Proveedor_id", ProveedorId);
                    cmd.Parameters.AddWithValue("@Detalle", txtDetalle.Text);
                    cmd.Parameters.AddWithValue("@Fecha", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Producto_id", ProductoId);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@Costo", costo);
                    cmd.Parameters.AddWithValue("@Precio", precio);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int productoId = Convert.ToInt32(reader["Producto_id"]);
                        int compraId = Convert.ToInt32(reader["Compra_id"]);
                        MessageBox.Show($"Compra registrada exitosamente.\nProducto ID: {productoId}\nCompra ID: {compraId}");
                    }
                    reader.Close();

                    // Clear form fields after successful insertion
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la compra: " + ex.Message);
            }
        }
        public void txtProveedorSetText(string text)
        {
            txtProveedor.Text = text;
        }

        public void txtProductoSetText(string text)
        {
            txtProducto.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSeleccionarProducto formSeleccionarProducto = new FormSeleccionarProducto(cnx, this);
            formSeleccionarProducto.ShowDialog();
        }

        private void BtnElegirProveedor_Click(object sender, EventArgs e)
        {
            FormSeleccionarProveedor formSeleccionarProveedor = new FormSeleccionarProveedor(cnx, this);
            formSeleccionarProveedor.ShowDialog();
        }

        private void LimpiarFormulario()
        {
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtPrecio.Clear();
            txtDetalle.Clear();
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
