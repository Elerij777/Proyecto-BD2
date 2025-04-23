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
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Clinica_Veterinaria
{
    public partial class FormVehiculo : Form
    {
        SqlConnection cnx;
        public int idVehiculo;
        public int idcliente;
        public FormVehiculo(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
             AgregarTransporte();

        }
        public void setTextMatricula(string matricula)
        {
            txtVehiculoId.Text = matricula;
        }
        private void BtnElegirHabitacion_Click(object sender, EventArgs e)
        {
            FormSeleccionarVehiculosTransporte form = new FormSeleccionarVehiculosTransporte(cnx, this);
            form.Visible = true;
        }
        public void SetClienteSeleccionado(int id, string nombre)
        {
            idcliente = id;
            txtCliente.Text = nombre;
        }
        private void AgregarTransporte()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtVehiculoId.Text) ||
                    string.IsNullOrWhiteSpace(txtCosto.Text))
                {
                    MessageBox.Show("Debe completar todos los campos obligatorios.");
                    return;
                }


                decimal costo = decimal.Parse(txtCosto.Text);
                string detalles = txtDetalles.Text;

                SqlCommand cmd = new SqlCommand("sp_ActivarTransporte", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ClienteId", idcliente);
                cmd.Parameters.AddWithValue("@VehiculoId", idVehiculo);
                cmd.Parameters.AddWithValue("@Costo", costo);
                cmd.Parameters.AddWithValue("@Detalles", detalles);

                if (cnx.State != ConnectionState.Open)
                    cnx.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int resultado = Convert.ToInt32(reader["Resultado"]);
                    string mensaje = reader["Mensaje"].ToString();

                    MessageBox.Show(mensaje);

                    if (resultado == 1)
                    {
                        this.Close(); // o limpiar campos, o ir a otra vista
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSeleccionarClienteVehiculo form = new FormSeleccionarClienteVehiculo(cnx, this);
            form.Visible= true;
        }
    }
}
