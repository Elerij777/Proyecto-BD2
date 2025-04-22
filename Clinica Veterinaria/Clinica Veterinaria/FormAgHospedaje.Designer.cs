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
            panelPrincipal.Margin = new Padding(3, 2, 3, 2);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(842, 94);
            panelPrincipal.TabIndex = 4;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(206, 26);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(247, 31);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Agregar Hospedaje";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(66, 126);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 5;
            label1.Text = "Habitacion ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(65, 186);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 6;
            label2.Text = "Fecha Ingreso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(66, 246);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 7;
            label3.Text = "Fecha Salida:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(508, 126);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 8;
            label4.Text = "Mascota:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(207, 226, 243);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Image = Properties.Resources.add__1_;
            btnAgregar.Location = new Point(641, 391);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 44);
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
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(504, 186);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 10;
            label5.Text = "Alimento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(508, 246);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 11;
            label6.Text = "Indicaciones:";
            // 
            // txtHabitacion
            // 
            txtHabitacion.BackColor = Color.FromArgb(182, 207, 250);
            txtHabitacion.BorderStyle = BorderStyle.None;
            txtHabitacion.Enabled = false;
            txtHabitacion.Font = new Font("Segoe UI", 9F);
            txtHabitacion.Location = new Point(154, 126);
            txtHabitacion.Margin = new Padding(3, 2, 0, 2);
            txtHabitacion.Name = "txtHabitacion";
            txtHabitacion.Size = new Size(139, 16);
            txtHabitacion.TabIndex = 12;
            // 
            // dateIngreso
            // 
            dateIngreso.Font = new Font("Segoe UI", 9F);
            dateIngreso.Location = new Point(154, 180);
            dateIngreso.Margin = new Padding(2);
            dateIngreso.Name = "dateIngreso";
            dateIngreso.Size = new Size(301, 23);
            dateIngreso.TabIndex = 15;
            // 
            // dateSalida
            // 
            dateSalida.Font = new Font("Segoe UI", 9F);
            dateSalida.Location = new Point(154, 240);
            dateSalida.Margin = new Padding(2);
            dateSalida.Name = "dateSalida";
            dateSalida.Size = new Size(301, 23);
            dateSalida.TabIndex = 16;
            // 
            // txtMascota
            // 
            txtMascota.BackColor = Color.FromArgb(182, 207, 250);
            txtMascota.BorderStyle = BorderStyle.None;
            txtMascota.Enabled = false;
            txtMascota.Font = new Font("Segoe UI", 9F);
            txtMascota.Location = new Point(577, 125);
            txtMascota.Margin = new Padding(3, 2, 0, 2);
            txtMascota.Name = "txtMascota";
            txtMascota.Size = new Size(139, 16);
            txtMascota.TabIndex = 17;
            // 
            // txtAlimento
            // 
            txtAlimento.BackColor = Color.FromArgb(182, 207, 250);
            txtAlimento.BorderStyle = BorderStyle.None;
            txtAlimento.Enabled = false;
            txtAlimento.Font = new Font("Segoe UI", 9F);
            txtAlimento.Location = new Point(577, 186);
            txtAlimento.Margin = new Padding(3, 2, 0, 2);
            txtAlimento.Name = "txtAlimento";
            txtAlimento.Size = new Size(139, 16);
            txtAlimento.TabIndex = 18;
            // 
            // txtIndicaciones
            // 
            txtIndicaciones.BackColor = Color.FromArgb(182, 207, 250);
            txtIndicaciones.BorderStyle = BorderStyle.None;
            txtIndicaciones.Font = new Font("Segoe UI", 9F);
            txtIndicaciones.Location = new Point(508, 274);
            txtIndicaciones.Margin = new Padding(3, 2, 3, 2);
            txtIndicaciones.Multiline = true;
            txtIndicaciones.Name = "txtIndicaciones";
            txtIndicaciones.Size = new Size(233, 82);
            txtIndicaciones.TabIndex = 19;
            // 
            // BtnElegirMascota
            // 
            BtnElegirMascota.BackColor = Color.FromArgb(182, 207, 230);
            BtnElegirMascota.FlatStyle = FlatStyle.Flat;
            BtnElegirMascota.ForeColor = Color.FromArgb(182, 207, 230);
            BtnElegirMascota.Image = Properties.Resources.lupa2;
            BtnElegirMascota.Location = new Point(716, 121);
            BtnElegirMascota.Margin = new Padding(0);
            BtnElegirMascota.Name = "BtnElegirMascota";
            BtnElegirMascota.Size = new Size(25, 24);
            BtnElegirMascota.TabIndex = 20;
            BtnElegirMascota.UseVisualStyleBackColor = false;
            BtnElegirMascota.Click += BtnElegirMascota_Click;
            // 
            // BtnElegirHabitacion
            // 
            BtnElegirHabitacion.BackColor = Color.FromArgb(182, 207, 230);
            BtnElegirHabitacion.FlatStyle = FlatStyle.Flat;
            BtnElegirHabitacion.ForeColor = Color.FromArgb(182, 207, 230);
            BtnElegirHabitacion.Image = Properties.Resources.lupa2;
            BtnElegirHabitacion.Location = new Point(293, 121);
            BtnElegirHabitacion.Margin = new Padding(0);
            BtnElegirHabitacion.Name = "BtnElegirHabitacion";
            BtnElegirHabitacion.Size = new Size(24, 24);
            BtnElegirHabitacion.TabIndex = 21;
            BtnElegirHabitacion.UseVisualStyleBackColor = false;
            BtnElegirHabitacion.Click += BtnElegirHabitacion_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(66, 306);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 22;
            label7.Text = "Estado:";
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.FromArgb(182, 207, 250);
            cmbEstado.Font = new Font("Segoe UI", 9F);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(154, 298);
            cmbEstado.Margin = new Padding(3, 2, 3, 2);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(133, 23);
            cmbEstado.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(182, 207, 230);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(182, 207, 230);
            button1.Image = Properties.Resources.lupa2;
            button1.Location = new Point(716, 181);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(25, 24);
            button1.TabIndex = 26;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(38, 40, 64);
            panel2.Location = new Point(154, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(139, 2);
            panel2.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 40, 64);
            panel1.Location = new Point(577, 143);
            panel1.Name = "panel1";
            panel1.Size = new Size(139, 2);
            panel1.TabIndex = 28;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(38, 40, 64);
            panel3.Location = new Point(577, 203);
            panel3.Name = "panel3";
            panel3.Size = new Size(139, 2);
            panel3.TabIndex = 29;
            // 
            // FormAgHospedaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(842, 446);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAgHospedaje";
            Text = "Form2";
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