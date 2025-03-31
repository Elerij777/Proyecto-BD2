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
    public partial class FormClinica : Form
    {
        private SqlConnection cnx;
        private const int TIPO_SERVICIO_CLINICA = 1; // Valor fijo para servicios clínicos

        public FormClinica(SqlConnection conexion)
        {
            InitializeComponent();
            cnx = conexion;
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            try
            {
                CargarComboBox(cMascota, "SELECT Mascota_id, Nombre FROM Mascotas", "Nombre", "Mascota_id");
                CargarComboBox(cEmpleado, "SELECT Empleado_id, Nombre FROM Empleados", "Nombre", "Empleado_id");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos iniciales: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboBox(ComboBox comboBox, string query, string displayMember, string valueMember)
        {
            var dt = new DataTable();
            using (var da = new SqlDataAdapter(query, cnx))
            {
                da.Fill(dt);
            }

            comboBox.DataSource = dt;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            comboBox.SelectedIndex = -1;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                RegistrarCitaClinica();
                LimpiarFormulario();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la cita: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(tbDescripcion.Text) ||
                cMascota.SelectedIndex == -1 ||
                cEmpleado.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(tbDiagnostico.Text) ||
                string.IsNullOrWhiteSpace(tbTratamiento.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void RegistrarCitaClinica()
        {
            string query = @"INSERT INTO Cita (
                                Mascota_id, Descripcion, Fecha, 
                                Diagnostico, Tratamiento, Empleado_id, Servicio_id
                             ) VALUES (
                                @Mascota_id, @Descripcion, @Fecha, 
                                @Diagnostico, @Tratamiento, @EmpleadoID, @Servicio_id
                             )";

            using (var cmd = new SqlCommand(query, cnx))
            {
                cmd.Parameters.Add("@Mascota_id", SqlDbType.Int).Value = Convert.ToInt32(cMascota.SelectedValue);
                cmd.Parameters.Add("@Descripcion", SqlDbType.Text).Value = tbDescripcion.Text;
                cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = dtpCita.Value;
                cmd.Parameters.Add("@Diagnostico", SqlDbType.Text).Value = tbDiagnostico.Text;
                cmd.Parameters.Add("@Tratamiento", SqlDbType.Text).Value = tbTratamiento.Text;
                cmd.Parameters.Add("@EmpleadoID", SqlDbType.Int).Value = Convert.ToInt32(cEmpleado.SelectedValue);
                cmd.Parameters.Add("@Servicio_id", SqlDbType.Int).Value = TIPO_SERVICIO_CLINICA;

                cnx.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void LimpiarFormulario()
        {
            tbDescripcion.Clear();
            tbDiagnostico.Clear();
            tbTratamiento.Clear();
            cMascota.SelectedIndex = -1;
            cEmpleado.SelectedIndex = -1;
            dtpCita.Value = DateTime.Now;
        }

        private void FormClinica_Load(object sender, EventArgs e)
        {

        }
    }
}