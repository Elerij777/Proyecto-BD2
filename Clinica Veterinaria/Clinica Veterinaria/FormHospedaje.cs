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
    public partial class FormHospedaje : Form
    {
        SqlConnection cnx;
        public FormHospedaje(SqlConnection cnx)
        {
            this.cnx = cnx;
            InitializeComponent();
            CargarHospedajesHoy();
        }
        public void CargarHospedajesHoy()
        {

            try
            {
                string query = "SELECT * FROM fn_HospedajesHoy()";

                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {
                    cnx.Open();

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    dgvHospedaje.DataSource = dt;

                    if (dgvHospedaje.Columns.Contains("Hospedaje_id"))
                        dgvHospedaje.Columns["Hospedaje_id"].Visible = false;

                    if (dgvHospedaje.Columns.Contains("Mascota_id"))
                        dgvHospedaje.Columns["Mascota_id"].Visible = false;
                    if (dgvHospedaje.Columns.Contains("Habitacion_id"))
                        dgvHospedaje.Columns["Habitacion_id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los hospedajes: " + ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvHospedaje.CurrentRow == null)
            {
                MessageBox.Show("Por favor seleccione un hospedaje");
                return;
            }

            DataGridViewRow row = dgvHospedaje.CurrentRow;
            int hospedajeId = Convert.ToInt32(row.Cells["Hospedaje_id"].Value);
            string estado = row.Cells["Estado"].Value.ToString();
            DateTime fechaFin = Convert.ToDateTime(row.Cells["FechaSalida"].Value);

            try
            {
                switch (estado)
                {
                    case "Reserva":
                        using (SqlCommand cmd = new SqlCommand("sp_ActivarReservaHospedaje", cnx))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@HospedajeId", hospedajeId);

                            if (cnx.State == ConnectionState.Closed)
                                cnx.Open();

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Reserva activada correctamente");
                        }
                        break;

                    case "Activo":
                        // Verificar si la fecha de fin es hoy
                        if (fechaFin.Date <= DateTime.Today)
                        {
                            using (SqlCommand cmd = new SqlCommand("sp_FinalizarHospedaje", cnx))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@HospedajeId", hospedajeId);


                                if (cnx.State == ConnectionState.Closed)
                                    cnx.Open();

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Hospedaje finalizado correctamente");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El hospedaje no puede finalizarse aún, no ha llegado la fecha de fin");
                        }
                        break;

                    case "Completado":
                        MessageBox.Show("Este hospedaje ya ha sido completado");
                        break;

                    case "Cancelado":
                        MessageBox.Show("No se puede realizar ninguna acción, el hospedaje fue cancelado");
                        break;

                    default:
                        MessageBox.Show("Estado del hospedaje no reconocido");
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el hospedaje: " + ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
                CargarHospedajesHoy();
            }
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (dgvHospedaje.CurrentRow == null)
            {
                MessageBox.Show("Por favor seleccione un hospedaje");
                return;
            }

            // Obtener datos de la fila seleccionada
            DataGridViewRow row = dgvHospedaje.CurrentRow;
            int hospedajeId = Convert.ToInt32(row.Cells["Hospedaje_id"].Value);
            string estado = row.Cells["Estado"].Value.ToString();
            DateTime fechaFin = Convert.ToDateTime(row.Cells["FechaSalida"].Value);

            try
            {
                if (estado == "Activo")
                {
                    // Verificar si la fecha de salida es hoy
                    if (fechaFin.Date == DateTime.Today)
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_FinalizarHospedaje", cnx))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@HospedajeId", hospedajeId);

                            if (cnx.State == ConnectionState.Closed)
                                cnx.Open();

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Hospedaje finalizado correctamente (marcado como salida hoy).");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La fecha de salida no coincide con la fecha actual.");
                    }
                }
                else
                {
                    MessageBox.Show("Solo se puede marcar salida de hospedajes en estado 'Activo'.");
                }

                CargarHospedajesHoy();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al marcar salida: " + ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
            }
        }

    }
}
