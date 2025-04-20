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
    public partial class FormCompras : Form
    {
        SqlConnection cnx;
        SqlDataAdapter adpCompras;
        public int ProveedorId = 0;
        public int ProductoId = 0;
        private DataTable tabCompras;

        public FormCompras(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
            CargarTiposProducto();
            ConfigurarDataAdapter();
        }

        public void txtProductoSetText(string text)
        {
            txtNombreProducto.Text = text;
        }
        private void ConfigurarDataAdapter()
        {
            adpCompras = new SqlDataAdapter();

            // Configurar el SelectCommand
            adpCompras.SelectCommand = new SqlCommand("spListarCompras", cnx);
            adpCompras.SelectCommand.CommandType = CommandType.StoredProcedure;

            // Configurar el InsertCommand
            adpCompras.InsertCommand = new SqlCommand("spInsertarCompra", cnx);
            adpCompras.InsertCommand.CommandType = CommandType.StoredProcedure;
            adpCompras.InsertCommand.Parameters.Add("@Proveedor_id", SqlDbType.Int, 4, "Proveedor_id");
            adpCompras.InsertCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha");
            adpCompras.InsertCommand.Parameters.Add("@Producto_id", SqlDbType.Int, 4, "Producto_id");
            adpCompras.InsertCommand.Parameters.Add("@Cantidad", SqlDbType.Int, 4, "Cantidad");
            adpCompras.InsertCommand.Parameters.Add("@Costo", SqlDbType.Decimal, 8, "Costo");
            adpCompras.InsertCommand.Parameters.Add("@Precio", SqlDbType.Decimal, 8, "Precio");
            adpCompras.InsertCommand.Parameters.Add("@Detalle", SqlDbType.VarChar, 200, "Detalle");

            // Configurar el UpdateCommand
            adpCompras.UpdateCommand = new SqlCommand("spActualizarCompra", cnx);
            adpCompras.UpdateCommand.CommandType = CommandType.StoredProcedure;
            adpCompras.UpdateCommand.Parameters.Add("@Compra_id", SqlDbType.Int, 4, "Compra_id");
            adpCompras.UpdateCommand.Parameters.Add("@Cantidad", SqlDbType.Int, 4, "Cantidad");
            adpCompras.UpdateCommand.Parameters.Add("@Costo", SqlDbType.Decimal, 8, "Costo");
            adpCompras.UpdateCommand.Parameters.Add("@Precio", SqlDbType.Decimal, 8, "Precio");
            adpCompras.UpdateCommand.Parameters.Add("@Detalle", SqlDbType.VarChar, 200, "Detalle");

            // Configurar el DeleteCommand
            adpCompras.DeleteCommand = new SqlCommand("spEliminarCompra", cnx);
            adpCompras.DeleteCommand.CommandType = CommandType.StoredProcedure;
            adpCompras.DeleteCommand.Parameters.Add("@Compra_id", SqlDbType.Int, 4, "Compra_id");
        }
        private void CargarDatos()
        {
            try
            {
                tabCompras = new DataTable();
                adpCompras.Fill(tabCompras);
                dgvCompras.DataSource = tabCompras;
                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las compras: " + ex.Message);
            }
        }

        private void ConfigurarDataGridView()
        {
            dgvCompras.AutoGenerateColumns = false;
            dgvCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompras.MultiSelect = false;
            dgvCompras.ReadOnly = true;

            dgvCompras.Columns.Clear();

            DataGridViewTextBoxColumn colCompraId = new DataGridViewTextBoxColumn();
            colCompraId.Name = "Compra_id";
            colCompraId.HeaderText = "ID";
            colCompraId.DataPropertyName = "Compra_id";
            dgvCompras.Columns.Add(colCompraId);

            DataGridViewTextBoxColumn colProveedor = new DataGridViewTextBoxColumn();
            colProveedor.Name = "Proveedor_id";
            colProveedor.HeaderText = "Proveedor_id";
            colProveedor.DataPropertyName = "Proveedor_id";
            dgvCompras.Columns.Add(colProveedor);

            DataGridViewTextBoxColumn colDetalle = new DataGridViewTextBoxColumn();
            colDetalle.Name = "Detalle";
            colDetalle.HeaderText = "Detalle";
            colDetalle.DataPropertyName = "Detalle";
            colDetalle.Width = 150;
            dgvCompras.Columns.Add(colDetalle);

            DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
            colFecha.Name = "Fecha";
            colFecha.HeaderText = "Fecha";
            colFecha.DataPropertyName = "Fecha";
            colFecha.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvCompras.Columns.Add(colFecha);

            DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
            colCantidad.Name = "Cantidad";
            colCantidad.HeaderText = "Cantidad";
            colCantidad.DataPropertyName = "Cantidad";
            dgvCompras.Columns.Add(colCantidad);

            DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn();
            colPrecio.Name = "Precio";
            colPrecio.HeaderText = "Precio";
            colPrecio.DataPropertyName = "Precio";
            colPrecio.DefaultCellStyle.Format = "C2";
            dgvCompras.Columns.Add(colPrecio);

        }
        private void FormCompras_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }



        private void BtnElegirProveedor_Click(object sender, EventArgs e)
        {
            FormSeleccionarProveedor formSeleccionarProveedor = new FormSeleccionarProveedor(cnx, this);
            formSeleccionarProveedor.ShowDialog();
        }


        public void txtProveedorSetText(string text)
        {
            txtProveedor.Text = text;
        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProveedorId == 0)
                {
                    MessageBox.Show("Debe seleccionar un proveedor primero.");
                    return;
                }

                if (string.IsNullOrEmpty(txtNombreProducto.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre de producto.");
                    return;
                }

                if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser un número mayor a cero.");
                    return;
                }

                if (!float.TryParse(txtCosto.Text, out float costo) || costo <= 0)
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


                using (SqlCommand cmd = new SqlCommand("InsertarNuevaCompra", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Proveedor_id", ProveedorId);
                    cmd.Parameters.AddWithValue("@Detalle", txtDetalle.Text);
                    cmd.Parameters.AddWithValue("@Fecha", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Nombre_Producto", txtNombreProducto.Text);
                    cmd.Parameters.AddWithValue("@Tipo_Producto", comboTipoProducto.SelectedItem.ToString());
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
        private void CargarTiposProducto()
        {
            try
            {
                comboTipoProducto.Items.Clear();
                comboTipoProducto.Items.Add("Inventario");
                comboTipoProducto.Items.Add("Alimento");
                comboTipoProducto.Items.Add("Producto");
                comboTipoProducto.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tipos de producto: " + ex.Message);
            }
        }
        private void LimpiarFormulario()
        {
            txtNombreProducto.Clear();
            txtCantidad.Clear();
            txtCosto.Clear();
            txtPrecio.Clear();
            txtDetalle.Clear();
            comboTipoProducto.SelectedIndex = 0;
        }

        private void comboTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCompras_Load_1(object sender, EventArgs e)
        {
            CargarDatos();
        }


        private void btn_existente_Click(object sender, EventArgs e)
        {
            FormCompraExistente formCompraExistente = new FormCompraExistente(cnx);
            formCompraExistente.ShowDialog();
        }
    }
}