namespace Clinica_Veterinaria
{
    partial class FormGrooming
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
            txtMascota = new TextBox();
            btn_Seleccionar = new Button();
            label2 = new Label();
            txtEmpleado = new TextBox();
            btn_Empleado = new Button();
            label3 = new Label();
            ckb_Corte = new CheckBox();
            label4 = new Label();
            dtpFecha = new DateTimePicker();
            label5 = new Label();
            txtObservaciones = new TextBox();
            btn_guardar = new Button();
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
            panelPrincipal.Size = new Size(700, 55);
            panelPrincipal.TabIndex = 5;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(266, 14);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(132, 31);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Grooming";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 88);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 6;
            label1.Text = "Mascota:";
            // 
            // txtMascota
            // 
            txtMascota.BackColor = Color.FromArgb(182, 207, 250);
            txtMascota.BorderStyle = BorderStyle.None;
            txtMascota.Enabled = false;
            txtMascota.Location = new Point(146, 88);
            txtMascota.Margin = new Padding(0);
            txtMascota.Name = "txtMascota";
            txtMascota.Size = new Size(118, 16);
            txtMascota.TabIndex = 7;
            txtMascota.TextChanged += txtMascota_TextChanged;
            // 
            // btn_Seleccionar
            // 
            btn_Seleccionar.BackColor = Color.FromArgb(207, 226, 243);
            btn_Seleccionar.FlatStyle = FlatStyle.Flat;
            btn_Seleccionar.Location = new Point(263, 86);
            btn_Seleccionar.Margin = new Padding(0);
            btn_Seleccionar.Name = "btn_Seleccionar";
            btn_Seleccionar.Size = new Size(135, 24);
            btn_Seleccionar.TabIndex = 8;
            btn_Seleccionar.Text = "Seleccionar Mascota";
            btn_Seleccionar.UseVisualStyleBackColor = false;
            btn_Seleccionar.Click += btn_Seleccionar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 131);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 9;
            label2.Text = "Empleado:";
            // 
            // txtEmpleado
            // 
            txtEmpleado.BackColor = Color.FromArgb(182, 207, 250);
            txtEmpleado.BorderStyle = BorderStyle.None;
            txtEmpleado.Enabled = false;
            txtEmpleado.Location = new Point(146, 131);
            txtEmpleado.Margin = new Padding(2, 2, 2, 2);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(116, 16);
            txtEmpleado.TabIndex = 10;
            // 
            // btn_Empleado
            // 
            btn_Empleado.BackColor = Color.FromArgb(207, 226, 243);
            btn_Empleado.FlatStyle = FlatStyle.Flat;
            btn_Empleado.Location = new Point(263, 126);
            btn_Empleado.Margin = new Padding(2, 2, 2, 2);
            btn_Empleado.Name = "btn_Empleado";
            btn_Empleado.Size = new Size(135, 24);
            btn_Empleado.TabIndex = 11;
            btn_Empleado.Text = "Seleccionar Empleado";
            btn_Empleado.UseVisualStyleBackColor = false;
            btn_Empleado.Click += btn_Empleado_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 177);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 12;
            label3.Text = "Incluye:";
            // 
            // ckb_Corte
            // 
            ckb_Corte.AutoSize = true;
            ckb_Corte.Location = new Point(146, 177);
            ckb_Corte.Margin = new Padding(2, 2, 2, 2);
            ckb_Corte.Name = "ckb_Corte";
            ckb_Corte.Size = new Size(55, 19);
            ckb_Corte.TabIndex = 13;
            ckb_Corte.Text = "Corte";
            ckb_Corte.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(410, 86);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 15;
            label4.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(466, 82);
            dtpFecha.Margin = new Padding(2, 2, 2, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(211, 23);
            dtpFecha.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 220);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 17;
            label5.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            txtObservaciones.BackColor = Color.FromArgb(182, 207, 250);
            txtObservaciones.BorderStyle = BorderStyle.None;
            txtObservaciones.Location = new Point(146, 217);
            txtObservaciones.Margin = new Padding(2, 2, 2, 2);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(197, 16);
            txtObservaciones.TabIndex = 18;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.FromArgb(207, 226, 243);
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btn_guardar.Location = new Point(526, 282);
            btn_guardar.Margin = new Padding(2, 2, 2, 2);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(151, 44);
            btn_guardar.TabIndex = 19;
            btn_guardar.Text = "Guardar Registro";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // FormGrooming
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(700, 337);
            Controls.Add(btn_guardar);
            Controls.Add(txtObservaciones);
            Controls.Add(label5);
            Controls.Add(dtpFecha);
            Controls.Add(label4);
            Controls.Add(ckb_Corte);
            Controls.Add(label3);
            Controls.Add(btn_Empleado);
            Controls.Add(txtEmpleado);
            Controls.Add(label2);
            Controls.Add(btn_Seleccionar);
            Controls.Add(txtMascota);
            Controls.Add(label1);
            Controls.Add(panelPrincipal);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormGrooming";
            Text = "FormGrooming";
            Load += FormGrooming_Load;
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelPrincipal;
        private Label label1;
        private TextBox txtMascota;
        private Button btn_Seleccionar;
        private Label label2;
        private TextBox txtEmpleado;
        private Button btn_Empleado;
        private Label label3;
        private CheckBox ckb_Corte;
        private Label label4;
        private DateTimePicker dtpFecha;
        private Label label5;
        private TextBox txtObservaciones;
        private Button btn_guardar;
    }
}