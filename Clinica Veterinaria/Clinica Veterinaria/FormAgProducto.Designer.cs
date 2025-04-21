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
            panelPrincipal.BackColor = Color.FromArgb(207, 226, 243);
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Margin = new Padding(3, 2, 3, 2);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(793, 94);
            panelPrincipal.TabIndex = 3;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(206, 26);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(226, 31);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Agregar Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 112);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 153);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 5;
            label2.Text = "Existencias";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 189);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "Costo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 222);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 7;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(324, 112);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 8;
            label5.Text = "TipoProducto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(324, 153);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 9;
            label6.Text = "Fecha de Caducidad";
            // 
            // dtpFechaCaducidad
            // 
            dtpFechaCaducidad.Location = new Point(449, 153);
            dtpFechaCaducidad.Margin = new Padding(8, 7, 8, 7);
            dtpFechaCaducidad.Name = "dtpFechaCaducidad";
            dtpFechaCaducidad.TabIndex = 17;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(207, 226, 243);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnAgregar.Image = Properties.Resources.add__1_;
            btnAgregar.Location = new Point(581, 340);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 44);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = " Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(182, 207, 250);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(108, 110);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(165, 16);
            txtNombre.TabIndex = 20;
            // 
            // txtExistencias
            // 
            txtExistencias.BackColor = Color.FromArgb(182, 207, 250);
            txtExistencias.BorderStyle = BorderStyle.None;
            txtExistencias.Location = new Point(108, 148);
            txtExistencias.Margin = new Padding(3, 2, 3, 2);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(165, 16);
            txtExistencias.TabIndex = 21;
            // 
            // txtCosto
            // 
            txtCosto.BackColor = Color.FromArgb(182, 207, 250);
            txtCosto.BorderStyle = BorderStyle.None;
            txtCosto.Location = new Point(108, 184);
            txtCosto.Margin = new Padding(3, 2, 3, 2);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(165, 16);
            txtCosto.TabIndex = 22;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(182, 207, 250);
            txtPrecio.BorderStyle = BorderStyle.None;
            txtPrecio.Location = new Point(108, 220);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(165, 16);
            txtPrecio.TabIndex = 23;
            // 
            // cbxTipoProduc
            // 
            cbxTipoProduc.BackColor = Color.FromArgb(182, 207, 250);
            cbxTipoProduc.FormattingEnabled = true;
            cbxTipoProduc.Location = new Point(449, 109);
            cbxTipoProduc.Margin = new Padding(3, 2, 3, 2);
            cbxTipoProduc.Name = "cbxTipoProduc";
            cbxTipoProduc.Size = new Size(167, 23);
            cbxTipoProduc.TabIndex = 24;
            // 
            // FormAgProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(793, 446);
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
            Margin = new Padding(3, 2, 3, 2);
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