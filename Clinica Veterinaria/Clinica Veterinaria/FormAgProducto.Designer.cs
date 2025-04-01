namespace Clinica_Veterinaria
{
    partial class FormAgProducto
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
            label5 = new Label();
            label6 = new Label();
            dtpFechaCaducidad = new MonthCalendar();
            btnAgregar = new Button();
            txtNombre = new TextBox();
            txtExistencias = new TextBox();
            txtCosto = new TextBox();
            txtPrecio = new TextBox();
            cbxTipoProduc = new ComboBox();
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
            panelPrincipal.Size = new Size(838, 125);
            panelPrincipal.TabIndex = 3;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(236, 35);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(363, 43);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Agregar Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 149);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 204);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 5;
            label2.Text = "Existencias";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 252);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 6;
            label3.Text = "Costo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 296);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(370, 149);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 8;
            label5.Text = "TipoProducto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(370, 204);
            label6.Name = "label6";
            label6.Size = new Size(143, 20);
            label6.TabIndex = 9;
            label6.Text = "Fecha de Caducidad";
            // 
            // dtpFechaCaducidad
            // 
            dtpFechaCaducidad.Location = new Point(481, 225);
            dtpFechaCaducidad.Name = "dtpFechaCaducidad";
            dtpFechaCaducidad.TabIndex = 17;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(302, 444);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(109, 36);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(124, 146);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(188, 27);
            txtNombre.TabIndex = 20;
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(124, 197);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(188, 27);
            txtExistencias.TabIndex = 21;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(124, 245);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(188, 27);
            txtCosto.TabIndex = 22;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(124, 293);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(188, 27);
            txtPrecio.TabIndex = 23;
            // 
            // cbxTipoProduc
            // 
            cbxTipoProduc.FormattingEnabled = true;
            cbxTipoProduc.Location = new Point(481, 145);
            cbxTipoProduc.Name = "cbxTipoProduc";
            cbxTipoProduc.Size = new Size(190, 28);
            cbxTipoProduc.TabIndex = 24;
            // 
            // FormAgProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 505);
            Controls.Add(cbxTipoProduc);
            Controls.Add(txtPrecio);
            Controls.Add(txtCosto);
            Controls.Add(txtExistencias);
            Controls.Add(txtNombre);
            Controls.Add(btnAgregar);
            Controls.Add(dtpFechaCaducidad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelPrincipal);
            Name = "FormAgProducto";
            Text = "FormAgProducto";
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
        private Label label5;
        private Label label6;
        private MonthCalendar dtpFechaCaducidad;
        private Button btnAgregar;
        private TextBox txtNombre;
        private TextBox txtExistencias;
        private TextBox txtCosto;
        private TextBox txtPrecio;
        private ComboBox cbxTipoProduc;
    }
}