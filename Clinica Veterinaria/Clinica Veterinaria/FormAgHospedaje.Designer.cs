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
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            BtnElegirMascota = new Button();
            BtnElegirHabitacion = new Button();
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
            label1.Location = new Point(74, 181);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 5;
            label1.Text = "Habitacion:";
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
            btnAgregar.Location = new Point(305, 381);
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
            // textBox3
            // 
            textBox3.Location = new Point(537, 224);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 27);
            textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(546, 268);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(233, 125);
            textBox4.TabIndex = 19;
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
            // FormAgHospedaje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 450);
            Controls.Add(BtnElegirHabitacion);
            Controls.Add(BtnElegirMascota);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
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
        private TextBox textBox3;
        private TextBox textBox4;
        private Button BtnElegirMascota;
        private Button BtnElegirHabitacion;
    }
}