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
            CargarHumanos();
        }

        private void CargarHumanos()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spObtenerHumanos", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dtHumanos = new DataTable();
                    da.Fill(dtHumanos);

                    dataGridView1.DataSource = dtHumanos;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar humanos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormVerHumanos_Load(object sender, EventArgs e)
        {
            try
            {
                /*
                adpHumanos = new SqlDataAdapter("SELECT * FROM Humanos", cnx);

                // Insert
                adpHumanos.InsertCommand = new SqlCommand("spInsertarHumanos", cnx);
                adpHumanos.InsertCommand.CommandType = CommandType.StoredProcedure;
                adpHumanos.InsertCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "Nombre");
                adpHumanos.InsertCommand.Parameters.Add("@telefono", SqlDbType.VarChar, 20, "Telefono");
                adpHumanos.InsertCommand.Parameters.Add("@direccion", SqlDbType.VarChar, 100, "Direccion");
                adpHumanos.InsertCommand.Parameters.Add("@email", SqlDbType.VarChar, 100, "Email");

                // Update
                adpHumanos.UpdateCommand = new SqlCommand("spActualizarHumano", cnx);
                adpHumanos.UpdateCommand.CommandType = CommandType.StoredProcedure;
                adpHumanos.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 4, "HumanoID");
                adpHumanos.UpdateCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "Nombre");
                adpHumanos.UpdateCommand.Parameters.Add("@telefono", SqlDbType.VarChar, 20, "Telefono");
                adpHumanos.UpdateCommand.Parameters.Add("@direccion", SqlDbType.VarChar, 100, "Direccion");
                adpHumanos.UpdateCommand.Parameters.Add("@email", SqlDbType.VarChar, 100, "Email");

                // Load data
                dtHumanos = new DataTable();
                adpHumanos.Fill(dtHumanos);

                dataGridView1.DataSource = dtHumanos;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar humanos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool errores = false;

                foreach (DataRow row in dtHumanos.Rows)
                {
                    if (row.RowState == DataRowState.Deleted) continue;

                    if (string.IsNullOrWhiteSpace(row["Nombre"].ToString()))
                    {
                        MessageBox.Show("El nombre no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errores = true;
                        break;
                    }

                    if (string.IsNullOrWhiteSpace(row["Email"].ToString()))
                    {
                        MessageBox.Show("El correo electrónico no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errores = true;
                        break;
                    }
                }

                if (errores) return;

                adpHumanos.Update(dtHumanos);
                MessageBox.Show("Cambios guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


