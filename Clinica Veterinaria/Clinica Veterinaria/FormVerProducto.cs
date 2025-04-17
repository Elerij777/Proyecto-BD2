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
        private DataTable dtProductos;
        SqlDataAdapter adpProductos;

        public FormVerProducto(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
            ConfigurarDataAdapter();
            CargarProductos(""); 
        }

        public void ConfigurarDataAdapter()
        {
            try
            {
                adpProductos = new SqlDataAdapter("spObtenerProductos", cnx);
                adpProductos.SelectCommand.CommandType = CommandType.StoredProcedure;

                adpProductos.InsertCommand = new SqlCommand("spInsertarProducto", cnx);
                adpProductos.InsertCommand.CommandType = CommandType.StoredProcedure;
                adpProductos.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
                adpProductos.InsertCommand.Parameters.Add("@Existencias", SqlDbType.Int, 4, "Existencias");
                adpProductos.InsertCommand.Parameters.Add("@Costo", SqlDbType.Decimal, 10, "Costo");
                adpProductos.InsertCommand.Parameters.Add("@Precio", SqlDbType.Decimal, 10, "Precio");
                adpProductos.InsertCommand.Parameters.Add("@Fecha_caducidad", SqlDbType.DateTime, 0, "Fecha_caducidad");
                adpProductos.InsertCommand.Parameters.Add("@Tipo_producto", SqlDbType.VarChar, 50, "Tipo_producto");

                adpProductos.UpdateCommand = new SqlCommand("spActualizarProducto", cnx);
                adpProductos.UpdateCommand.CommandType = CommandType.StoredProcedure;
                adpProductos.UpdateCommand.Parameters.Add("@ProductoID", SqlDbType.Int, 4, "Producto_ID");
                adpProductos.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50, "Nombre");
                adpProductos.UpdateCommand.Parameters.Add("@Existencias", SqlDbType.Int, 4, "Existencias");
                adpProductos.UpdateCommand.Parameters.Add("@Costo", SqlDbType.Decimal, 10, "Costo");
                adpProductos.UpdateCommand.Parameters.Add("@Precio", SqlDbType.Decimal, 10, "Precio");
                adpProductos.UpdateCommand.Parameters.Add("@Fecha_caducidad", SqlDbType.DateTime, 0, "Fecha_caducidad");
                adpProductos.UpdateCommand.Parameters.Add("@Tipo_producto", SqlDbType.VarChar, 50, "Tipo_producto");

                adpProductos.DeleteCommand = new SqlCommand("spEliminarProducto", cnx);
                adpProductos.DeleteCommand.CommandType = CommandType.StoredProcedure;
                adpProductos.DeleteCommand.Parameters.Add("@ProductoID", SqlDbType.Int, 4, "Producto_ID");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al configurar el DataAdapter: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    dtProductos = new DataTable();
                    adapter.Fill(dtProductos);

                    dataGridView1.DataSource = dtProductos;

                    if (dataGridView1.Columns.Contains("Producto_ID"))
                    {
                        dataGridView1.Columns["Producto_ID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow row in dtProductos.Rows)
                {
                    if (row.RowState == DataRowState.Deleted) continue;

                    if (string.IsNullOrWhiteSpace(row["Nombre"]?.ToString()))
                    {
                        MessageBox.Show("El nombre no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (row["Existencias"] == DBNull.Value || Convert.ToInt32(row["Existencias"]) < 0)
                    {
                        MessageBox.Show("Las existencias no pueden ser negativas.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                int registrosAfectados = adpProductos.Update(dtProductos);
                dtProductos.Clear();
                adpProductos.Fill(dtProductos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                if (MessageBox.Show("¿Estás seguro que deseas eliminar este registro?", "Confirmar eliminación",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        dtProductos.Rows[dataGridView1.CurrentRow.Index].Delete();

                        int registrosAfectados = adpProductos.Update(dtProductos);

                        if (registrosAfectados > 0)
                        {
                            dtProductos.Clear();
                            adpProductos.Fill(dtProductos);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dtProductos.RejectChanges();
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay una fila seleccionada válida para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(txtBuscador.Text.Trim());
        }
    }
}
