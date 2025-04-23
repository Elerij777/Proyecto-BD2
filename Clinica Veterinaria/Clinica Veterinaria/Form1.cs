using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Image;
using System.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;

namespace Clinica_Veterinaria
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );



        SqlConnection cnx;
        public int MascotaId = 0;
        public int HabitacionId = 0;
        public Form1()
        {
            InitializeComponent();

            esconderPaneles();

            formPrincipal formulario = new formPrincipal();
            abrirFormulario(formulario);
            this.Text = "Clinica Veterinaria";
            try
            {
                String url = "Server=3.128.144.165,1433;Database=DB20212021280;User Id=erick.turcios;Password=ET20212021280;TrustServerCertificate=True;";
                cnx = new SqlConnection(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar la base de datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        void esconderPaneles()
        {
            panelClientes.Visible = false;
            panelHumanos.Visible = false;
            panelInventario.Visible = false;
            panelCitas.Visible = false;
            panel_Adm.Visible = false;
        }
        void desplegarPanel(Panel panel)
        {
            if (panel.Visible)
            {
                panel.Visible = false;
            }
            else
            {
                esconderPaneles();
                panel.Visible = true;
            }
        }
        private void btnHumanos_Click(object sender, EventArgs e)
        {

            btnHumanos.BackColor = Color.FromArgb(217, 237, 255);
            desplegarPanel(panel: panelHumanos);

        }
        void abrirFormulario(Form form)
        {
            panelPrincipal.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelPrincipal.Controls.Add(form);
            panelPrincipal.Tag = form;
            form.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            desplegarPanel(panel: panelClientes);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {

            btnInventario.BackColor = Color.FromArgb(217, 237, 255);
            desplegarPanel(panelInventario);
        }

        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {
            FormAgMascotas formAgClientes = new FormAgMascotas(cnx);
            abrirFormulario(formAgClientes);
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            FormVerMascotas formVerMascotas = new FormVerMascotas(cnx);
            abrirFormulario(formVerMascotas);
        }

        private void btnVerHumanos_Click(object sender, EventArgs e)
        {
            FormVerHumanos formVerHumanos = new FormVerHumanos(cnx);
            abrirFormulario(formVerHumanos);
        }

        private void btnAgregarHumano_Click(object sender, EventArgs e)
        {
            FormAgHumanos formAgHumanos = new FormAgHumanos(cnx);
            abrirFormulario(formAgHumanos);
        }

        private void btnAgregarInventario_Click(object sender, EventArgs e)
        {
            FormAgProducto formAgProducto = new FormAgProducto(cnx);
            abrirFormulario(formAgProducto);
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            FormVerProducto formVerProducto = new FormVerProducto(cnx);
            abrirFormulario(formVerProducto);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormEasterEgg formEasterEgg = new FormEasterEgg();
            abrirFormulario(formEasterEgg);
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            btnCitas.BackColor = Color.FromArgb(217, 237, 255);
            desplegarPanel(panel: panelCitas);
        }

        private void btnClinica_Click(object sender, EventArgs e)
        {
            FormClinica formClinica = new FormClinica(cnx);
            abrirFormulario(formClinica);
        }

        private void btn_Administracion_Click(object sender, EventArgs e)
        {
            btn_Administracion.BackColor = Color.FromArgb(217, 237, 255);
            desplegarPanel(panel_Adm);
        }

        private void btnHospedaje_Click(object sender, EventArgs e)
        {
            FormHospedaje formHospedaje = new FormHospedaje(cnx);
            abrirFormulario(formHospedaje);
        }

        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            FormEmpleados formEmpleados = new FormEmpleados(cnx);
            abrirFormulario(formEmpleados);

        }

        private void BtnAgregarHospedaje_Click(object sender, EventArgs e)
        {
            FormAgHospedaje form = new FormAgHospedaje(cnx);
            abrirFormulario(form);
        }

        private void btnClientes_Leave(object sender, EventArgs e)
        {

        }

        private void btnHumanos_Leave(object sender, EventArgs e)
        {
            btnHumanos.BackColor = Color.FromArgb(207, 226, 243);
        }

        private void btnInventario_Leave(object sender, EventArgs e)
        {
            btnInventario.BackColor = Color.FromArgb(207, 226, 243);
        }

        private void btnCitas_Leave(object sender, EventArgs e)
        {
            btnCitas.BackColor = Color.FromArgb(207, 226, 243);
        }

        private void btn_Administracion_Leave(object sender, EventArgs e)
        {
            btn_Administracion.BackColor = Color.FromArgb(207, 226, 243);
        }

        private void btn_Historial_Click(object sender, EventArgs e)
        {
            FormHistorial formHistorial = new FormHistorial(cnx);
            abrirFormulario(formHistorial);
        }

        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            FormProveedores formProveedores = new FormProveedores(cnx);
            abrirFormulario(formProveedores);
        }

        private void btn_bancos_Click(object sender, EventArgs e)
        {
            FormBanco formBanco = new FormBanco(cnx);
            abrirFormulario(formBanco);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormVentas formVentas = new FormVentas(cnx);
            abrirFormulario(formVentas);
        }

        private void btn_Grooming_Click(object sender, EventArgs e)
        {
            FormGrooming formGrooming = new FormGrooming(cnx);
            abrirFormulario(formGrooming);
        }

        private void btn_Compras_Click(object sender, EventArgs e)
        {
            FormCompras formCompras = new FormCompras(cnx);
            abrirFormulario(formCompras);
        }

        private void btn_agregarUsuario_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister(cnx);
            abrirFormulario(formRegister);
        }

        private void btnArqueo_Click(object sender, EventArgs e)
        {
            FormArqueo formArqueo = new FormArqueo(cnx);
            abrirFormulario(formArqueo);
        }

        private void btn_servicios_Click(object sender, EventArgs e)
        {
            FormServicios formServicios = new FormServicios(cnx);
            abrirFormulario(formServicios);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAgregarVehiculo formAgregarVehiculo = new FormAgregarVehiculo(cnx);
            abrirFormulario(formAgregarVehiculo);
        }
    }
}
