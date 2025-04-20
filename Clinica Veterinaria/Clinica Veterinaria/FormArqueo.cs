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
    public partial class FormArqueo : Form
    {
        decimal totalDelDia = 0;
        decimal totalEfectivo = 0;
        decimal totalCheque = 0;
        decimal totalTarjeta = 0;
        SqlConnection cnx;
        public FormArqueo(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

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
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener el arqueo: " + ex.Message);
                }
            }
            txtCheques.Text = totalCheque.ToString();
            txtTarjeta.Text = totalTarjeta.ToString();
            txtEfectivo.Text = totalEfectivo.ToString();
            txtCheques.Text = totalCheque.ToString();
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
            
            try
            {
                if (Convert.ToDecimal(txtCajaEfectivo.ToString()) <= 0 ||
                Convert.ToDecimal(txtCajaCheques.ToString()) <= 0 ||
                Convert.ToDecimal(txtCajaTarjeta.ToString()) <= 0 )
                {
                    MessageBox.Show("Por favor, solo ingrese numeros mayores a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                decimal total = Convert.ToDecimal(txtCajaEfectivo.ToString()) +
                Convert.ToDecimal(txtCajaCheques.ToString()) +
                Convert.ToDecimal(txtCajaTarjeta.ToString());
                txtcajaTotal.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, solo ingrese numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
            
        }
    }
