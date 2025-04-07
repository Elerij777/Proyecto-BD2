namespace Clinica_Veterinaria
{
    partial class FormClinica
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
            labelMascota = new Label();
            label1 = new Label();
            tbDescripcion = new TextBox();
            tbDiagnostico = new TextBox();
            tbTratamiento = new TextBox();
            labelDiagnostico = new Label();
            labelTratamiento = new Label();
            labelEmpleado = new Label();
            labelFecha = new Label();
            btnAgregar = new Button();
            dtpCita = new DateTimePicker();
            btn_AgregarMascota = new Button();
            txtMascota = new TextBox();
            txtEmpleado = new TextBox();
            btn_Empleado = new Button();
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
            panelPrincipal.Size = new Size(1000, 116);
            panelPrincipal.TabIndex = 0;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(423, 35);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(169, 50);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Clinica";
            // 
            // labelMascota
            // 
            labelMascota.AutoSize = true;
            labelMascota.Location = new Point(45, 145);
            labelMascota.Name = "labelMascota";
            labelMascota.Size = new Size(79, 25);
            labelMascota.TabIndex = 1;
            labelMascota.Text = "Mascota";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 225);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 3;
            label1.Text = "Descripcion";
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(248, 219);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(182, 31);
            tbDescripcion.TabIndex = 4;
            // 
            // tbDiagnostico
            // 
            tbDiagnostico.Location = new Point(248, 303);
            tbDiagnostico.Name = "tbDiagnostico";
            tbDiagnostico.Size = new Size(182, 31);
            tbDiagnostico.TabIndex = 5;
            // 
            // tbTratamiento
            // 
            tbTratamiento.Location = new Point(248, 384);
            tbTratamiento.Name = "tbTratamiento";
            tbTratamiento.Size = new Size(182, 31);
            tbTratamiento.TabIndex = 6;
            // 
            // labelDiagnostico
            // 
            labelDiagnostico.AutoSize = true;
            labelDiagnostico.Location = new Point(42, 309);
            labelDiagnostico.Name = "labelDiagnostico";
            labelDiagnostico.Size = new Size(107, 25);
            labelDiagnostico.TabIndex = 8;
            labelDiagnostico.Text = "Diagnostico";
            // 
            // labelTratamiento
            // 
            labelTratamiento.AutoSize = true;
            labelTratamiento.Location = new Point(42, 390);
            labelTratamiento.Name = "labelTratamiento";
            labelTratamiento.Size = new Size(105, 25);
            labelTratamiento.TabIndex = 9;
            labelTratamiento.Text = "Tratamiento";
            // 
            // labelEmpleado
            // 
            labelEmpleado.AutoSize = true;
            labelEmpleado.Location = new Point(45, 465);
            labelEmpleado.Name = "labelEmpleado";
            labelEmpleado.Size = new Size(92, 25);
            labelEmpleado.TabIndex = 10;
            labelEmpleado.Text = "Empleado";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Location = new Point(590, 145);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(57, 25);
            labelFecha.TabIndex = 11;
            labelFecha.Text = "Fecha";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(741, 480);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(149, 34);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dtpCita
            // 
            dtpCita.Location = new Point(677, 145);
            dtpCita.Name = "dtpCita";
            dtpCita.Size = new Size(300, 31);
            dtpCita.TabIndex = 14;
            // 
            // btn_AgregarMascota
            // 
            btn_AgregarMascota.Location = new Point(366, 145);
            btn_AgregarMascota.Name = "btn_AgregarMascota";
            btn_AgregarMascota.Size = new Size(190, 33);
            btn_AgregarMascota.TabIndex = 15;
            btn_AgregarMascota.Text = "Seleccionar Mascota";
            btn_AgregarMascota.UseVisualStyleBackColor = true;
            btn_AgregarMascota.Click += btn_AgregarMascota_Click;
            // 
            // txtMascota
            // 
            txtMascota.Enabled = false;
            txtMascota.Location = new Point(248, 147);
            txtMascota.Name = "txtMascota";
            txtMascota.Size = new Size(94, 31);
            txtMascota.TabIndex = 16;
            // 
            // txtEmpleado
            // 
            txtEmpleado.Enabled = false;
            txtEmpleado.Location = new Point(253, 456);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(89, 31);
            txtEmpleado.TabIndex = 17;
            // 
            // btn_Empleado
            // 
            btn_Empleado.Location = new Point(366, 456);
            btn_Empleado.Name = "btn_Empleado";
            btn_Empleado.Size = new Size(205, 33);
            btn_Empleado.TabIndex = 18;
            btn_Empleado.Text = "Seleccionar Empleado";
            btn_Empleado.UseVisualStyleBackColor = true;
            btn_Empleado.Click += btn_Empleado_Click;
            // 
            // FormClinica
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btn_Empleado);
            Controls.Add(txtEmpleado);
            Controls.Add(txtMascota);
            Controls.Add(btn_AgregarMascota);
            Controls.Add(dtpCita);
            Controls.Add(btnAgregar);
            Controls.Add(labelFecha);
            Controls.Add(labelEmpleado);
            Controls.Add(labelTratamiento);
            Controls.Add(labelDiagnostico);
            Controls.Add(tbTratamiento);
            Controls.Add(tbDiagnostico);
            Controls.Add(tbDescripcion);
            Controls.Add(label1);
            Controls.Add(labelMascota);
            Controls.Add(panelPrincipal);
            Name = "FormClinica";
            Text = "FormClinica";
            Load += FormClinica_Load;
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelPrincipal;
        private Label labelMascota;
        private ComboBox cMascota;
        private Label label1;
        private TextBox tbDescripcion;
        private TextBox tbDiagnostico;
        private TextBox tbTratamiento;
        private Label labelDiagnostico;
        private Label labelTratamiento;
        private Label labelEmpleado;
        private Label labelFecha;
        private Button btnAgregar;
        private DateTimePicker dtpCita;
        private Button btn_AgregarMascota;
        private TextBox txtMascota;
        private TextBox txtEmpleado;
        private Button btn_Empleado;
    }
}