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
using System.Data.SqlClient;

namespace Clinica_Veterinaria
{   
    public partial class FormSeleccionarVehiculosTransporte : Form
    {
        SqlConnection cnx;
        FormVehiculo formVehiculo;
        
        public FormSeleccionarVehiculosTransporte(SqlConnection cnx,FormVehiculo formVehiculo)
        {
            InitializeComponent();
            this.cnx = cnx;
            this.formVehiculo = formVehiculo;
            CargarVehiculos();
        }
        public void CargarVehiculos()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_VerVehiculos", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dtvVehiculos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar vehículos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(dtvVehiculos.CurrentRow != null)
            {
                int id = Convert.ToInt32(dtvVehiculos.CurrentRow.Cells["Vehiculo_id"].Value);
                string Matricula = dtvVehiculos.CurrentRow.Cells["Matricula"].Value.ToString();
                formVehiculo.setTextMatricula(Matricula);
                formVehiculo.idVehiculo = id;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Vehiculo.", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
