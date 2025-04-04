
namespace Clinica_Veterinaria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button btnClientes;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelLateral = new Panel();
            panel_Adm = new Panel();
            btn_proveedores = new Button();
            btn_bancos = new Button();
            btn_servicios = new Button();
            btn_Compras = new Button();
            btn_Empleados = new Button();
            btn_Administracion = new Button();
            panelCitas = new Panel();
            btnGrooming = new Button();
            btnHospedaje = new Button();
            btnClinica = new Button();
            btnCitas = new Button();
            panelInventario = new Panel();
            btnVerProductos = new Button();
            btnAgregarInventario = new Button();
            btnInventario = new Button();
            panelHumanos = new Panel();
            btnAgregarHumano = new Button();
            btnVerHumanos = new Button();
            btnHumanos = new Button();
            panelClientes = new Panel();
            btnAgregarClientes = new Button();
            btnVerClientes = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelPrincipal = new Panel();
            btnClientes = new Button();
            panelLateral.SuspendLayout();
            panel_Adm.SuspendLayout();
            panelCitas.SuspendLayout();
            panelInventario.SuspendLayout();
            panelHumanos.SuspendLayout();
            panelClientes.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 153);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(207, 29);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "       Mascotas";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // panelLateral
            // 
            panelLateral.AutoScroll = true;
            panelLateral.BackColor = SystemColors.ActiveCaption;
            panelLateral.Controls.Add(panel_Adm);
            panelLateral.Controls.Add(btn_Administracion);
            panelLateral.Controls.Add(panelCitas);
            panelLateral.Controls.Add(btnCitas);
            panelLateral.Controls.Add(panelInventario);
            panelLateral.Controls.Add(btnInventario);
            panelLateral.Controls.Add(panelHumanos);
            panelLateral.Controls.Add(btnHumanos);
            panelLateral.Controls.Add(panelClientes);
            panelLateral.Controls.Add(btnClientes);
            panelLateral.Controls.Add(panelLogo);
            panelLateral.Dock = DockStyle.Left;
            panelLateral.Location = new Point(0, 0);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(228, 698);
            panelLateral.TabIndex = 0;
            // 
            // panel_Adm
            // 
            panel_Adm.BackColor = Color.FromArgb(31, 96, 99);
            panel_Adm.Controls.Add(btn_proveedores);
            panel_Adm.Controls.Add(btn_bancos);
            panel_Adm.Controls.Add(btn_servicios);
            panel_Adm.Controls.Add(btn_Compras);
            panel_Adm.Controls.Add(btn_Empleados);
            panel_Adm.Dock = DockStyle.Top;
            panel_Adm.Location = new Point(0, 587);
            panel_Adm.Margin = new Padding(2, 2, 2, 2);
            panel_Adm.Name = "panel_Adm";
            panel_Adm.Size = new Size(207, 154);
            panel_Adm.TabIndex = 1;
            panel_Adm.Visible = false;
            // 
            // btn_proveedores
            // 
            btn_proveedores.BackColor = Color.FromArgb(31, 96, 99);
            btn_proveedores.Dock = DockStyle.Top;
            btn_proveedores.FlatAppearance.BorderSize = 0;
            btn_proveedores.FlatStyle = FlatStyle.Flat;
            btn_proveedores.Location = new Point(0, 116);
            btn_proveedores.Name = "btn_proveedores";
            btn_proveedores.Padding = new Padding(15, 0, 0, 0);
            btn_proveedores.Size = new Size(207, 29);
            btn_proveedores.TabIndex = 14;
            btn_proveedores.Text = "       Proveedores";
            btn_proveedores.TextAlign = ContentAlignment.MiddleLeft;
            btn_proveedores.UseVisualStyleBackColor = false;
            // 
            // btn_bancos
            // 
            btn_bancos.BackColor = Color.FromArgb(31, 96, 99);
            btn_bancos.Dock = DockStyle.Top;
            btn_bancos.FlatAppearance.BorderSize = 0;
            btn_bancos.FlatStyle = FlatStyle.Flat;
            btn_bancos.Location = new Point(0, 87);
            btn_bancos.Name = "btn_bancos";
            btn_bancos.Padding = new Padding(15, 0, 0, 0);
            btn_bancos.Size = new Size(207, 29);
            btn_bancos.TabIndex = 13;
            btn_bancos.Text = "       Bancos";
            btn_bancos.TextAlign = ContentAlignment.MiddleLeft;
            btn_bancos.UseVisualStyleBackColor = false;
            // 
            // btn_servicios
            // 
            btn_servicios.BackColor = Color.FromArgb(31, 96, 99);
            btn_servicios.Dock = DockStyle.Top;
            btn_servicios.FlatAppearance.BorderSize = 0;
            btn_servicios.FlatStyle = FlatStyle.Flat;
            btn_servicios.Location = new Point(0, 58);
            btn_servicios.Name = "btn_servicios";
            btn_servicios.Padding = new Padding(15, 0, 0, 0);
            btn_servicios.Size = new Size(207, 29);
            btn_servicios.TabIndex = 12;
            btn_servicios.Text = "       Servicios";
            btn_servicios.TextAlign = ContentAlignment.MiddleLeft;
            btn_servicios.UseVisualStyleBackColor = false;
            // 
            // btn_Compras
            // 
            btn_Compras.BackColor = Color.FromArgb(31, 96, 99);
            btn_Compras.Dock = DockStyle.Top;
            btn_Compras.FlatAppearance.BorderSize = 0;
            btn_Compras.FlatStyle = FlatStyle.Flat;
            btn_Compras.Location = new Point(0, 29);
            btn_Compras.Name = "btn_Compras";
            btn_Compras.Padding = new Padding(15, 0, 0, 0);
            btn_Compras.Size = new Size(207, 29);
            btn_Compras.TabIndex = 11;
            btn_Compras.Text = "       Compras";
            btn_Compras.TextAlign = ContentAlignment.MiddleLeft;
            btn_Compras.UseVisualStyleBackColor = false;
            // 
            // btn_Empleados
            // 
            btn_Empleados.BackColor = Color.FromArgb(31, 96, 99);
            btn_Empleados.Dock = DockStyle.Top;
            btn_Empleados.FlatAppearance.BorderSize = 0;
            btn_Empleados.FlatStyle = FlatStyle.Flat;
            btn_Empleados.Location = new Point(0, 0);
            btn_Empleados.Name = "btn_Empleados";
            btn_Empleados.Padding = new Padding(15, 0, 0, 0);
            btn_Empleados.Size = new Size(207, 29);
            btn_Empleados.TabIndex = 10;
            btn_Empleados.Text = "       Empleados";
            btn_Empleados.TextAlign = ContentAlignment.MiddleLeft;
            btn_Empleados.UseVisualStyleBackColor = false;
            btn_Empleados.Click += btn_Empleados_Click;
            // 
            // btn_Administracion
            // 
            btn_Administracion.Dock = DockStyle.Top;
            btn_Administracion.FlatAppearance.BorderSize = 0;
            btn_Administracion.FlatStyle = FlatStyle.Flat;
            btn_Administracion.Image = Properties.Resources._992871;
            btn_Administracion.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Administracion.Location = new Point(0, 558);
            btn_Administracion.Name = "btn_Administracion";
            btn_Administracion.Size = new Size(207, 29);
            btn_Administracion.TabIndex = 9;
            btn_Administracion.Text = "       Administracion";
            btn_Administracion.TextAlign = ContentAlignment.MiddleLeft;
            btn_Administracion.UseVisualStyleBackColor = true;
            btn_Administracion.Click += btn_Administracion_Click;
            // 
            // panelCitas
            // 
            panelCitas.BackColor = Color.FromArgb(31, 96, 99);
            panelCitas.Controls.Add(btnGrooming);
            panelCitas.Controls.Add(btnHospedaje);
            panelCitas.Controls.Add(btnClinica);
            panelCitas.Dock = DockStyle.Top;
            panelCitas.Location = new Point(0, 463);
            panelCitas.Name = "panelCitas";
            panelCitas.Size = new Size(207, 95);
            panelCitas.TabIndex = 1;
            // 
            // btnGrooming
            // 
            btnGrooming.BackColor = Color.FromArgb(31, 96, 99);
            btnGrooming.Dock = DockStyle.Top;
            btnGrooming.FlatAppearance.BorderSize = 0;
            btnGrooming.FlatStyle = FlatStyle.Flat;
            btnGrooming.ImageAlign = ContentAlignment.MiddleLeft;
            btnGrooming.Location = new Point(0, 58);
            btnGrooming.Name = "btnGrooming";
            btnGrooming.Padding = new Padding(15, 0, 0, 0);
            btnGrooming.Size = new Size(207, 29);
            btnGrooming.TabIndex = 11;
            btnGrooming.Text = "       Grooming";
            btnGrooming.TextAlign = ContentAlignment.MiddleLeft;
            btnGrooming.UseVisualStyleBackColor = false;
            // 
            // btnHospedaje
            // 
            btnHospedaje.BackColor = Color.FromArgb(31, 96, 99);
            btnHospedaje.Dock = DockStyle.Top;
            btnHospedaje.FlatAppearance.BorderSize = 0;
            btnHospedaje.FlatStyle = FlatStyle.Flat;
            btnHospedaje.ImageAlign = ContentAlignment.MiddleLeft;
            btnHospedaje.Location = new Point(0, 29);
            btnHospedaje.Name = "btnHospedaje";
            btnHospedaje.Padding = new Padding(15, 0, 0, 0);
            btnHospedaje.Size = new Size(207, 29);
            btnHospedaje.TabIndex = 10;
            btnHospedaje.Text = "       Hospedaje";
            btnHospedaje.TextAlign = ContentAlignment.MiddleLeft;
            btnHospedaje.UseVisualStyleBackColor = false;
            btnHospedaje.Click += btnHospedaje_Click;
            // 
            // btnClinica
            // 
            btnClinica.BackColor = Color.FromArgb(31, 96, 99);
            btnClinica.Dock = DockStyle.Top;
            btnClinica.FlatAppearance.BorderSize = 0;
            btnClinica.FlatStyle = FlatStyle.Flat;
            btnClinica.ImageAlign = ContentAlignment.MiddleLeft;
            btnClinica.Location = new Point(0, 0);
            btnClinica.Name = "btnClinica";
            btnClinica.Padding = new Padding(15, 0, 0, 0);
            btnClinica.Size = new Size(207, 29);
            btnClinica.TabIndex = 9;
            btnClinica.Text = "       Clinica";
            btnClinica.TextAlign = ContentAlignment.MiddleLeft;
            btnClinica.UseVisualStyleBackColor = false;
            btnClinica.Click += btnClinica_Click;
            // 
            // btnCitas
            // 
            btnCitas.Dock = DockStyle.Top;
            btnCitas.FlatAppearance.BorderSize = 0;
            btnCitas.FlatStyle = FlatStyle.Popup;
            btnCitas.Image = Properties.Resources._7322265;
            btnCitas.ImageAlign = ContentAlignment.MiddleLeft;
            btnCitas.Location = new Point(0, 434);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(207, 29);
            btnCitas.TabIndex = 8;
            btnCitas.Text = "       Citas y servicios";
            btnCitas.TextAlign = ContentAlignment.MiddleLeft;
            btnCitas.UseVisualStyleBackColor = true;
            btnCitas.Click += btnCitas_Click;
            // 
            // panelInventario
            // 
            panelInventario.BackColor = Color.FromArgb(31, 96, 99);
            panelInventario.Controls.Add(btnVerProductos);
            panelInventario.Controls.Add(btnAgregarInventario);
            panelInventario.Dock = DockStyle.Top;
            panelInventario.Location = new Point(0, 365);
            panelInventario.Name = "panelInventario";
            panelInventario.Size = new Size(207, 69);
            panelInventario.TabIndex = 7;
            // 
            // btnVerProductos
            // 
            btnVerProductos.Dock = DockStyle.Top;
            btnVerProductos.FlatAppearance.BorderSize = 0;
            btnVerProductos.FlatStyle = FlatStyle.Flat;
            btnVerProductos.Location = new Point(0, 29);
            btnVerProductos.Name = "btnVerProductos";
            btnVerProductos.Padding = new Padding(40, 0, 0, 0);
            btnVerProductos.Size = new Size(207, 29);
            btnVerProductos.TabIndex = 1;
            btnVerProductos.Text = "Ver Productos";
            btnVerProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnVerProductos.UseVisualStyleBackColor = true;
            btnVerProductos.Click += btnVerProductos_Click;
            // 
            // btnAgregarInventario
            // 
            btnAgregarInventario.Dock = DockStyle.Top;
            btnAgregarInventario.FlatAppearance.BorderSize = 0;
            btnAgregarInventario.FlatStyle = FlatStyle.Flat;
            btnAgregarInventario.Location = new Point(0, 0);
            btnAgregarInventario.Name = "btnAgregarInventario";
            btnAgregarInventario.Padding = new Padding(40, 0, 0, 0);
            btnAgregarInventario.Size = new Size(207, 29);
            btnAgregarInventario.TabIndex = 0;
            btnAgregarInventario.Text = "Agregar Producto";
            btnAgregarInventario.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregarInventario.UseVisualStyleBackColor = true;
            btnAgregarInventario.Click += btnAgregarInventario_Click;
            // 
            // btnInventario
            // 
            btnInventario.Dock = DockStyle.Top;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Image = (Image)resources.GetObject("btnInventario.Image");
            btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventario.Location = new Point(0, 336);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(207, 29);
            btnInventario.TabIndex = 6;
            btnInventario.Text = "       Inventario";
            btnInventario.TextAlign = ContentAlignment.MiddleLeft;
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // panelHumanos
            // 
            panelHumanos.BackColor = Color.FromArgb(31, 96, 99);
            panelHumanos.Controls.Add(btnAgregarHumano);
            panelHumanos.Controls.Add(btnVerHumanos);
            panelHumanos.Dock = DockStyle.Top;
            panelHumanos.Location = new Point(0, 274);
            panelHumanos.Name = "panelHumanos";
            panelHumanos.Size = new Size(207, 62);
            panelHumanos.TabIndex = 5;
            // 
            // btnAgregarHumano
            // 
            btnAgregarHumano.Dock = DockStyle.Top;
            btnAgregarHumano.FlatAppearance.BorderSize = 0;
            btnAgregarHumano.FlatStyle = FlatStyle.Flat;
            btnAgregarHumano.Location = new Point(0, 29);
            btnAgregarHumano.Name = "btnAgregarHumano";
            btnAgregarHumano.Padding = new Padding(40, 0, 0, 0);
            btnAgregarHumano.Size = new Size(207, 29);
            btnAgregarHumano.TabIndex = 1;
            btnAgregarHumano.Text = "Agregar Humanos";
            btnAgregarHumano.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregarHumano.UseVisualStyleBackColor = true;
            btnAgregarHumano.Click += btnAgregarHumano_Click;
            // 
            // btnVerHumanos
            // 
            btnVerHumanos.Dock = DockStyle.Top;
            btnVerHumanos.FlatAppearance.BorderSize = 0;
            btnVerHumanos.FlatStyle = FlatStyle.Flat;
            btnVerHumanos.Location = new Point(0, 0);
            btnVerHumanos.Name = "btnVerHumanos";
            btnVerHumanos.Padding = new Padding(40, 0, 0, 0);
            btnVerHumanos.Size = new Size(207, 29);
            btnVerHumanos.TabIndex = 0;
            btnVerHumanos.Text = "Ver Humanos";
            btnVerHumanos.TextAlign = ContentAlignment.MiddleLeft;
            btnVerHumanos.UseVisualStyleBackColor = true;
            btnVerHumanos.Click += btnVerHumanos_Click;
            // 
            // btnHumanos
            // 
            btnHumanos.Dock = DockStyle.Top;
            btnHumanos.FlatAppearance.BorderSize = 0;
            btnHumanos.FlatStyle = FlatStyle.Flat;
            btnHumanos.Image = (Image)resources.GetObject("btnHumanos.Image");
            btnHumanos.ImageAlign = ContentAlignment.MiddleLeft;
            btnHumanos.Location = new Point(0, 245);
            btnHumanos.Name = "btnHumanos";
            btnHumanos.Size = new Size(207, 29);
            btnHumanos.TabIndex = 4;
            btnHumanos.Text = "       Humanos";
            btnHumanos.TextAlign = ContentAlignment.MiddleLeft;
            btnHumanos.UseVisualStyleBackColor = true;
            btnHumanos.Click += btnHumanos_Click;
            // 
            // panelClientes
            // 
            panelClientes.BackColor = Color.FromArgb(31, 96, 99);
            panelClientes.Controls.Add(btnAgregarClientes);
            panelClientes.Controls.Add(btnVerClientes);
            panelClientes.Dock = DockStyle.Top;
            panelClientes.Location = new Point(0, 182);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(207, 63);
            panelClientes.TabIndex = 2;
            // 
            // btnAgregarClientes
            // 
            btnAgregarClientes.Dock = DockStyle.Top;
            btnAgregarClientes.FlatAppearance.BorderSize = 0;
            btnAgregarClientes.FlatStyle = FlatStyle.Flat;
            btnAgregarClientes.Location = new Point(0, 29);
            btnAgregarClientes.Name = "btnAgregarClientes";
            btnAgregarClientes.Padding = new Padding(40, 0, 0, 0);
            btnAgregarClientes.Size = new Size(207, 29);
            btnAgregarClientes.TabIndex = 1;
            btnAgregarClientes.Text = "Agregar mascotas";
            btnAgregarClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregarClientes.UseVisualStyleBackColor = true;
            btnAgregarClientes.Click += btnAgregarClientes_Click;
            // 
            // btnVerClientes
            // 
            btnVerClientes.Dock = DockStyle.Top;
            btnVerClientes.FlatAppearance.BorderSize = 0;
            btnVerClientes.FlatStyle = FlatStyle.Flat;
            btnVerClientes.Location = new Point(0, 0);
            btnVerClientes.Name = "btnVerClientes";
            btnVerClientes.Padding = new Padding(40, 0, 0, 0);
            btnVerClientes.Size = new Size(207, 29);
            btnVerClientes.TabIndex = 0;
            btnVerClientes.Text = "Ver Mascotas";
            btnVerClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnVerClientes.UseVisualStyleBackColor = true;
            btnVerClientes.Click += btnVerClientes_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(207, 153);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.BD2logoProyect;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(228, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(871, 698);
            panelPrincipal.TabIndex = 1;
            panelPrincipal.Paint += panelPrincipal_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 698);
            Controls.Add(panelPrincipal);
            Controls.Add(panelLateral);
            Name = "Form1";
            Text = "Form1";
            panelLateral.ResumeLayout(false);
            panel_Adm.ResumeLayout(false);
            panelCitas.ResumeLayout(false);
            panelInventario.ResumeLayout(false);
            panelHumanos.ResumeLayout(false);
            panelClientes.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel panelLateral;
        private Button btnClientes;
        private Panel panelLogo;
        private Panel panelClientes;
        private Button btnVerClientes;
        private Button btnHumanos;
        private Button btnAgregarClientes;
        private Panel panelHumanos;
        private Button btnAgregarHumano;
        private Button btnVerHumanos;
        private PictureBox pictureBox1;
        private Panel panelPrincipal;
        private Button btnInventario;
        private Panel panelInventario;
        private Button btnVerProductos;
        private Button btnAgregarInventario;
        private Button btnHospedaje;
        private Button btnClinica;
        private Panel panelCitas;
        private Button btnCitas;
        private Button btnGrooming;
        private Panel panel_Adm;
        private Button btn_servicios;
        private Button btn_Compras;
        private Button btn_Empleados;
        private Button btn_Administracion;
        private Button btn_proveedores;
        private Button btn_bancos;
    }
}
