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
    public partial class FormBanco : Form
    {
        private SqlConnection cnx;
        private DataTable dtBancos;
        SqlDataAdapter adpBanco;

        public FormBanco(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
            ConfigurarDataAdapter();
            CargarBancos("");
        }

        public void ConfigurarDataAdapter()
        {
            try
            {
                adpBanco = new SqlDataAdapter("spObtenerBancos", cnx);
                adpBanco.SelectCommand.CommandType = CommandType.StoredProcedure;

                // Configurar el comando de inserción
                adpBanco.InsertCommand = new SqlCommand("spInsertarBanco", cnx);
                adpBanco.InsertCommand.CommandType = CommandType.StoredProcedure;
                adpBanco.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
                adpBanco.InsertCommand.Parameters.Add("@Beneficiario", SqlDbType.VarChar, 50, "Beneficiario");
                adpBanco.InsertCommand.Parameters.Add("@NumeroCuenta", SqlDbType.Int, 4, "NumeroCuenta");
                adpBanco.InsertCommand.Parameters.Add("@Tipo", SqlDbType.VarChar, 10, "Tipo");

                // Configurar el comando de actualización
                adpBanco.UpdateCommand = new SqlCommand("spActualizarBanco", cnx);
                adpBanco.UpdateCommand.CommandType = CommandType.StoredProcedure;
                adpBanco.UpdateCommand.Parameters.Add("@Banco_id", SqlDbType.Int, 4, "Banco_ID");
                adpBanco.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
                adpBanco.UpdateCommand.Parameters.Add("@Beneficiario", SqlDbType.VarChar, 50, "Beneficiario");
                adpBanco.UpdateCommand.Parameters.Add("@NumeroCuenta", SqlDbType.Int, 4, "NumeroCuenta");
                adpBanco.UpdateCommand.Parameters.Add("@Tipo", SqlDbType.VarChar, 10, "Tipo");

                // Configurar el comando de eliminación
                adpBanco.DeleteCommand = new SqlCommand("spEliminarBanco", cnx);
                adpBanco.DeleteCommand.CommandType = CommandType.StoredProcedure;
                adpBanco.DeleteCommand.Parameters.Add("@Banco_id", SqlDbType.Int, 4, "Banco_ID");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al configurar el DataAdapter: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarBancos(string nombre)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spObtenerBancosPorNombre", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", nombre);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    dtBancos = new DataTable();
                    dgvBancos.AllowUserToDeleteRows = true;
                    dgvBancos.DataError += dgvBancos_DataError;
                    adapter.Fill(dtBancos);

                    dgvBancos.DataSource = dtBancos;

                    if (dgvBancos.Columns.Contains("Banco_ID"))
                    {
                        dgvBancos.Columns["Banco_ID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Bancos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            CargarBancos(txtBuscar.Text.Trim());
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow row in dtBancos.Rows)
                {
                    if (row.RowState == DataRowState.Added || row.RowState == DataRowState.Modified)
                    {
                        if (string.IsNullOrWhiteSpace(row["Nombre"]?.ToString()))
                        {
                            MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (string.IsNullOrWhiteSpace(row["Beneficiario"]?.ToString()))
                        {
                            MessageBox.Show("El beneficiario es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (row["NumeroCuenta"] == DBNull.Value || Convert.ToInt32(row["NumeroCuenta"]) <= 0)
                        {
                            MessageBox.Show("El número de cuenta debe ser mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                // Guardar los cambios en la base de datos
                int registrosAfectados = adpBanco.Update(dtBancos);

                // Recargar los datos para reflejar los cambios
                dtBancos.Clear();
                adpBanco.Fill(dtBancos);

                MessageBox.Show($"Se guardaron {registrosAfectados} cambios correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvBancos.CurrentRow != null && !dgvBancos.CurrentRow.IsNewRow)
            {
                if (MessageBox.Show("¿Estás seguro que deseas eliminar este registro?", "Confirmar eliminación",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        dtBancos.Rows[dgvBancos.CurrentRow.Index].Delete();

                        int registrosAfectados = adpBanco.Update(dtBancos);

                        if (registrosAfectados > 0)
                        {
                            dtBancos.Clear();
                            adpBanco.Fill(dtBancos);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dtBancos.RejectChanges();
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay una fila seleccionada válida para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgvBancos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error al procesar los datos: " + e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ThrowException = false;
        }
    }
}
