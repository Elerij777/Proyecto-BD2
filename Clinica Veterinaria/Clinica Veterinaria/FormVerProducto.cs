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
    public partial class FormVerProducto : Form
    {
        private SqlConnection cnx;

        public FormVerProducto(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
            CargarProductos(""); // Cargar todos los productos al iniciar
        }

        private void CargarProductos(string nombre)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spObtenerProductosPorNombre", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", nombre);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;

                    // Configurar encabezados del DataGridView
                    dataGridView1.Columns["Producto_ID"].HeaderText = "ID";
                    dataGridView1.Columns["Nombre"].HeaderText = "Nombre";
                    dataGridView1.Columns["Existencias"].HeaderText = "Existencias";
                    dataGridView1.Columns["Costo"].HeaderText = "Costo";
                    dataGridView1.Columns["Precio"].HeaderText = "Precio";
                    dataGridView1.Columns["Fecha_caducidad"].HeaderText = "Fecha de Caducidad";
                    dataGridView1.Columns["Tipo_producto"].HeaderText = "Tipo de Producto";

                    dataGridView1.Columns["Producto_ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            // Llamar a CargarProductos con el texto del buscador
            CargarProductos(txtBuscador.Text.Trim());
        }
    }
}