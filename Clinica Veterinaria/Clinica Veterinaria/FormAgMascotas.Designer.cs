namespace Clinica_Veterinaria
{
    partial class FormAgMascotas
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
            panelPrincipal = new Panel();
            labelPrincipal = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPeso = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dtpFechaNacimiento = new MonthCalendar();
            label6 = new Label();
            label7 = new Label();
            btnSeleccionarFoto = new Button();
            btnAgregar = new Button();
            pictureBoxImagen = new PictureBox();
            cbxGenero = new ComboBox();
            cbxEspecie = new ComboBox();
            cbxRaza = new ComboBox();
            label8 = new Label();
            cbxClientes = new ComboBox();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(207, 226, 243);
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Margin = new Padding(3, 2, 3, 2);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(793, 94);
            panelPrincipal.TabIndex = 2;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(206, 26);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(249, 31);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Registrar Mascotas";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(182, 207, 250);
            txtNombre.Location = new Point(159, 119);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(133, 23);
            txtNombre.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 119);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 190);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 10;
            label2.Text = "Especie:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 224);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 11;
            label3.Text = "Raza:";
            // 
            // txtPeso
            // 
            txtPeso.BackColor = Color.FromArgb(182, 207, 250);
            txtPeso.Location = new Point(460, 155);
            txtPeso.Margin = new Padding(3, 2, 3, 2);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(133, 23);
            txtPeso.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(382, 119);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 13;
            label4.Text = "Genero:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(382, 155);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 15;
            label5.Text = "Peso:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(460, 188);
            dtpFechaNacimiento.Margin = new Padding(8, 7, 8, 7);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(382, 190);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 17;
            label6.Text = "Fecha:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(100, 259);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 18;
            label7.Text = "Foto:";
            // 
            // btnSeleccionarFoto
            // 
            btnSeleccionarFoto.Location = new Point(159, 252);
            btnSeleccionarFoto.Margin = new Padding(3, 2, 3, 2);
            btnSeleccionarFoto.Name = "btnSeleccionarFoto";
            btnSeleccionarFoto.Size = new Size(109, 22);
            btnSeleccionarFoto.TabIndex = 19;
            btnSeleccionarFoto.Text = "Seleccionar foto";
            btnSeleccionarFoto.UseVisualStyleBackColor = true;
            btnSeleccionarFoto.Click += btnSeleccionarFoto_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(207, 226, 243);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(537, 382);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 44);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.Location = new Point(100, 290);
            pictureBoxImagen.Margin = new Padding(3, 2, 3, 2);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(200, 136);
            pictureBoxImagen.TabIndex = 21;
            pictureBoxImagen.TabStop = false;
            // 
            // cbxGenero
            // 
            cbxGenero.BackColor = Color.FromArgb(182, 207, 250);
            cbxGenero.FormattingEnabled = true;
            cbxGenero.Location = new Point(460, 119);
            cbxGenero.Margin = new Padding(3, 2, 3, 2);
            cbxGenero.Name = "cbxGenero";
            cbxGenero.Size = new Size(133, 23);
            cbxGenero.TabIndex = 22;
            // 
            // cbxEspecie
            // 
            cbxEspecie.BackColor = Color.FromArgb(182, 207, 250);
            cbxEspecie.FormattingEnabled = true;
            cbxEspecie.Location = new Point(159, 187);
            cbxEspecie.Margin = new Padding(3, 2, 3, 2);
            cbxEspecie.Name = "cbxEspecie";
            cbxEspecie.Size = new Size(133, 23);
            cbxEspecie.TabIndex = 23;
            cbxEspecie.SelectedIndexChanged += cbxEspecie_SelectedIndexChanged;
            // 
            // cbxRaza
            // 
            cbxRaza.BackColor = Color.FromArgb(182, 207, 250);
            cbxRaza.FormattingEnabled = true;
            cbxRaza.Location = new Point(159, 221);
            cbxRaza.Margin = new Padding(3, 2, 3, 2);
            cbxRaza.Name = "cbxRaza";
            cbxRaza.Size = new Size(133, 23);
            cbxRaza.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(100, 155);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 25;
            label8.Text = "Cliente:";
            // 
            // cbxClientes
            // 
            cbxClientes.BackColor = Color.FromArgb(182, 207, 250);
            cbxClientes.FlatStyle = FlatStyle.Flat;
            cbxClientes.FormattingEnabled = true;
            cbxClientes.Location = new Point(159, 152);
            cbxClientes.Margin = new Padding(3, 2, 3, 2);
            cbxClientes.Name = "cbxClientes";
            cbxClientes.Size = new Size(133, 23);
            cbxClientes.TabIndex = 26;
            // 
            // FormAgMascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(793, 446);
            Controls.Add(cbxClientes);
            Controls.Add(label8);
            Controls.Add(cbxRaza);
            Controls.Add(cbxEspecie);
            Controls.Add(cbxGenero);
            Controls.Add(pictureBoxImagen);
            Controls.Add(btnAgregar);
            Controls.Add(btnSeleccionarFoto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label5);
            Controls.Add(txtPeso);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(panelPrincipal);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAgMascotas";
            Text = "Form3";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelPrincipal;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPeso;
        private Label label4;
        private Label label5;
        private MonthCalendar dtpFechaNacimiento;
        private Label label6;
        private Label label7;
        private Button btnSeleccionarFoto;
        private Button btnAgregar;
        private PictureBox pictureBoxImagen;
        private ComboBox cbxGenero;
        private ComboBox cbxEspecie;
        private ComboBox cbxRaza;
        private Label label8;
        private ComboBox cbxClientes;
    }
}