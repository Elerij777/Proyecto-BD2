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
            //Limpiamos el panel principal antes de mostrar el form
            panelPrincipal.Controls.Clear();

            //Creamos la instancia del form
            FormAgMascotas formAgClientes = new FormAgMascotas();
            formAgClientes.TopLevel = false;
            formAgClientes.FormBorderStyle = FormBorderStyle.None;
            formAgClientes.Dock = DockStyle.Fill;

            //Lo mandamos al panel principal
            panelPrincipal.Controls.Add(formAgClientes);
            panelPrincipal.Tag = formAgClientes;

            //mostrar el formulario
            formAgClientes.Show();
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            //Limpiamos el panel principal antes de mostrar el form
            panelPrincipal.Controls.Clear();

            //Creamos la instancia del form
            FormVerMascotas formVerMascotas = new FormVerMascotas();
            formVerMascotas.TopLevel = false;
            formVerMascotas.FormBorderStyle = FormBorderStyle.None;
            formVerMascotas.Dock = DockStyle.Fill;

            //Lo mandamos al panel principal
            panelPrincipal.Controls.Add(formVerMascotas);
            panelPrincipal.Tag = formVerMascotas;

            //mostrar el formulario
            formVerMascotas.Show();

        }

        private void btnVerHumanos_Click(object sender, EventArgs e)
        {
            //Limpiamos el panel principal antes de mostrar el form
            panelPrincipal.Controls.Clear();

            //Creamos la instancia del form
            FormVerHumanos formVerHumanos = new FormVerHumanos();
            formVerHumanos.TopLevel = false;
            formVerHumanos.FormBorderStyle = FormBorderStyle.None;
            formVerHumanos.Dock = DockStyle.Fill;

            //Lo mandamos al panel principal
            panelPrincipal.Controls.Add(formVerHumanos);
            panelPrincipal.Tag = formVerHumanos;

            //mostrar el formulario
            formVerHumanos.Show();
        }

        private void btnAgregarHumano_Click(object sender, EventArgs e)
        {
            //Limpiamos el panel principal antes de mostrar el form
            panelPrincipal.Controls.Clear();

            //Creamos la instancia del form
            FormAgHumanos formAgHumanos = new FormAgHumanos();
            formAgHumanos.TopLevel = false;
            formAgHumanos.FormBorderStyle = FormBorderStyle.None;
            formAgHumanos.Dock = DockStyle.Fill;

            //Lo mandamos al panel principal
            panelPrincipal.Controls.Add(formAgHumanos);
            panelPrincipal.Tag = formAgHumanos;

            //mostrar el formulario
            formAgHumanos.Show();

        }

        private void btnAgregarInventario_Click(object sender, EventArgs e)
        {
            // Limpiamos el panel principal antes de mostrar el form
            panelPrincipal.Controls.Clear();

            //Creamos la instancia del form
            FormAgProducto formAgProducto = new FormAgProducto();
            formAgProducto.TopLevel = false;
            formAgProducto.FormBorderStyle = FormBorderStyle.None;
            formAgProducto.Dock = DockStyle.Fill;

            //Lo mandamos al panel principal
            panelPrincipal.Controls.Add(formAgProducto);
            panelPrincipal.Tag = formAgProducto;

            //mostrar el formulario
            formAgProducto.Show();
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            // Limpiamos el panel principal antes de mostrar el form
            panelPrincipal.Controls.Clear();

            //Creamos la instancia del form
            FormVerProducto formVerProducto = new FormVerProducto();
            formVerProducto.TopLevel = false;
            formVerProducto.FormBorderStyle = FormBorderStyle.None;
            formVerProducto.Dock = DockStyle.Fill;

            //Lo mandamos al panel principal
            panelPrincipal.Controls.Add(formVerProducto);
            panelPrincipal.Tag = formVerProducto;

            //mostrar el formulario
            formVerProducto.Show();
        }
    }
}
