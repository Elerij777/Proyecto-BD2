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
    public partial class FormSeleccionarEmpleado : Form
    {
        SqlConnection cnx;
        private object formOrigen;
        public FormSeleccionarEmpleado(SqlConnection cnx, object formularioOrigen)
        {
            InitializeComponent();
            this.cnx = cnx;
            this.formOrigen = formularioOrigen;
            CargarEmpleado("");
        }

        private void CargarEmpleado(string filtro)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spCargarEmpleados", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@Filtro", string.IsNullOrEmpty(filtro) ? (object)DBNull.Value : filtro);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvEmpleados.DataSource = dt;

                    dgvEmpleados.Columns["Empleado_id"].HeaderText = "ID";
                    dgvEmpleados.Columns["Nombre"].HeaderText = "Nombre";
                    dgvEmpleados.Columns["Rol"].HeaderText = "Rol";
                    dgvEmpleados.Columns["Telefono"].HeaderText = "Telefono";
                    dgvEmpleados.Columns["Genero"].HeaderText = "Género";
                    dgvEmpleados.Columns["Estado_Civil"].HeaderText = "Estado civil";
                    dgvEmpleados.Columns["Direccion"].HeaderText = "Direccion";

                    dgvEmpleados.Columns["Empleado_id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow != null)
            {
                int idEmpleado = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["Empleado_id"].Value);
                string nombreEmpleado = dgvEmpleados.CurrentRow.Cells["Nombre"].Value.ToString();

                if (formOrigen is FormClinica formClinica)
                {
                    formClinica.EmpleadoId = idEmpleado;
                    formClinica.txtEmpleadoSetText(nombreEmpleado);
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Empleado.", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarEmpleado(txtBuscar.Text.Trim());
        }
    }
}
