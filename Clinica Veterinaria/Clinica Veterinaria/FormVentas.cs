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
    public partial class FormVentas : Form
    {
        SqlConnection cnx;
        public FormVentas(SqlConnection cnx)
        {
            this.cnx = cnx;
            InitializeComponent();
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cbEstado.Items.Add("Pagado");
            cbEstado.Items.Add("Pendiente");
            cbEstado.Items.Add("Cancelado");
            cbMetodoPago.Items.Add("Tarjeta");
            cbMetodoPago.Items.Add("Efectivo");
            cbMetodoPago.Items.Add("Cheque");

        }

        private void BtnElegirCliente_Click(object sender, EventArgs e)
        {
            FormSeleccionarCliente_Ventas formSeleccionarCliente = new FormSeleccionarCliente_Ventas(this,cnx);
            formSeleccionarCliente.Visible = true;
        }
    }
}
