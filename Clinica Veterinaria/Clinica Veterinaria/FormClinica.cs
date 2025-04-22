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
        public int MascotaId = 0;
        public int EmpleadoId = 0;

        public FormClinica(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MascotaId == 0)
                {
                    MessageBox.Show("Seleccione una mascota.");
                    return;
                }

                if (EmpleadoId == 0)
                {
                    MessageBox.Show("Seleccione un empleado.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbDescripcion.Text) ||
                    string.IsNullOrWhiteSpace(tbDiagnostico.Text) ||
                    string.IsNullOrWhiteSpace(tbTratamiento.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlCommand cmd = new SqlCommand("SpInsertarCitaClinica", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Mascota_id", MascotaId);
                cmd.Parameters.AddWithValue("@Descripcion", tbDescripcion.Text);
                cmd.Parameters.AddWithValue("@Fecha", dtpCita.Value);
                cmd.Parameters.AddWithValue("@Diagnostico", tbDiagnostico.Text);
                cmd.Parameters.AddWithValue("@Tratamiento", tbTratamiento.Text);
                cmd.Parameters.AddWithValue("@EmpleadoID", EmpleadoId);
                cmd.Parameters.AddWithValue("@Servicio_id", TIPO_SERVICIO_CLINICA);

                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();

                LimpiarFormulario();
            }
            catch (SqlException ex)
            {
                cnx.Close();
                MessageBox.Show($"Error al registrar la cita: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            tbDescripcion.Clear();
            tbDiagnostico.Clear();
            tbTratamiento.Clear();
            txtMascota.Clear();
            txtEmpleado.Clear();
            MascotaId = 0;
            EmpleadoId = 0;
            dtpCita.Value = DateTime.Now;
        }

        private void btn_AgregarMascota_Click(object sender, EventArgs e)
        {
            FormSeleccionarMascota formSeleccionarMascota = new FormSeleccionarMascota(cnx, this);
            formSeleccionarMascota.ShowDialog();
        }

        public void txtMascotaSetText(string text)
        {
            txtMascota.Text = text;
        }

        public void txtEmpleadoSetText(string text)
        {
            txtEmpleado.Text = text;
        }

        private void btn_Empleado_Click(object sender, EventArgs e)
        {
            FormSeleccionarEmpleado formSeleccionarEmpleado = new FormSeleccionarEmpleado(cnx, this);
            formSeleccionarEmpleado.ShowDialog();
        }
    }
}