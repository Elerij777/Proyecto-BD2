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
    public partial class FormHistorial : Form
    {
        private SqlConnection cnx;
        private SqlDataAdapter adpHistorial;
        private DataTable tabHistorial;

        public FormHistorial(SqlConnection conexion)
        {
            InitializeComponent();
            cnx = conexion;
        }
        private void CargarHistorial()
        {
            string consulta = "SELECT * FROM vHistorial Where 1 =1";

            if (!string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                consulta += " AND (Dueño LIKE @filtro OR Mascota LIKE @filtro)";
            }

            List<string> servicios = new List<string>();
            if (chkClinica.Checked) servicios.Add("'Clínica'");
            if (chkGrooming.Checked) {
                servicios.Add("'Grooming Clasico'");
                servicios.Add("'Grooming Completo'");
            }
            if (chkHospedaje.Checked) servicios.Add("'Hospedaje'");

            if (servicios.Count > 0)
            {
                string filtroServicios = string.Join(",", servicios);
                consulta += $" AND Servicio IN ({filtroServicios})";
            }

            try
            {
                adpHistorial = new SqlDataAdapter(consulta, cnx);

                if (!string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    adpHistorial.SelectCommand.Parameters.AddWithValue("@filtro", "%" + txtBuscar.Text + "%");
                }

                tabHistorial = new DataTable();
                adpHistorial.Fill(tabHistorial);
                dataGridView1.DataSource = tabHistorial;
                dataGridView1.Columns["Especie"].Width = 90;
                dataGridView1.Columns["Servicio"].Width = 90;
                dataGridView1.Columns["Tratamiento"].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void chkClinica_CheckedChanged(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void chkGrooming_CheckedChanged(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void chkHospedaje_CheckedChanged(object sender, EventArgs e)
        {
            CargarHistorial();
        }
    }
}
