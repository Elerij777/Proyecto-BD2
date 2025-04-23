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
    public partial class FormPagos : Form
    {
        SqlConnection cnx;
        public FormPagos(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
        }
        public void InsertarPagoCompra()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spInsertarPagoCompra", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Asignar parámetros desde los TextBox
                    cmd.Parameters.AddWithValue("@Compra_id", int.Parse(txtCompraId.Text));
                    cmd.Parameters.AddWithValue("@Monto", decimal.Parse(txtMonto.Text));
                    cmd.Parameters.AddWithValue("@Observaciones", txtObservaciones.Text);

                    // Validar si hay datos de depósito
                    if (!string.IsNullOrEmpty(txtBancoId.Text))
                    {
                        cmd.Parameters.AddWithValue("@Banco_id", int.Parse(txtBancoId.Text));
                        cmd.Parameters.AddWithValue("@Descripcion", txtObservaciones.Text);
                        cmd.Parameters.AddWithValue("@FechaDeposito", DateTime.Now);
                    }
                    else
                    {
                        // Si no se insertará depósito, enviar NULLs explícitamente
                        cmd.Parameters.AddWithValue("@Banco_id", DBNull.Value);
                        cmd.Parameters.AddWithValue("@Descripcion", DBNull.Value);
                        cmd.Parameters.AddWithValue("@FechaDeposito", DBNull.Value);
                    }

                    if (cnx.State != ConnectionState.Open)
                        cnx.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() && reader["Resultado"].ToString() == "1")
                        {
                            MessageBox.Show(reader["Mensaje"].ToString(), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(reader["Mensaje"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
            }
        }


        private void BtnElegirCliente_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            InsertarPagoCompra();
        }
    }
}
