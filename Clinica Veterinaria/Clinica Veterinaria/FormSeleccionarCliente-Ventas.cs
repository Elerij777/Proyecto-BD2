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
    public partial class FormSeleccionarCliente_Ventas : Form
    {   
        FormVentas formVentas;
        SqlConnection cnx;
        public FormSeleccionarCliente_Ventas(FormVentas formVentas,SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
            this.formVentas = formVentas;
            CargarHumanos();
        }
        public void CargarHumanos()
        {

        }
        private void BtnAcceptar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow != null)
            {
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
