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
    public partial class FormAgregarVehiculo : Form
    {
        SqlConnection cnx;
        public FormAgregarVehiculo(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if(txtAnio.Text==""|| txtMarca.Text == ""|| txtMatricula.Text == "")
            {
                MessageBox.Show("Rellene todos los campos", "Cuidado");
                return;
            }
            try
            {
                if (cnx.State != ConnectionState.Open)
                {
                    cnx.Open();
                }

                SqlCommand cmd;

                cmd = new SqlCommand("SPInsertVehiculo", cnx);
                cmd.Parameters.AddWithValue("@Matricula", txtMatricula.Text);
                cmd.Parameters.AddWithValue("@Marca", txtMarca.Text);
                cmd.Parameters.AddWithValue("Anio", txtAnio.Text);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Veiculo agregado con exito", "Exito");
                txtAnio.Text = "";
                txtMarca.Text = "";
                txtMatricula.Text = txtAnio.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al insertar Vehicilo: "+e, "Advertencia");
            }
            finally
            {
                cnx.Close();
            }
        }
    }
}
