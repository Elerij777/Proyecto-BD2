using System;
using System.Collections;
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
    public partial class FormArqueo : Form
    {
        decimal totalDelDia = 0;
        decimal totalEfectivo = 0;
        decimal totalCheque = 0;
        decimal totalTarjeta = 0;
        decimal diaAnterior = 0;

        SqlConnection cnx;
        public FormArqueo(SqlConnection cnx)
        {
            
            this.cnx = cnx;
            InitializeComponent();
            ObtenerArqueoDeHoy();
            txtCajaEfectivo.Text = "0.00";
            txtCajaCheques.Text = "0.00";
            txtCajaTarjeta.Text = "0.00";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtEfectivo.Text.Trim()) != Convert.ToDecimal(txtCajaEfectivo.Text.Trim()))
            {
                MessageBox.Show("El efectivo en caja no coincide con las facturas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToDecimal(txtCheques.Text.Trim()) != Convert.ToDecimal(txtCajaCheques.Text.Trim()))
            {
                MessageBox.Show("Los Cheques en caja no coinciden con las facturas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToDecimal(txtTarjeta.Text.Trim()) != Convert.ToDecimal(txtCajaTarjeta.Text.Trim()))
            {
                MessageBox.Show("Los pagos en tarjeta no coinciden con las facturas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Al guardar, no podrá seguir facturando el día de hoy.\n\n¿Desea continuar?",
                "Advertencia final",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            decimal deposito = 0;
            try
            {
                deposito = Convert.ToDecimal(txtDeposito.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Por favor, solo ingrese números en el depósito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                decimal montoCaja = Convert.ToDecimal(txtcajaTotal.Text.Trim());
                string observaciones = "Deposito de caja del día " + DateTime.Now.ToString("dd/MM/yyyy");

                using (SqlCommand cmd = new SqlCommand("sp_RegistrarArqueo", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MontoCaja", montoCaja);
                    cmd.Parameters.AddWithValue("@MontoDeposito", deposito);
                    cmd.Parameters.AddWithValue("@Observaciones", observaciones ?? "");

                    if (cnx.State == ConnectionState.Closed)
                        cnx.Open();
                    cmd.ExecuteNonQuery();
                    cnx.Close();

                    MessageBox.Show("Arqueo registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el arqueo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Estado de conexión antes de abrir: " + cnx.State);

            }
        }


        public void ObtenerArqueoDeHoy()
        {
            cnx.Open();

            string query = @"
                SELECT *
                FROM vw_ArqueoDiario
                WHERE Fecha = CAST(GETDATE() AS DATE);
            ";

            using (cnx)
            {
                SqlCommand command = new SqlCommand(query, cnx);
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        totalDelDia = reader.GetDecimal(reader.GetOrdinal("TotalDelDia"));
                        totalEfectivo = reader.GetDecimal(reader.GetOrdinal("TotalEfectivo"));
                        totalCheque = reader.GetDecimal(reader.GetOrdinal("TotalCheque"));
                        totalTarjeta = reader.GetDecimal(reader.GetOrdinal("TotalTarjeta"));
                        if (reader.GetDecimal(reader.GetOrdinal("CajaDiaAnterior")) != null)
                        {
                            diaAnterior = reader.GetDecimal(reader.GetOrdinal("CajaDiaAnterior"));
                        }

                    }

                    cnx.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener el arqueo: " + ex.Message);
                    cnx.Close();
                }
            }
            txtCajaAnterior.Text = diaAnterior.ToString("F2");
            txtCheques.Text = totalCheque.ToString("F2");
            txtTarjeta.Text = totalTarjeta.ToString("F2");
            txtEfectivo.Text = totalEfectivo.ToString("F2");
            txtCheques.Text = totalCheque.ToString("F2");
            txtTotal.Text = totalDelDia.ToString("F2");
        }

        private void txtCajaEfectivo_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalCaja();
        }

        private void txtCajaCheques_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalCaja();
        }

        private void txtCajaTarjeta_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalCaja();
        }
        private void CalcularTotalCaja()
        {
            decimal efectivo, cheques, tarjeta;

            if (!decimal.TryParse(txtCajaEfectivo.Text.Trim(), out efectivo) && txtCajaEfectivo.Text.Trim().ToString()!="" )
            {
                MessageBox.Show("Por favor, ingrese un número válido en Caja Efectivo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtCajaCheques.Text.Trim(), out cheques) && txtCajaCheques.Text.Trim().ToString() != "")
            {
                MessageBox.Show("Por favor, ingrese un número válido en Caja Cheques.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtCajaTarjeta.Text.Trim(), out tarjeta) && txtCajaTarjeta.Text.Trim().ToString() != "")
            {
                MessageBox.Show("Por favor, ingrese un número válido en Caja Tarjeta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (efectivo < 0 || cheques < 0 || tarjeta < 0)
            {
                MessageBox.Show("Por favor, no ingrese números negativos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = efectivo + cheques + tarjeta;
            txtcajaTotal.Text = total.ToString("F2");
        }



        private void FormArqueo_Load(object sender, EventArgs e)
        {

        }
    }
}
