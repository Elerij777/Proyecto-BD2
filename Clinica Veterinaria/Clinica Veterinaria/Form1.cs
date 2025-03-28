namespace Clinica_Veterinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            esconderPaneles();
            formPrincipal formulario = new formPrincipal();
            abrirFormulario(formulario);
            this.Text = "Clinica Veterinaria";



        }

        void esconderPaneles()
        {
            panelClientes.Visible = false;
            panelHumanos.Visible = false;
            panelInventario.Visible = false;
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
            desplegarPanel(panelInventario);
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {
            FormAgMascotas formAgClientes = new FormAgMascotas();
            abrirFormulario(formAgClientes);
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            FormVerMascotas formVerMascotas = new FormVerMascotas();
            abrirFormulario(formVerMascotas);
        }

        private void btnVerHumanos_Click(object sender, EventArgs e)
        {
            FormVerHumanos formVerHumanos = new FormVerHumanos();
            abrirFormulario(formVerHumanos);
        }

        private void btnAgregarHumano_Click(object sender, EventArgs e)
        {
            FormAgHumanos formAgHumanos = new FormAgHumanos();
            abrirFormulario(formAgHumanos);
        }

        private void btnAgregarInventario_Click(object sender, EventArgs e)
        {
            FormAgProducto formAgProducto = new FormAgProducto();
            abrirFormulario(formAgProducto);
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            FormVerProducto formVerProducto = new FormVerProducto();
            abrirFormulario(formVerProducto);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
