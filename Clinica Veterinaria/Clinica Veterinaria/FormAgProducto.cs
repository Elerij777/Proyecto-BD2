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

namespace Clinica_Veterinaria
{
    public partial class FormAgProducto : Form
    {
        private SqlConnection cnx;

        public FormAgProducto(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
            CargarTiposProducto();
        }

        private void CargarTiposProducto()
        {
            try
            {
                // Limpiar el ComboBox y agregar las opciones 'Producto' e 'Inventario'
                cbxTipoProduc.Items.Clear();
                cbxTipoProduc.Items.Add("Producto");
                cbxTipoProduc.Items.Add("Inventario");

                cbxTipoProduc.SelectedIndex = -1; // Sin selección inicial
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los tipos de producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtExistencias.Text) ||
                    string.IsNullOrWhiteSpace(txtCosto.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                    cbxTipoProduc.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar valores numéricos
                if (!int.TryParse(txtExistencias.Text, out int existencias) || existencias < 0)
                {
                    MessageBox.Show("Las existencias deben ser un número entero positivo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtCosto.Text, out decimal costo) || costo < 0)
                {
                    MessageBox.Show("El costo debe ser un valor numérico positivo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio < 0)
                {
                    MessageBox.Show("El precio debe ser un valor numérico positivo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el valor seleccionado del ComboBox
                string tipoProducto = cbxTipoProduc.SelectedItem.ToString();

                // Llamar al procedimiento almacenado para insertar el producto
                using (SqlCommand cmd = new SqlCommand("spInsertarProducto", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@Existencias", existencias);
                    cmd.Parameters.AddWithValue("@Costo", costo);
                    cmd.Parameters.AddWithValue("@Precio", precio);
                    cmd.Parameters.AddWithValue("@Fecha_caducidad", dtpFechaCaducidad.SelectionStart);
                    cmd.Parameters.AddWithValue("@Tipo_producto", tipoProducto);

                    if (cnx.State != ConnectionState.Open)
                        cnx.Open();

                    cmd.ExecuteNonQuery();
                    cnx.Close();

                    MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtExistencias.Clear();
            txtCosto.Clear();
            txtPrecio.Clear();
            cbxTipoProduc.SelectedIndex = -1;
            dtpFechaCaducidad.SelectionStart = DateTime.Now;
        }
    }
}