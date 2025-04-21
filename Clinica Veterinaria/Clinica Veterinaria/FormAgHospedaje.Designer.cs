namespace Clinica_Veterinaria
{
    partial class FormAgHospedaje
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAgregar = new Button();
            label5 = new Label();
            label6 = new Label();
            txtHabitacion = new TextBox();
            dateIngreso = new DateTimePicker();
            dateSalida = new DateTimePicker();
            txtMascota = new TextBox();
            txtAlimento = new TextBox();
            txtIndicaciones = new TextBox();
            BtnElegirMascota = new Button();
            BtnElegirHabitacion = new Button();
            label7 = new Label();
            cmbEstado = new ComboBox();
            button1 = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(207, 226, 243);
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(962, 125);
            panelPrincipal.TabIndex = 4;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(235, 35);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(311, 39);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Agregar Hospedaje";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.5F);
            label1.Location = new Point(14, 168);
            label1.Name = "label1";
            label1.Size = new Size(158, 31);
            label1.TabIndex = 5;
            label1.Text = "Habitacion ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.5F);
            label2.Location = new Point(14, 253);
            label2.Name = "label2";
            label2.Size = new Size(160, 31);
            label2.TabIndex = 6;
            label2.Text = "Fecha Ingreso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.5F);
            label3.Location = new Point(14, 320);
            label3.Name = "label3";
            label3.Size = new Size(146, 31);
            label3.TabIndex = 7;
            label3.Text = "Fecha Salida:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.5F);
            label4.Location = new Point(545, 168);
            label4.Name = "label4";
            label4.Size = new Size(106, 31);
            label4.TabIndex = 8;
            label4.Text = "Mascota:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(207, 226, 243);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Image = Properties.Resources.add__1_;
            btnAgregar.Location = new Point(778, 535);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 59);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = " Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.5F);
            label5.Location = new Point(545, 220);
            label5.Name = "label5";
            label5.Size = new Size(112, 31);
            label5.TabIndex = 10;
            label5.Text = "Alimento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.5F);
            label6.Location = new Point(545, 291);
            label6.Name = "label6";
            label6.Size = new Size(146, 31);
            label6.TabIndex = 11;
            label6.Text = "Indicaciones:";
            // 
            // txtHabitacion
            // 
            txtHabitacion.BackColor = Color.FromArgb(182, 207, 250);
            txtHabitacion.BorderStyle = BorderStyle.None;
            txtHabitacion.Enabled = false;
            txtHabitacion.Font = new Font("Segoe UI", 13.5F);
            txtHabitacion.Location = new Point(176, 168);
            txtHabitacion.Margin = new Padding(3, 3, 0, 3);
            txtHabitacion.Name = "txtHabitacion";
            txtHabitacion.Size = new Size(159, 30);
            txtHabitacion.TabIndex = 12;
            // 
            // dateIngreso
            // 
            dateIngreso.Font = new Font("Segoe UI", 13.5F);
            dateIngreso.Location = new Point(172, 253);
            dateIngreso.Margin = new Padding(2, 3, 2, 3);
            dateIngreso.Name = "dateIngreso";
            dateIngreso.Size = new Size(343, 37);
            dateIngreso.TabIndex = 15;
            // 
            // dateSalida
            // 
            dateSalida.Font = new Font("Segoe UI", 13.5F);
            dateSalida.Location = new Point(172, 320);
            dateSalida.Margin = new Padding(2, 3, 2, 3);
            dateSalida.Name = "dateSalida";
            dateSalida.Size = new Size(343, 37);
            dateSalida.TabIndex = 16;
            // 
            // txtMascota
            // 
            txtMascota.BackColor = Color.FromArgb(182, 207, 250);
            txtMascota.BorderStyle = BorderStyle.None;
            txtMascota.Enabled = false;
            txtMascota.Font = new Font("Segoe UI", 13.5F);
            txtMascota.Location = new Point(662, 168);
            txtMascota.Margin = new Padding(3, 3, 0, 3);
            txtMascota.Name = "txtMascota";
            txtMascota.Size = new Size(231, 30);
            txtMascota.TabIndex = 17;
            // 
            // txtAlimento
            // 
            txtAlimento.BackColor = Color.FromArgb(182, 207, 250);
            txtAlimento.BorderStyle = BorderStyle.None;
            txtAlimento.Enabled = false;
            txtAlimento.Font = new Font("Segoe UI", 13.5F);
            txtAlimento.Location = new Point(662, 221);
            txtAlimento.Margin = new Padding(3, 3, 0, 3);
            txtAlimento.Name = "txtAlimento";
            txtAlimento.Size = new Size(231, 30);
            txtAlimento.TabIndex = 18;
            txtAlimento.TextChanged += txtAlimento_TextChanged;
            // 
            // txtIndicaciones
            // 
            txtIndicaciones.BackColor = Color.FromArgb(182, 207, 250);
            txtIndicaciones.BorderStyle = BorderStyle.None;
            txtIndicaciones.Font = new Font("Segoe UI", 13.5F);
            txtIndicaciones.Location = new Point(659, 327);
            txtIndicaciones.Multiline = true;
            txtIndicaciones.Name = "txtIndicaciones";
            txtIndicaciones.Size = new Size(249, 181);
            txtIndicaciones.TabIndex = 19;
            txtIndicaciones.TextChanged += txtIndicaciones_TextChanged;
            // 
            // BtnElegirMascota
            // 
            BtnElegirMascota.BackColor = Color.FromArgb(182, 207, 250);
            BtnElegirMascota.FlatStyle = FlatStyle.Flat;
            BtnElegirMascota.ForeColor = Color.FromArgb(182, 207, 250);
            BtnElegirMascota.Image = Properties.Resources.lupa2;
            BtnElegirMascota.Location = new Point(893, 168);
            BtnElegirMascota.Margin = new Padding(0);
            BtnElegirMascota.Name = "BtnElegirMascota";
            BtnElegirMascota.Size = new Size(29, 32);
            BtnElegirMascota.TabIndex = 20;
            BtnElegirMascota.UseVisualStyleBackColor = false;
            BtnElegirMascota.Click += BtnElegirMascota_Click;
            // 
            // BtnElegirHabitacion
            // 
            BtnElegirHabitacion.BackColor = Color.FromArgb(182, 207, 250);
            BtnElegirHabitacion.FlatStyle = FlatStyle.Flat;
            BtnElegirHabitacion.ForeColor = Color.FromArgb(182, 207, 250);
            BtnElegirHabitacion.Image = Properties.Resources.lupa2;
            BtnElegirHabitacion.Location = new Point(335, 168);
            BtnElegirHabitacion.Margin = new Padding(0);
            BtnElegirHabitacion.Name = "BtnElegirHabitacion";
            BtnElegirHabitacion.Size = new Size(27, 32);
            BtnElegirHabitacion.TabIndex = 21;
            BtnElegirHabitacion.UseVisualStyleBackColor = false;
            BtnElegirHabitacion.Click += BtnElegirHabitacion_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.5F);
            label7.Location = new Point(14, 405);
            label7.Name = "label7";
            label7.Size = new Size(88, 31);
            label7.TabIndex = 22;
            label7.Text = "Estado:";
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.FromArgb(182, 207, 250);
            cmbEstado.Font = new Font("Segoe UI", 13.5F);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(158, 401);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(151, 38);
            cmbEstado.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(182, 207, 250);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(182, 207, 250);
            button1.Image = Properties.Resources.lupa2;
            button1.Location = new Point(893, 221);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(29, 32);
            button1.TabIndex = 26;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(38, 40, 64);
            panel2.Location = new Point(176, 204);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(159, 3);
            panel2.TabIndex = 27;
            panel2.Paint += panel2_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 40, 64);
            panel1.Location = new Point(662, 204);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 3);
            panel1.TabIndex = 28;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(38, 40, 64);
            panel3.Location = new Point(662, 253);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(231, 3);
            panel3.TabIndex = 29;
            // 
            // FormAgHospedaje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(962, 595);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(cmbEstado);
            Controls.Add(label7);
            Controls.Add(BtnElegirHabitacion);
            Controls.Add(BtnElegirMascota);
            Controls.Add(txtIndicaciones);
            Controls.Add(txtAlimento);
            Controls.Add(txtMascota);
            Controls.Add(dateSalida);
            Controls.Add(dateIngreso);
            Controls.Add(txtHabitacion);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelPrincipal);
            Name = "FormAgHospedaje";
            Text = "Form2";
            Load += FormAgHospedaje_Load;
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelPrincipal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAgregar;
        private Label label5;
        private Label label6;
        private TextBox txtHabitacion;
        private DateTimePicker dateIngreso;
        private DateTimePicker dateSalida;
        private TextBox txtMascota;
        private TextBox txtAlimento;
        private TextBox txtIndicaciones;
        private Button BtnElegirMascota;
        private Button BtnElegirHabitacion;
        private Label label7;
        private ComboBox cmbEstado;
        private Button button1;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
    }
}