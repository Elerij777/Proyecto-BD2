
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelLateral = new Panel();
            panelHumanos = new Panel();
            btnAgregarHumano = new Button();
            btnVerHumanos = new Button();
            btnHumanos = new Button();
            panelClientes = new Panel();
            btnAgregarClientes = new Button();
            btnVerClientes = new Button();
            btnClientes = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelPrincipal = new Panel();
            panelLateral.SuspendLayout();
            panelHumanos.SuspendLayout();
            panelClientes.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLateral
            // 
            panelLateral.BackColor = Color.FromArgb(224, 224, 224);
            panelLateral.Controls.Add(panelHumanos);
            panelLateral.Controls.Add(btnHumanos);
            panelLateral.Controls.Add(panelClientes);
            panelLateral.Controls.Add(btnClientes);
            panelLateral.Controls.Add(panelLogo);
            panelLateral.Dock = DockStyle.Left;
            panelLateral.Location = new Point(0, 0);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(228, 482);
            panelLateral.TabIndex = 0;
            // 
            // panelHumanos
            // 
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
            btnAgregarHumano.Location = new Point(0, 29);
            btnAgregarHumano.Name = "btnAgregarHumano";
            btnAgregarHumano.Size = new Size(228, 29);
            btnAgregarHumano.TabIndex = 1;
            btnAgregarHumano.Text = "Agregar Humanos";
            btnAgregarHumano.UseVisualStyleBackColor = true;
            // 
            // btnVerHumanos
            // 
            btnVerHumanos.Dock = DockStyle.Top;
            btnVerHumanos.Location = new Point(0, 0);
            btnVerHumanos.Name = "btnVerHumanos";
            btnVerHumanos.Size = new Size(228, 29);
            btnVerHumanos.TabIndex = 0;
            btnVerHumanos.Text = "Ver Humanos";
            btnVerHumanos.UseVisualStyleBackColor = true;
            // 
            // btnHumanos
            // 
            btnHumanos.Dock = DockStyle.Top;
            btnHumanos.Location = new Point(0, 245);
            btnHumanos.Name = "btnHumanos";
            btnHumanos.Size = new Size(228, 29);
            btnHumanos.TabIndex = 4;
            btnHumanos.Text = "Humanos";
            btnHumanos.UseVisualStyleBackColor = true;
            btnHumanos.Click += btnHumanos_Click;
            // 
            // panelClientes
            // 
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
            btnAgregarClientes.Location = new Point(0, 29);
            btnAgregarClientes.Name = "btnAgregarClientes";
            btnAgregarClientes.Size = new Size(228, 29);
            btnAgregarClientes.TabIndex = 1;
            btnAgregarClientes.Text = "Agregar Clientes";
            btnAgregarClientes.UseVisualStyleBackColor = true;
            // 
            // btnVerClientes
            // 
            btnVerClientes.Dock = DockStyle.Top;
            btnVerClientes.Location = new Point(0, 0);
            btnVerClientes.Name = "btnVerClientes";
            btnVerClientes.Size = new Size(228, 29);
            btnVerClientes.TabIndex = 0;
            btnVerClientes.Text = "Ver Clientes";
            btnVerClientes.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.Location = new Point(0, 153);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(228, 29);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
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
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(228, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(756, 482);
            panelPrincipal.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 482);
            Controls.Add(panelPrincipal);
            Controls.Add(panelLateral);
            Name = "Form1";
            Text = "Form1";
            panelLateral.ResumeLayout(false);
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
    }
}
