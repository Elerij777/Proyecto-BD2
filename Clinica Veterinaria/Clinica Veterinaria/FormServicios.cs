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
    public partial class FormServicios : Form
    {
        SqlConnection cnx;
        SqlDataAdapter adpServicios;
        DataTable tabServicios;
        public FormServicios(SqlConnection conexion)
        {
            InitializeComponent();
            cnx = conexion;

            if (cnx.State != ConnectionState.Open)
            {
                try
                {
                    cnx.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al abrir la conexión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            ConfigurarDataAdapter();
        }

        private void ConfigurarDataAdapter()
        {
            adpServicios = new SqlDataAdapter();

            adpServicios.SelectCommand = new SqlCommand("spListarServicios", cnx);
            adpServicios.SelectCommand.CommandType = CommandType.StoredProcedure;

            adpServicios.InsertCommand = new SqlCommand("spInsertarServicio", cnx);
            adpServicios.InsertCommand.CommandType = CommandType.StoredProcedure;
            adpServicios.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
            adpServicios.InsertCommand.Parameters.Add("@Precio", SqlDbType.Decimal, 10, "Precio");
            adpServicios.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255, "Descripcion");

            adpServicios.UpdateCommand = new SqlCommand("spActualizarServicio", cnx);
            adpServicios.UpdateCommand.CommandType = CommandType.StoredProcedure;
            adpServicios.UpdateCommand.Parameters.Add("@Servicio_id", SqlDbType.Int, 4, "Servicio_id");
            adpServicios.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
            adpServicios.UpdateCommand.Parameters.Add("@Precio", SqlDbType.Decimal, 10, "Precio");
            adpServicios.UpdateCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255, "Descripcion");

            adpServicios.DeleteCommand = new SqlCommand("spEliminarServicio", cnx);
            adpServicios.DeleteCommand.CommandType = CommandType.StoredProcedure;
            adpServicios.DeleteCommand.Parameters.Add("@Servicio_id", SqlDbType.Int, 4, "Servicio_id");
        }

        private void CargarDatos()
        {
            try
            {
                tabServicios = new DataTable();
                adpServicios.Fill(tabServicios);

                if (tabServicios.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron datos en la tabla Servicios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvServicios.DataSource = tabServicios;
                dgvServicios.Columns["Servicio_id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void configurarDataGridView()
        {
            dgvServicios.AutoGenerateColumns = true;

            // Configuración de estilos alternativos
            dgvServicios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Configuración de errores en el DataGridView
            dgvServicios.DataError += (s, e) =>
            {
                e.ThrowException = false;
            };

            // Configuración de columnas específicas
            if (dgvServicios.Columns["Nombre"] != null)
            {
                dgvServicios.Columns["Nombre"].HeaderText = "Nombre";
                dgvServicios.Columns["Nombre"].Width = 350;
            }

            if (dgvServicios.Columns["Precio"] != null)
            {
                dgvServicios.Columns["Precio"].HeaderText = "Precio";
                dgvServicios.Columns["Precio"].Width = 100;
            }

            if (dgvServicios.Columns["Descripcion"] != null)
            {
                dgvServicios.Columns["Descripcion"].HeaderText = "Descripción";
                dgvServicios.Columns["Descripcion"].Width = 500;
            }

            // Configuración general
            dgvServicios.AllowUserToAddRows = true; // Permitir agregar filas
            dgvServicios.AllowUserToDeleteRows = true; // Permitir eliminar filas
            dgvServicios.ReadOnly = false; // Permitir edición
        }

        private void FormServicios_Load(object sender, EventArgs e)
        {
            CargarDatos();
            configurarDataGridView();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow row in tabServicios.Rows)
                {
                    if (row.RowState == DataRowState.Added || row.RowState == DataRowState.Modified)
                    {
                        if (string.IsNullOrWhiteSpace(row["Nombre"]?.ToString()))
                        {
                            MessageBox.Show("El nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (row["Precio"] == DBNull.Value || Convert.ToDecimal(row["Precio"]) <= 0)
                        {
                            MessageBox.Show("El precio debe ser un valor numérico mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                int cambios = adpServicios.Update(tabServicios);
                MessageBox.Show($"Se guardaron {cambios} cambios correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
