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
            panelPrincipal.BackColor = SystemColors.ActiveCaption;
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(906, 125);
            panelPrincipal.TabIndex = 2;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(236, 35);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(384, 43);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Registrar Mascotas";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(182, 156);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 159);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 8;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 254);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 10;
            label2.Text = "Especie:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 298);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 11;
            label3.Text = "Raza:";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(510, 207);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(125, 27);
            txtPeso.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(437, 159);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 13;
            label4.Text = "Genero:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(455, 207);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 15;
            label5.Text = "Peso:";
            label5.Click += label5_Click;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(526, 251);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(447, 254);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 17;
            label6.Text = "Fecha:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(114, 342);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 18;
            label7.Text = "Foto:";
            // 
            // btnSeleccionarFoto
            // 
            btnSeleccionarFoto.Location = new Point(182, 333);
            btnSeleccionarFoto.Name = "btnSeleccionarFoto";
            btnSeleccionarFoto.Size = new Size(125, 29);
            btnSeleccionarFoto.TabIndex = 19;
            btnSeleccionarFoto.Text = "Seleccionar foto";
            btnSeleccionarFoto.UseVisualStyleBackColor = true;
            btnSeleccionarFoto.Click += btnSeleccionarFoto_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(392, 484);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(125, 29);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.Location = new Point(132, 385);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(210, 164);
            pictureBoxImagen.TabIndex = 21;
            pictureBoxImagen.TabStop = false;
            // 
            // cbxGenero
            // 
            cbxGenero.FormattingEnabled = true;
            cbxGenero.Location = new Point(503, 159);
            cbxGenero.Name = "cbxGenero";
            cbxGenero.Size = new Size(151, 28);
            cbxGenero.TabIndex = 22;
            // 
            // cbxEspecie
            // 
            cbxEspecie.FormattingEnabled = true;
            cbxEspecie.Location = new Point(182, 246);
            cbxEspecie.Name = "cbxEspecie";
            cbxEspecie.Size = new Size(151, 28);
            cbxEspecie.TabIndex = 23;
            // 
            // cbxRaza
            // 
            cbxRaza.FormattingEnabled = true;
            cbxRaza.Location = new Point(182, 290);
            cbxRaza.Name = "cbxRaza";
            cbxRaza.Size = new Size(151, 28);
            cbxRaza.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(114, 207);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 25;
            label8.Text = "Cliente:";
            // 
            // cbxClientes
            // 
            cbxClientes.FormattingEnabled = true;
            cbxClientes.Location = new Point(178, 199);
            cbxClientes.Name = "cbxClientes";
            cbxClientes.Size = new Size(151, 28);
            cbxClientes.TabIndex = 26;
            // 
            // FormAgMascotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 594);
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
            Name = "FormAgMascotas";
            Text = "Form3";
            Load += Form3_Load;
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