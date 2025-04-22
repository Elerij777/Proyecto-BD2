namespace Clinica_Veterinaria
{
    partial class FormAgProveedores
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
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            btn_Guardar = new Button();
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
            panelPrincipal.Size = new Size(700, 94);
            panelPrincipal.TabIndex = 4;
            // 
            // labelPrincipal
            // 
            labelPrincipal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(196, 33);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(271, 31);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Agregar Proveedores";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 124);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 163);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 6;
            label2.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 200);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Direccion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 238);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 8;
            label4.Text = "Correo:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(182, 207, 250);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(153, 124);
            txtNombre.Margin = new Padding(2, 2, 2, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(218, 16);
            txtNombre.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(182, 207, 250);
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Location = new Point(153, 163);
            txtTelefono.Margin = new Padding(2, 2, 2, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(218, 16);
            txtTelefono.TabIndex = 10;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.FromArgb(182, 207, 250);
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.Location = new Point(153, 201);
            txtDireccion.Margin = new Padding(2, 2, 2, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(218, 16);
            txtDireccion.TabIndex = 11;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(182, 207, 250);
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Location = new Point(153, 239);
            txtCorreo.Margin = new Padding(2, 2, 2, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(218, 16);
            txtCorreo.TabIndex = 12;
            // 
            // btn_Guardar
            // 
            btn_Guardar.BackColor = Color.FromArgb(207, 226, 243);
            btn_Guardar.FlatStyle = FlatStyle.Flat;
            btn_Guardar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btn_Guardar.Location = new Point(283, 282);
            btn_Guardar.Margin = new Padding(2, 2, 2, 2);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(88, 44);
            btn_Guardar.TabIndex = 13;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = false;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // FormAgProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(700, 337);
            Controls.Add(btn_Guardar);
            Controls.Add(txtCorreo);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelPrincipal);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormAgProveedores";
            Text = "FormAgProveedores";
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
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
        private Button btn_Guardar;
    }
}