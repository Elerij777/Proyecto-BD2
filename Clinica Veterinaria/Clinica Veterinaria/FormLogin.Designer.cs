namespace Clinica_Veterinaria
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnInicioSesion = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 311);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 363);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(182, 207, 230);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Location = new Point(158, 305);
            txtUsuario.Margin = new Padding(2, 3, 2, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(267, 20);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "admin";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(182, 207, 230);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(158, 363);
            txtPassword.Margin = new Padding(2, 3, 2, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(267, 20);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "AddEM2025";
            // 
            // btnInicioSesion
            // 
            btnInicioSesion.BackColor = Color.FromArgb(207, 226, 243);
            btnInicioSesion.FlatStyle = FlatStyle.Flat;
            btnInicioSesion.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicioSesion.Location = new Point(226, 475);
            btnInicioSesion.Margin = new Padding(2, 3, 2, 3);
            btnInicioSesion.Name = "btnInicioSesion";
            btnInicioSesion.Size = new Size(113, 59);
            btnInicioSesion.TabIndex = 4;
            btnInicioSesion.Text = "Iniciar sesión";
            btnInicioSesion.UseVisualStyleBackColor = false;
            btnInicioSesion.Click += btnInicioSesion_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(207, 226, 243);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(226, 549);
            btnCancelar.Margin = new Padding(2, 3, 2, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 59);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.BD2logoProyect;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(93, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 232);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 40, 64);
            panel1.Location = new Point(158, 381);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 3);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(38, 40, 64);
            panel2.Location = new Point(158, 328);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(269, 3);
            panel2.TabIndex = 8;
            // 
            // FormLogin
            // 
            AcceptButton = btnInicioSesion;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            CancelButton = btnCancelar;
            ClientSize = new Size(495, 748);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnInicioSesion);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnInicioSesion;
        private Button btnCancelar;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
    }
}