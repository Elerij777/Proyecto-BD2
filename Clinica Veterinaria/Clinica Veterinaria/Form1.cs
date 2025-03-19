namespace Clinica_Veterinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            esconderPaneles();
            formImagen formulario = new formImagen();
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
    }
}
