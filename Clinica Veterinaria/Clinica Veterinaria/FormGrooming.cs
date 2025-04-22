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
    public partial class FormGrooming : Form
    {
        private SqlConnection cnx;
        public int MascotaId = 0;
        public int EmpleadoId = 0;
        public FormGrooming(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;

        }

        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            FormSeleccionarMascota formSeleccionarMascota = new FormSeleccionarMascota(cnx, this);
            formSeleccionarMascota.ShowDialog();
        }

        private void btn_Empleado_Click(object sender, EventArgs e)
        {
            FormSeleccionarEmpleado formSeleccionarEmpleado = new FormSeleccionarEmpleado(cnx, this);
            formSeleccionarEmpleado.ShowDialog();
        }
        private void LimpiarFormulario()
        {
            txtMascota.Clear();
            txtEmpleado.Clear();
            txtObservaciones.Clear();
            ckb_Corte.Checked = false;
            MascotaId = 0;
            EmpleadoId = 0;
            dtpFecha.Value = DateTime.Now;
        }
        private void btn_guardar_Click(object sender, EventArgs e)
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

                SqlCommand cmd = new SqlCommand("spInsertarCitaGrooming", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mascota_id", MascotaId);
                cmd.Parameters.AddWithValue("@Empleado_id", EmpleadoId);
                cmd.Parameters.AddWithValue("@IncluyeCorte", ckb_Corte.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@Observaciones", txtObservaciones.Text);
                cmd.Parameters.AddWithValue("@Fecha", dtpFecha.Value);

                cnx.Open();
                int citaId = Convert.ToInt32(cmd.ExecuteScalar());

                LimpiarFormulario();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al registrar la cita de grooming: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        private void FormGrooming_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
        }

        public void txtMascotaSetText(string text)
        {
            txtMascota.Text = text;
        }

        public void txtEmpleadoSetText(string text)
        {
            txtEmpleado.Text = text;
        }

        private void txtMascota_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
