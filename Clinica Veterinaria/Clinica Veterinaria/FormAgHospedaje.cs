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
    public partial class FormAgHospedaje : Form
    {
        SqlConnection cnx;
        public int MascotaId = 0;
        public int HabitacionId = 0;
        public string especieMascota = "";
        public string especieHabitacion = "";
        public FormAgHospedaje(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnElegirHabitacion_Click(object sender, EventArgs e)
        {
            FormSeleccionarHabitacion formSeleccionarHabitacion = new FormSeleccionarHabitacion(cnx,this);
            formSeleccionarHabitacion.Visible = true;
        }

        private void BtnElegirMascota_Click(object sender, EventArgs e)
        {
            FormSeleccionarMascota formSeleccionarMascota = new FormSeleccionarMascota(cnx,this);
            formSeleccionarMascota.Visible = true;
        }
        public void txtMascotaSetText(string text)
        {
            txtMascota.Text = text;
        }
        public void txtHabitacionSetText(string text)
        {
            txtHabitacion.Text = text;
        }
    }
}
