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
    public partial class FormEmpleados : Form
    {
        SqlConnection cnx;
        SqlDataAdapter adpEmpleados;
        DataTable tabEmpleados;
        public FormEmpleados(SqlConnection conexion)
        {
            InitializeComponent();
            cnx = conexion;
            ConfigurarDataAdapter();
        }
        private void ConfigurarDataAdapter()
        {
            adpEmpleados = new SqlDataAdapter();

            adpEmpleados.SelectCommand = new SqlCommand("spListarEmpleados", cnx);
            adpEmpleados.SelectCommand.CommandType = CommandType.StoredProcedure;

            adpEmpleados.InsertCommand = new SqlCommand("spInsertarEmpleado", cnx);
            adpEmpleados.InsertCommand.CommandType = CommandType.StoredProcedure;
            adpEmpleados.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 100, "Nombre");
            adpEmpleados.InsertCommand.Parameters.Add("@Rol", SqlDbType.VarChar, 50, "Rol");
            adpEmpleados.InsertCommand.Parameters.Add("@Telefono", SqlDbType.VarChar, 20, "Telefono");
            adpEmpleados.InsertCommand.Parameters.Add("@Genero", SqlDbType.Char, 1, "Genero");
            adpEmpleados.InsertCommand.Parameters.Add("@EstadoCivil", SqlDbType.Char, 1, "Estado_Civil");
            adpEmpleados.InsertCommand.Parameters.Add("@Direccion", SqlDbType.VarChar, 200, "Direccion");

            adpEmpleados.UpdateCommand = new SqlCommand("spActualizarEmpleado", cnx);
            adpEmpleados.UpdateCommand.CommandType = CommandType.StoredProcedure;
            adpEmpleados.UpdateCommand.Parameters.Add("@Empleado_id", SqlDbType.Int, 4, "Empleado_id");
            adpEmpleados.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 100, "Nombre");
            adpEmpleados.UpdateCommand.Parameters.Add("@Rol", SqlDbType.VarChar, 50, "Rol");
            adpEmpleados.UpdateCommand.Parameters.Add("@Telefono", SqlDbType.VarChar, 20, "Telefono");
            adpEmpleados.UpdateCommand.Parameters.Add("@Genero", SqlDbType.Char, 1, "Genero");
            adpEmpleados.UpdateCommand.Parameters.Add("@EstadoCivil", SqlDbType.Char, 1, "Estado_Civil");
            adpEmpleados.UpdateCommand.Parameters.Add("@Direccion", SqlDbType.VarChar, 200, "Direccion");

            adpEmpleados.DeleteCommand = new SqlCommand("spEliminarEmpleado", cnx);
            adpEmpleados.DeleteCommand.CommandType = CommandType.StoredProcedure;
            adpEmpleados.DeleteCommand.Parameters.Add("@Empleado_id", SqlDbType.Int, 4, "Empleado_id");
        }
        private void CargarDatos()
        {
            tabEmpleados = new DataTable();
            adpEmpleados.Fill(tabEmpleados);
            dgvEmpleados.DataSource = tabEmpleados;
            dgvEmpleados.Columns["Empleado_id"].Visible = false;

        }

        private void ConfigurarDataGridView()
        {
            {
                dgvEmpleados.AutoGenerateColumns = true;

                if (dgvEmpleados.Columns["GeneroCombo"] != null)
                    dgvEmpleados.Columns.Remove("GeneroCombo");

                DataTable tabGenero = new DataTable();
                tabGenero.Columns.Add("Codigo");
                tabGenero.Columns.Add("Descripcion");
                tabGenero.Rows.Add("M", "Masculino");
                tabGenero.Rows.Add("F", "Femenino");

                DataGridViewComboBoxColumn colGenero = new DataGridViewComboBoxColumn
                {
                    Name = "GeneroCombo",
                    HeaderText = "Género",
                    DataSource = tabGenero,
                    DisplayMember = "Descripcion",
                    ValueMember = "Codigo",
                    DataPropertyName = "Genero",
                    DisplayStyleForCurrentCellOnly = true
                };

                dgvEmpleados.Columns.Add(colGenero);
                dgvEmpleados.Columns["Genero"].Visible = false;
                dgvEmpleados.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

                dgvEmpleados.DataError += (s, e) =>
                {
                    e.ThrowException = false;
                };
            }
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            CargarDatos();
            ConfigurarDataGridView();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow row in tabEmpleados.Rows)
                {
                    if (row.RowState == DataRowState.Added || row.RowState == DataRowState.Modified)
                    {
                        if (string.IsNullOrWhiteSpace(row["Nombre"]?.ToString()))
                        {
                            MessageBox.Show("El nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                cnx.Open();
                int cambios = adpEmpleados.Update(tabEmpleados);
                MessageBox.Show($"Se guardaron {cambios} cambios correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
        private void CargarEmpleados(string nombre)
        {
            try
            {
                cnx.Open();
                using (SqlCommand cmd = new SqlCommand("spBuscarEmpleadosPorNombre", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", nombre);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    tabEmpleados = new DataTable();
                    adapter.Fill(tabEmpleados);

                    dgvEmpleados.DataSource = tabEmpleados;

                    if (dgvEmpleados.Columns.Contains("Empleado_id"))
                    {
                        dgvEmpleados.Columns["Empleado_id"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            CargarEmpleados(txtBuscador.Text.Trim());
        }
    }
}
