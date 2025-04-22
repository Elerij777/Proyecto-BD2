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
    public partial class FormProveedores : Form
    {
        private SqlConnection cnx;
        private DataTable dtProveedores;
        private SqlDataAdapter adpProveedores;

        public FormProveedores(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
            dataGridView1.AllowUserToDeleteRows = true;
            ConfigurarDataAdapter();
            CargarProveedores("");
        }

        private void ConfigurarDataAdapter()
        {
            try
            {
                adpProveedores = new SqlDataAdapter("ObtenerProveedores", cnx);
                adpProveedores.SelectCommand.CommandType = CommandType.StoredProcedure;

                // Comando INSERT
                adpProveedores.InsertCommand = new SqlCommand("InsertarProveedor", cnx);
                adpProveedores.InsertCommand.CommandType = CommandType.StoredProcedure;
                adpProveedores.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
                adpProveedores.InsertCommand.Parameters.Add("@Telefono", SqlDbType.VarChar, 20, "Telefono");
                adpProveedores.InsertCommand.Parameters.Add("@Direccion", SqlDbType.VarChar, 200, "Direccion");
                adpProveedores.InsertCommand.Parameters.Add("@Correo", SqlDbType.VarChar, 100, "Correo");

                // Comando UPDATE
                adpProveedores.UpdateCommand = new SqlCommand("ActualizarProveedor", cnx);
                adpProveedores.UpdateCommand.CommandType = CommandType.StoredProcedure;
                adpProveedores.UpdateCommand.Parameters.Add("@Proveedor_id", SqlDbType.Int, 4, "Proveedor_id");
                adpProveedores.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
                adpProveedores.UpdateCommand.Parameters.Add("@Telefono", SqlDbType.VarChar, 20, "Telefono");
                adpProveedores.UpdateCommand.Parameters.Add("@Direccion", SqlDbType.VarChar, 200, "Direccion");
                adpProveedores.UpdateCommand.Parameters.Add("@Correo", SqlDbType.VarChar, 100, "Correo");

                // Comando DELETE
                adpProveedores.DeleteCommand = new SqlCommand("EliminarProveedor", cnx);
                adpProveedores.DeleteCommand.CommandType = CommandType.StoredProcedure;
                adpProveedores.DeleteCommand.Parameters.Add("@Proveedor_id", SqlDbType.Int, 4, "Proveedor_id");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al configurar el DataAdapter: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProveedores(string nombre)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spObtenerProveedoresPorNombre", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", nombre);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    dtProveedores = new DataTable();
                    adapter.Fill(dtProveedores);

                    dataGridView1.DataSource = dtProveedores;

                    if (dataGridView1.Columns.Contains("Proveedor_id"))
                    {
                        dataGridView1.Columns["Proveedor_id"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proveedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow row in dtProveedores.Rows)
                {
                    if (row.RowState == DataRowState.Deleted) continue;

                    if (string.IsNullOrWhiteSpace(row["Nombre"]?.ToString()))
                    {
                        MessageBox.Show("El nombre no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                int registrosAfectados = adpProveedores.Update(dtProveedores);
                dtProveedores.Clear();
                adpProveedores.Fill(dtProveedores);
                MessageBox.Show($"Se guardaron {registrosAfectados} cambios correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            CargarProveedores(txtBuscar.Text.Trim());
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores("");
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error al procesar los datos: " + e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ThrowException = false;
        }
    }
}
