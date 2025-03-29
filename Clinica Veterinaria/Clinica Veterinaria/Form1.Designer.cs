
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
            btnClientes.Size = new Size(228, 29);
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
            panelLateral.Size = new Size(228, 589);
            panelLateral.TabIndex = 0;
            // 
            // panelInventario
            // 
            panelInventario.BackColor = Color.FromArgb(31, 96, 99);
            panelInventario.Controls.Add(btnVerProductos);
            panelInventario.Controls.Add(btnAgregarInventario);
            panelInventario.Dock = DockStyle.Top;
            panelInventario.Location = new Point(0, 365);
            panelInventario.Name = "panelInventario";
            panelInventario.Size = new Size(228, 69);
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
            btnVerProductos.Size = new Size(228, 29);
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
            btnAgregarInventario.Size = new Size(228, 29);
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
            btnInventario.Size = new Size(228, 29);
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
            panelHumanos.Size = new Size(228, 62);
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
            btnAgregarHumano.Size = new Size(228, 29);
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
            btnVerHumanos.Size = new Size(228, 29);
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
            btnHumanos.Size = new Size(228, 29);
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
            panelClientes.Size = new Size(228, 63);
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
            btnAgregarClientes.Size = new Size(228, 29);
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
            btnVerClientes.Size = new Size(228, 29);
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
            panelLogo.Size = new Size(228, 153);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.BD2logoProyect;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 153);
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
            panelPrincipal.Size = new Size(756, 589);
            panelPrincipal.TabIndex = 1;
            panelPrincipal.Paint += panelPrincipal_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 589);
            Controls.Add(panelPrincipal);
            Controls.Add(panelLateral);
            Name = "Form1";
            Text = "Form1";
            panelLateral.ResumeLayout(false);
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
    }
}
