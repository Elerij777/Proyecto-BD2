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
    public partial class FormSeleccionarHabitacion : Form
    {
        SqlConnection cnx;
        FormAgHospedaje formAgHospedaje;
        public FormSeleccionarHabitacion(SqlConnection cnx, FormAgHospedaje formAgHospedaje)
        {
            InitializeComponent();
            this.cnx = cnx;

            CargarHabitaciones();
            this.formAgHospedaje = formAgHospedaje;
        }
        private void CargarHabitaciones()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SpLeerHabitacion", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvHabitaciones.DataSource = dt;

                    dgvHabitaciones.Columns["Habitacion_id"].HeaderText = "ID";
                    dgvHabitaciones.Columns["Capacidad"].HeaderText = "Capacidad";
                    dgvHabitaciones.Columns["Estado"].HeaderText = "Estado";
                    dgvHabitaciones.Columns["Precio"].HeaderText = "Precio";
                    dgvHabitaciones.Columns["Animal"].HeaderText = "Animal";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las habitaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvHabitaciones.CurrentRow != null)
            {
                int idHabitacion = Convert.ToInt32(dgvHabitaciones.CurrentRow.Cells["Habitacion_id"].Value);

                string EspecieHabitacion = dgvHabitaciones.CurrentRow.Cells["Animal"].Value.ToString();
                formAgHospedaje.txtHabitacionSetText(idHabitacion.ToString());



                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una mascota.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    
}
