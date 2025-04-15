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
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = SystemColors.ActiveCaption;
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(850, 125);
            panelPrincipal.TabIndex = 4;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(236, 35);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(368, 43);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Agregar Hospedaje";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 182);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 5;
            label1.Text = "Habitacion ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 224);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 6;
            label2.Text = "Fecha Ingreso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 271);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 7;
            label3.Text = "Fecha Salida:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(446, 181);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 8;
            label4.Text = "Mascota:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(358, 438);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(458, 224);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 10;
            label5.Text = "Alimento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(446, 271);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 11;
            label6.Text = "Indicaciones:";
            // 
            // txtHabitacion
            // 
            txtHabitacion.Enabled = false;
            txtHabitacion.Location = new Point(165, 178);
            txtHabitacion.Name = "txtHabitacion";
            txtHabitacion.Size = new Size(44, 27);
            txtHabitacion.TabIndex = 12;
            // 
            // dateIngreso
            // 
            dateIngreso.Location = new Point(158, 224);
            dateIngreso.Margin = new Padding(2);
            dateIngreso.Name = "dateIngreso";
            dateIngreso.Size = new Size(241, 27);
            dateIngreso.TabIndex = 15;
            // 
            // dateSalida
            // 
            dateSalida.Location = new Point(156, 271);
            dateSalida.Margin = new Padding(2);
            dateSalida.Name = "dateSalida";
            dateSalida.Size = new Size(241, 27);
            dateSalida.TabIndex = 16;
            // 
            // txtMascota
            // 
            txtMascota.Enabled = false;
            txtMascota.Location = new Point(537, 178);
            txtMascota.Name = "txtMascota";
            txtMascota.Size = new Size(93, 27);
            txtMascota.TabIndex = 17;
            // 
            // txtAlimento
            // 
            txtAlimento.Enabled = false;
            txtAlimento.Location = new Point(537, 224);
            txtAlimento.Name = "txtAlimento";
            txtAlimento.Size = new Size(40, 27);
            txtAlimento.TabIndex = 18;
            // 
            // txtIndicaciones
            // 
            txtIndicaciones.Location = new Point(546, 268);
            txtIndicaciones.Multiline = true;
            txtIndicaciones.Name = "txtIndicaciones";
            txtIndicaciones.Size = new Size(233, 125);
            txtIndicaciones.TabIndex = 19;
            // 
            // BtnElegirMascota
            // 
            BtnElegirMascota.Location = new Point(641, 178);
            BtnElegirMascota.Name = "BtnElegirMascota";
            BtnElegirMascota.Size = new Size(174, 29);
            BtnElegirMascota.TabIndex = 20;
            BtnElegirMascota.Text = "Seleccionar Mascota";
            BtnElegirMascota.UseVisualStyleBackColor = true;
            BtnElegirMascota.Click += BtnElegirMascota_Click;
            // 
            // BtnElegirHabitacion
            // 
            BtnElegirHabitacion.Location = new Point(227, 178);
            BtnElegirHabitacion.Name = "BtnElegirHabitacion";
            BtnElegirHabitacion.Size = new Size(170, 29);
            BtnElegirHabitacion.TabIndex = 21;
            BtnElegirHabitacion.Text = "Elegir Habitacion";
            BtnElegirHabitacion.UseVisualStyleBackColor = true;
            BtnElegirHabitacion.Click += BtnElegirHabitacion_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(94, 321);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 22;
            label7.Text = "Estado:";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(165, 318);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(151, 28);
            cmbEstado.TabIndex = 23;
            // 
            // button1
            // 
            button1.Location = new Point(609, 223);
            button1.Name = "button1";
            button1.Size = new Size(170, 29);
            button1.TabIndex = 26;
            button1.Text = "Elegir Habitacion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // FormAgHospedaje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 508);
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
    }
}