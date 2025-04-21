namespace Clinica_Veterinaria
{
    partial class FormRegister
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
            btnAgregar = new Button();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbRol = new ComboBox();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(207, 226, 243);
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Margin = new Padding(4, 3, 4, 3);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(945, 157);
            panelPrincipal.TabIndex = 2;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(294, 45);
            labelPrincipal.Margin = new Padding(4, 0, 4, 0);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(330, 46);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Agregar Usuarios";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(207, 226, 243);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(451, 408);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(157, 73);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = " Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.FromArgb(182, 207, 250);
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Location = new Point(394, 257);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(213, 31);
            txtApellido.TabIndex = 15;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(182, 207, 250);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(394, 200);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(213, 31);
            txtNombre.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 318);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 25);
            label3.TabIndex = 13;
            label3.Text = "Rol:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 260);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 12;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 203);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 11;
            label1.Text = "Nombre:";
            // 
            // cmbRol
            // 
            cmbRol.BackColor = Color.FromArgb(182, 207, 250);
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Recepcionista", "Veterinario" });
            cmbRol.Location = new Point(394, 315);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(213, 33);
            cmbRol.TabIndex = 18;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 530);
            Controls.Add(cmbRol);
            Controls.Add(btnAgregar);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelPrincipal);
            Name = "FormRegister";
            Text = "FormRegister";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelPrincipal;
        private Button btnAgregar;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbRol;
    }
}