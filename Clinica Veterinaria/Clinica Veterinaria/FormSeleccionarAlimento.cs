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
    public partial class FormSeleccionarAlimento : Form
    {
        SqlConnection cnx;
        FormAgHospedaje formAgHospedaje;
        public FormSeleccionarAlimento(SqlConnection cnx, FormAgHospedaje formAgHospedaje)
        {
            this.cnx = cnx;
            InitializeComponent();
            this.formAgHospedaje = formAgHospedaje;
            CargarAlimetos();
        }
        public void CargarAlimetos()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerAlimentos", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvAlimento.DataSource = dt;

                    dgvAlimento.Columns["Producto_id"].HeaderText = "ID";
                    dgvAlimento.Columns["Nombre"].HeaderText = "Nombre";
                    dgvAlimento.Columns["Costo"].HeaderText = "Costo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las habitaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvAlimento.CurrentRow != null)
            {
                int AlimentoID = Convert.ToInt32(dgvAlimento.CurrentRow.Cells["Producto_id"].Value);
                formAgHospedaje.AlimentoId = AlimentoID;
                String AlimentoNombre= dgvAlimento.CurrentRow.Cells["Nombre"].Value.ToString();
                formAgHospedaje.txtAlimentoSetText(AlimentoNombre);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una mascota.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
