
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
            dataGridView1 = new DataGridView();
            btnClientes = new Button();
            panelLateral.SuspendLayout();
            panelCitas.SuspendLayout();
            panelInventario.SuspendLayout();
            panelHumanos.SuspendLayout();
            panelClientes.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 191);
            btnClientes.Margin = new Padding(4);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(285, 36);
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
            panelLateral.Margin = new Padding(4);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(285, 872);
            panelLateral.TabIndex = 0;
            // 
            // panelCitas
            // 
            panelCitas.BackColor = Color.FromArgb(31, 96, 99);
            panelCitas.Controls.Add(btnGrooming);
            panelCitas.Controls.Add(btnHospedaje);
            panelCitas.Controls.Add(btnClinica);
            panelCitas.Dock = DockStyle.Top;
            panelCitas.Location = new Point(0, 578);
            panelCitas.Margin = new Padding(4);
            panelCitas.Name = "panelCitas";
            panelCitas.Size = new Size(285, 119);
            panelCitas.TabIndex = 1;
            // 
            // btnGrooming
            // 
            btnGrooming.BackColor = Color.FromArgb(31, 96, 99);
            btnGrooming.Dock = DockStyle.Top;
            btnGrooming.FlatAppearance.BorderSize = 0;
            btnGrooming.FlatStyle = FlatStyle.Flat;
            btnGrooming.ImageAlign = ContentAlignment.MiddleLeft;
            btnGrooming.Location = new Point(0, 72);
            btnGrooming.Margin = new Padding(4);
            btnGrooming.Name = "btnGrooming";
            btnGrooming.Size = new Size(285, 36);
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
            btnHospedaje.Location = new Point(0, 36);
            btnHospedaje.Margin = new Padding(4);
            btnHospedaje.Name = "btnHospedaje";
            btnHospedaje.Size = new Size(285, 36);
            btnHospedaje.TabIndex = 10;
            btnHospedaje.Text = "       Hospedaje";
            btnHospedaje.TextAlign = ContentAlignment.MiddleLeft;
            btnHospedaje.UseVisualStyleBackColor = false;
            // 
            // btnClinica
            // 
            btnClinica.BackColor = Color.FromArgb(31, 96, 99);
            btnClinica.Dock = DockStyle.Top;
            btnClinica.FlatAppearance.BorderSize = 0;
            btnClinica.FlatStyle = FlatStyle.Flat;
            btnClinica.ImageAlign = ContentAlignment.MiddleLeft;
            btnClinica.Location = new Point(0, 0);
            btnClinica.Margin = new Padding(4);
            btnClinica.Name = "btnClinica";
            btnClinica.Size = new Size(285, 36);
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
            btnCitas.FlatStyle = FlatStyle.Flat;
            btnCitas.Location = new Point(0, 542);
            btnCitas.Margin = new Padding(4);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(285, 36);
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
            panelInventario.Location = new Point(0, 456);
            panelInventario.Margin = new Padding(4);
            panelInventario.Name = "panelInventario";
            panelInventario.Size = new Size(285, 86);
            panelInventario.TabIndex = 7;
            // 
            // btnVerProductos
            // 
            btnVerProductos.Dock = DockStyle.Top;
            btnVerProductos.FlatAppearance.BorderSize = 0;
            btnVerProductos.FlatStyle = FlatStyle.Flat;
            btnVerProductos.Location = new Point(0, 36);
            btnVerProductos.Margin = new Padding(4);
            btnVerProductos.Name = "btnVerProductos";
            btnVerProductos.Padding = new Padding(50, 0, 0, 0);
            btnVerProductos.Size = new Size(285, 36);
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
            btnAgregarInventario.Margin = new Padding(4);
            btnAgregarInventario.Name = "btnAgregarInventario";
            btnAgregarInventario.Padding = new Padding(50, 0, 0, 0);
            btnAgregarInventario.Size = new Size(285, 36);
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
            btnInventario.Location = new Point(0, 420);
            btnInventario.Margin = new Padding(4);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(285, 36);
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
            panelHumanos.Location = new Point(0, 342);
            panelHumanos.Margin = new Padding(4);
            panelHumanos.Name = "panelHumanos";
            panelHumanos.Size = new Size(285, 78);
            panelHumanos.TabIndex = 5;
            // 
            // btnAgregarHumano
            // 
            btnAgregarHumano.Dock = DockStyle.Top;
            btnAgregarHumano.FlatAppearance.BorderSize = 0;
            btnAgregarHumano.FlatStyle = FlatStyle.Flat;
            btnAgregarHumano.Location = new Point(0, 36);
            btnAgregarHumano.Margin = new Padding(4);
            btnAgregarHumano.Name = "btnAgregarHumano";
            btnAgregarHumano.Padding = new Padding(50, 0, 0, 0);
            btnAgregarHumano.Size = new Size(285, 36);
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
            btnVerHumanos.Margin = new Padding(4);
            btnVerHumanos.Name = "btnVerHumanos";
            btnVerHumanos.Padding = new Padding(50, 0, 0, 0);
            btnVerHumanos.Size = new Size(285, 36);
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
            btnHumanos.Location = new Point(0, 306);
            btnHumanos.Margin = new Padding(4);
            btnHumanos.Name = "btnHumanos";
            btnHumanos.Size = new Size(285, 36);
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
            panelClientes.Location = new Point(0, 227);
            panelClientes.Margin = new Padding(4);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(285, 79);
            panelClientes.TabIndex = 2;
            // 
            // btnAgregarClientes
            // 
            btnAgregarClientes.Dock = DockStyle.Top;
            btnAgregarClientes.FlatAppearance.BorderSize = 0;
            btnAgregarClientes.FlatStyle = FlatStyle.Flat;
            btnAgregarClientes.Location = new Point(0, 36);
            btnAgregarClientes.Margin = new Padding(4);
            btnAgregarClientes.Name = "btnAgregarClientes";
            btnAgregarClientes.Padding = new Padding(50, 0, 0, 0);
            btnAgregarClientes.Size = new Size(285, 36);
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
            btnVerClientes.Margin = new Padding(4);
            btnVerClientes.Name = "btnVerClientes";
            btnVerClientes.Padding = new Padding(50, 0, 0, 0);
            btnVerClientes.Size = new Size(285, 36);
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
            panelLogo.Margin = new Padding(4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(285, 191);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.BD2logoProyect;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(dataGridView1);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(285, 0);
            panelPrincipal.Margin = new Padding(4);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1089, 872);
            panelPrincipal.TabIndex = 1;
            panelPrincipal.Paint += panelPrincipal_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(766, 92);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(375, 235);
            dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 872);
            Controls.Add(panelPrincipal);
            Controls.Add(panelLateral);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            panelLateral.ResumeLayout(false);
            panelCitas.ResumeLayout(false);
            panelInventario.ResumeLayout(false);
            panelHumanos.ResumeLayout(false);
            panelClientes.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Button btnHospedaje;
        private Button btnClinica;
        private Panel panelCitas;
        private Button btnCitas;
        private Button btnGrooming;
    }
}
