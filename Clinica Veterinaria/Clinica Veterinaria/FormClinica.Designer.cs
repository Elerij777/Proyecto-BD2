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
            panelPrincipal.BackColor = Color.FromArgb(207, 226, 243);
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Margin = new Padding(2, 2, 2, 2);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(700, 70);
            panelPrincipal.TabIndex = 0;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(296, 21);
            labelPrincipal.Margin = new Padding(2, 0, 2, 0);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(96, 31);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Clinica";
            // 
            // labelMascota
            // 
            labelMascota.AutoSize = true;
            labelMascota.Location = new Point(32, 87);
            labelMascota.Margin = new Padding(2, 0, 2, 0);
            labelMascota.Name = "labelMascota";
            labelMascota.Size = new Size(52, 15);
            labelMascota.TabIndex = 1;
            labelMascota.Text = "Mascota";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 135);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 3;
            label1.Text = "Descripcion";
            // 
            // tbDescripcion
            // 
            tbDescripcion.BackColor = Color.FromArgb(182, 207, 250);
            tbDescripcion.BorderStyle = BorderStyle.None;
            tbDescripcion.Location = new Point(174, 131);
            tbDescripcion.Margin = new Padding(2, 2, 2, 2);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(129, 16);
            tbDescripcion.TabIndex = 4;
            // 
            // tbDiagnostico
            // 
            tbDiagnostico.BackColor = Color.FromArgb(182, 207, 250);
            tbDiagnostico.BorderStyle = BorderStyle.None;
            tbDiagnostico.Location = new Point(174, 182);
            tbDiagnostico.Margin = new Padding(2, 2, 2, 2);
            tbDiagnostico.Name = "tbDiagnostico";
            tbDiagnostico.Size = new Size(129, 16);
            tbDiagnostico.TabIndex = 5;
            // 
            // tbTratamiento
            // 
            tbTratamiento.BackColor = Color.FromArgb(182, 207, 250);
            tbTratamiento.BorderStyle = BorderStyle.None;
            tbTratamiento.Location = new Point(174, 230);
            tbTratamiento.Margin = new Padding(2, 2, 2, 2);
            tbTratamiento.Name = "tbTratamiento";
            tbTratamiento.Size = new Size(129, 16);
            tbTratamiento.TabIndex = 6;
            // 
            // labelDiagnostico
            // 
            labelDiagnostico.AutoSize = true;
            labelDiagnostico.Location = new Point(29, 185);
            labelDiagnostico.Margin = new Padding(2, 0, 2, 0);
            labelDiagnostico.Name = "labelDiagnostico";
            labelDiagnostico.Size = new Size(70, 15);
            labelDiagnostico.TabIndex = 8;
            labelDiagnostico.Text = "Diagnostico";
            // 
            // labelTratamiento
            // 
            labelTratamiento.AutoSize = true;
            labelTratamiento.Location = new Point(29, 234);
            labelTratamiento.Margin = new Padding(2, 0, 2, 0);
            labelTratamiento.Name = "labelTratamiento";
            labelTratamiento.Size = new Size(70, 15);
            labelTratamiento.TabIndex = 9;
            labelTratamiento.Text = "Tratamiento";
            // 
            // labelEmpleado
            // 
            labelEmpleado.AutoSize = true;
            labelEmpleado.Location = new Point(29, 271);
            labelEmpleado.Margin = new Padding(2, 0, 2, 0);
            labelEmpleado.Name = "labelEmpleado";
            labelEmpleado.Size = new Size(60, 15);
            labelEmpleado.TabIndex = 10;
            labelEmpleado.Text = "Empleado";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Location = new Point(436, 87);
            labelFecha.Margin = new Padding(2, 0, 2, 0);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(38, 15);
            labelFecha.TabIndex = 11;
            labelFecha.Text = "Fecha";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(207, 226, 243);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnAgregar.Location = new Point(585, 256);
            btnAgregar.Margin = new Padding(2, 2, 2, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(104, 44);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dtpCita
            // 
            dtpCita.Location = new Point(478, 81);
            dtpCita.Margin = new Padding(2, 2, 2, 2);
            dtpCita.Name = "dtpCita";
            dtpCita.Size = new Size(211, 23);
            dtpCita.TabIndex = 14;
            // 
            // btn_AgregarMascota
            // 
            btn_AgregarMascota.BackColor = Color.FromArgb(207, 226, 243);
            btn_AgregarMascota.FlatStyle = FlatStyle.Flat;
            btn_AgregarMascota.Location = new Point(245, 82);
            btn_AgregarMascota.Margin = new Padding(2, 2, 2, 2);
            btn_AgregarMascota.Name = "btn_AgregarMascota";
            btn_AgregarMascota.Size = new Size(133, 24);
            btn_AgregarMascota.TabIndex = 15;
            btn_AgregarMascota.Text = "Seleccionar Mascota";
            btn_AgregarMascota.UseVisualStyleBackColor = false;
            btn_AgregarMascota.Click += btn_AgregarMascota_Click;
            // 
            // txtMascota
            // 
            txtMascota.BackColor = Color.FromArgb(182, 207, 250);
            txtMascota.BorderStyle = BorderStyle.None;
            txtMascota.Enabled = false;
            txtMascota.Location = new Point(174, 88);
            txtMascota.Margin = new Padding(2, 2, 2, 2);
            txtMascota.Name = "txtMascota";
            txtMascota.Size = new Size(67, 16);
            txtMascota.TabIndex = 16;
            // 
            // txtEmpleado
            // 
            txtEmpleado.BackColor = Color.FromArgb(182, 207, 250);
            txtEmpleado.BorderStyle = BorderStyle.None;
            txtEmpleado.Enabled = false;
            txtEmpleado.Location = new Point(174, 271);
            txtEmpleado.Margin = new Padding(2, 2, 2, 2);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(64, 16);
            txtEmpleado.TabIndex = 17;
            // 
            // btn_Empleado
            // 
            btn_Empleado.BackColor = Color.FromArgb(207, 226, 243);
            btn_Empleado.FlatStyle = FlatStyle.Flat;
            btn_Empleado.Location = new Point(242, 266);
            btn_Empleado.Margin = new Padding(2, 2, 2, 2);
            btn_Empleado.Name = "btn_Empleado";
            btn_Empleado.Size = new Size(144, 24);
            btn_Empleado.TabIndex = 18;
            btn_Empleado.Text = "Seleccionar Empleado";
            btn_Empleado.UseVisualStyleBackColor = false;
            btn_Empleado.Click += btn_Empleado_Click;
            // 
            // FormClinica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(700, 337);
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormClinica";
            Text = "FormClinica";
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