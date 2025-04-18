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
            panelPrincipal.BackColor = SystemColors.ActiveCaption;
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Margin = new Padding(4);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1000, 91);
            panelPrincipal.TabIndex = 5;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(380, 23);
            labelPrincipal.Margin = new Padding(4, 0, 4, 0);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(231, 50);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Grooming";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 147);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 6;
            label1.Text = "Mascota:";
            // 
            // txtMascota
            // 
            txtMascota.Enabled = false;
            txtMascota.Location = new Point(208, 147);
            txtMascota.Name = "txtMascota";
            txtMascota.Size = new Size(79, 31);
            txtMascota.TabIndex = 7;
            txtMascota.TextChanged += txtMascota_TextChanged;
            // 
            // btn_Seleccionar
            // 
            btn_Seleccionar.Location = new Point(295, 143);
            btn_Seleccionar.Name = "btn_Seleccionar";
            btn_Seleccionar.Size = new Size(193, 34);
            btn_Seleccionar.TabIndex = 8;
            btn_Seleccionar.Text = "Seleccionar Mascota";
            btn_Seleccionar.UseVisualStyleBackColor = true;
            btn_Seleccionar.Click += btn_Seleccionar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 219);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 9;
            label2.Text = "Empleado:";
            // 
            // txtEmpleado
            // 
            txtEmpleado.Enabled = false;
            txtEmpleado.Location = new Point(208, 218);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(81, 31);
            txtEmpleado.TabIndex = 10;
            // 
            // btn_Empleado
            // 
            btn_Empleado.Location = new Point(295, 218);
            btn_Empleado.Name = "btn_Empleado";
            btn_Empleado.Size = new Size(193, 34);
            btn_Empleado.TabIndex = 11;
            btn_Empleado.Text = "Seleccionar Empleado";
            btn_Empleado.UseVisualStyleBackColor = true;
            btn_Empleado.Click += btn_Empleado_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 295);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 12;
            label3.Text = "Incluye:";
            // 
            // ckb_Corte
            // 
            ckb_Corte.AutoSize = true;
            ckb_Corte.Location = new Point(208, 295);
            ckb_Corte.Name = "ckb_Corte";
            ckb_Corte.Size = new Size(81, 29);
            ckb_Corte.TabIndex = 13;
            ckb_Corte.Text = "Corte";
            ckb_Corte.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(585, 143);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 15;
            label4.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(665, 137);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(300, 31);
            dtpFecha.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 367);
            label5.Name = "label5";
            label5.Size = new Size(132, 25);
            label5.TabIndex = 17;
            label5.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(208, 361);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(280, 31);
            txtObservaciones.TabIndex = 18;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(52, 485);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(216, 41);
            btn_guardar.TabIndex = 19;
            btn_guardar.Text = "Guardar Registro";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // FormGrooming
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
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