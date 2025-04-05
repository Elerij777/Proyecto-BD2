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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinica_Veterinaria
{
    public partial class FormAgHospedaje : Form
    {
        SqlConnection cnx;
        public int MascotaId = 0;
        public FormAgHospedaje(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
            cmbEstado.Items.Add("Reserva");
            cmbEstado.Items.Add("Activo");
            cmbEstado.SelectedItem = "Reserva";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (dateIngreso.Value.Date > dateSalida.Value.Date)
                {
                    MessageBox.Show("La fecha de salida debe ser posterior a la fecha de ingreso.");
                    return;
                }

                if (MascotaId == 0)
                {
                    MessageBox.Show("Seleccione una mascota.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtHabitacion.Text))
                {
                    MessageBox.Show("Seleccione una habitación.");
                    return;
                }


                SqlCommand cmd = new SqlCommand("SpInsertarHospedajeVerificado", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Habitacion_id", Convert.ToInt32(txtHabitacion.Text));
                cmd.Parameters.AddWithValue("@FechaIngreso", dateIngreso.Value.Date);
                cmd.Parameters.AddWithValue("@FechaSalida", dateSalida.Value.Date);
                if (!string.IsNullOrWhiteSpace(txtAlimento.Text))
                {
                    cmd.Parameters.AddWithValue("@Producto_id", Convert.ToInt32(txtAlimento.Text));
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Producto_id", DBNull.Value);
                }

                cmd.Parameters.AddWithValue("@Mascota_id", MascotaId);
                cmd.Parameters.AddWithValue("@Indicaciones", txtIndicaciones.Text);
                cmd.Parameters.AddWithValue("@Estado", cmbEstado.SelectedItem?.ToString() ?? "Reserva");

                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();

                MessageBox.Show("Hospedaje insertado correctamente.");
            }
            catch (SqlException ex)
            {
                cnx.Close();
                MessageBox.Show("Error al insertar hospedaje: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void BtnElegirHabitacion_Click(object sender, EventArgs e)
        {
            FormSeleccionarHabitacion formSeleccionarHabitacion = new FormSeleccionarHabitacion(cnx,this);
            formSeleccionarHabitacion.Visible = true;
        }

        private void BtnElegirMascota_Click(object sender, EventArgs e)
        {
            FormSeleccionarMascota formSeleccionarMascota = new FormSeleccionarMascota(cnx,this);
            formSeleccionarMascota.Visible = true;
        }
        public void txtMascotaSetText(string text)
        {
            txtMascota.Text = text;
        }
        public void txtHabitacionSetText(string text)
        {
            txtHabitacion.Text = text;
        }
    }
}
