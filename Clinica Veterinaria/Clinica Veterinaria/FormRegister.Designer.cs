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
            panelPrincipal.Margin = new Padding(3, 2, 3, 2);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(662, 94);
            panelPrincipal.TabIndex = 2;
            // 
            // labelPrincipal
            // 
            labelPrincipal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(206, 27);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(225, 31);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Agregar Usuarios";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(207, 226, 243);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Image = Properties.Resources.add__1_;
            btnAgregar.Location = new Point(297, 263);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(110, 44);
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
            txtApellido.Location = new Point(276, 154);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 23);
            txtApellido.TabIndex = 15;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(182, 207, 250);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(276, 120);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 23);
            txtNombre.TabIndex = 14;
            // 
            // cmbRol
            // 
            cmbRol.BackColor = Color.FromArgb(182, 207, 250);
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Recepcionista", "Veterinario" });
            cmbRol.Location = new Point(276, 191);
            cmbRol.Margin = new Padding(2);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(150, 23);
            cmbRol.TabIndex = 18;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(662, 318);
            Controls.Add(cmbRol);
            Controls.Add(btnAgregar);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(panelPrincipal);
            Margin = new Padding(2);
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
        private ComboBox cmbRol;
    }
}