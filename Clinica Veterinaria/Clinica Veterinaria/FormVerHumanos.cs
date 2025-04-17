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
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;

namespace Clinica_Veterinaria
{
    public partial class FormVerHumanos : Form
    {
        private SqlConnection cnx;
        private DataTable dtHumanos;
        SqlDataAdapter adpHumanos;


        public FormVerHumanos(SqlConnection conexion)
        {
            InitializeComponent();
            cnx = conexion;
            ConfigurarDataAdapter();
            CargarHumanos("");
        }

        public void ConfigurarDataAdapter()
        {
            try
            {
                adpHumanos = new SqlDataAdapter("SELECT Cliente_id, Nombre, Telefono, Direccion FROM Clientes", cnx);

                adpHumanos.InsertCommand = new SqlCommand("spInsertarHumanos", cnx);
                adpHumanos.InsertCommand.CommandType = CommandType.StoredProcedure;
                adpHumanos.InsertCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "Nombre");
                adpHumanos.InsertCommand.Parameters.Add("@telefono", SqlDbType.VarChar, 20, "Telefono");
                adpHumanos.InsertCommand.Parameters.Add("@direccion", SqlDbType.VarChar, 100, "Direccion");

                adpHumanos.UpdateCommand = new SqlCommand("spActualizarHumano", cnx);
                adpHumanos.UpdateCommand.CommandType = CommandType.StoredProcedure;
                adpHumanos.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 4, "Cliente_id");
                adpHumanos.UpdateCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "Nombre");
                adpHumanos.UpdateCommand.Parameters.Add("@telefono", SqlDbType.VarChar, 20, "Telefono");
                adpHumanos.UpdateCommand.Parameters.Add("@direccion", SqlDbType.VarChar, 100, "Direccion");

                adpHumanos.DeleteCommand = new SqlCommand("spEliminarHumano", cnx);
                adpHumanos.DeleteCommand.CommandType = CommandType.StoredProcedure;
                adpHumanos.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 4, "Cliente_id");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al configurar el DataAdapter: " + ex.Message,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarHumanos(string nombre)
        {
            try
            {
                string query = "SELECT Cliente_id, Nombre, Telefono, Direccion FROM Clientes";

                // Si se proporciona un nombre, agregamos un filtro
                if (!string.IsNullOrEmpty(nombre))
                {
                    query += " WHERE Nombre LIKE @Nombre";
                }

                // Configuramos el DataAdapter con la nueva consulta
                adpHumanos.SelectCommand = new SqlCommand(query, cnx);
                if (!string.IsNullOrEmpty(nombre))
                {
                    adpHumanos.SelectCommand.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");
                }

                dtHumanos = new DataTable();
                adpHumanos.Fill(dtHumanos);

                dataGridView1.DataSource = dtHumanos;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AllowUserToAddRows = true;

                if (dataGridView1.Columns.Contains("Cliente_id"))
                {
                    dataGridView1.Columns["Cliente_id"].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar humanos: " + ex.Message,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormVerHumanos_Load(object sender, EventArgs e)
        {
            CargarHumanos("");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow row in dtHumanos.Rows)
                {
                    if (row.RowState == DataRowState.Deleted) continue;

                    if (string.IsNullOrWhiteSpace(row["Nombre"]?.ToString()))
                    {
                        MessageBox.Show("El nombre no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(row["Telefono"]?.ToString()))
                    {
                        MessageBox.Show("El teléfono no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                int registrosAfectados = adpHumanos.Update(dtHumanos);
                dtHumanos.Clear();
                adpHumanos.Fill(dtHumanos);

                //   MessageBox.Show($"Se guardaron {registrosAfectados} registros correctamente.","Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarHumanos(txtBuscar.Text.Trim());
        }
    }
}


