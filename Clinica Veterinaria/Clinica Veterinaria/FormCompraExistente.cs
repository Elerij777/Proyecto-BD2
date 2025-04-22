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
        public bool ModoEdicion { get; set; } = false;
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
                // Validaciones comunes para ambos modos
                if (ProveedorId == 0)
                {
                    MessageBox.Show("Debe seleccionar un proveedor primero.");
                    return;
                }

                if (ProductoId == 0)
                {
                    MessageBox.Show("Debe seleccionar un producto primero.");
                    return;
                }

                if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser un número mayor a cero.");
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

                // Determine si estamos en modo edición o insertando una nueva compra
                string procedureName;
                SqlCommand cmd;

                if (ModoEdicion)
                {
                    // Es una edición de compra existente
                    procedureName = "ActualizarCompraExistente";
                    cmd = new SqlCommand(procedureName, cnx);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Compra_id", CompraId);
                    cmd.Parameters.AddWithValue("@Proveedor_id", ProveedorId);
                    cmd.Parameters.AddWithValue("@Producto_id", ProductoId);
                    cmd.Parameters.AddWithValue("@Fecha", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@Precio", precio);
                    cmd.Parameters.AddWithValue("@Detalle", txtDetalle.Text);
                }
                else
                {
                    // Es una nueva compra de producto existente
                    procedureName = "spInsertarCompraProductoExistente";
                    cmd = new SqlCommand(procedureName, cnx);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Proveedor_id", ProveedorId);
                    cmd.Parameters.AddWithValue("@Producto_id", ProductoId);
                    cmd.Parameters.AddWithValue("@Fecha", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@Precio", precio);
                    cmd.Parameters.AddWithValue("@Detalle", txtDetalle.Text);
                }

                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int productoId = Convert.ToInt32(reader["Producto_id"]);
                            int compraId = Convert.ToInt32(reader["Compra_id"]);

                            string mensaje = ModoEdicion
                                ? $"Compra actualizada exitosamente.\nProducto ID: {productoId}\nCompra ID: {compraId}"
                                : $"Nueva compra registrada exitosamente.\nProducto ID: {productoId}\nCompra ID: {compraId}";

                            MessageBox.Show(mensaje);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se recibió confirmación de la operación.");
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Error en la base de datos: {sqlEx.Message}", "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public int CompraId { get; set; }

        // Agregar estos métodos a la clase FormCompraExistente
        public void txtCantidadSetText(string text)
        {
            txtCantidad.Text = text;
        }

        public void txtPrecioSetText(string text)
        {
            txtPrecio.Text = text;
        }

        public void txtDetalleSetText(string text)
        {
            txtDetalle.Text = text;
        }

        public void dateTimePicker1SetValue(DateTime value)
        {
            dateTimePicker1.Value = value;
        }

    }
}
