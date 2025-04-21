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
                {
                    string query = "SELECT * FROM fn_HospedajesHoy()";

                    using (SqlCommand cmd = new SqlCommand(query, cnx))
                    {
                        cnx.Open();

                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);

                        dgvHospedaje.DataSource = dt;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los hospedajes: " + ex.Message);
            }
            finally { cnx.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
