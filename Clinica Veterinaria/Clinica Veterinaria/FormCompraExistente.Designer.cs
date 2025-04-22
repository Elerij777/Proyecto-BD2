namespace Clinica_Veterinaria
{
    partial class FormCompraExistente
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
            txtProveedor = new TextBox();
            txtCantidad = new TextBox();
            txtDetalle = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtPrecio = new TextBox();
            txtProducto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_Guardar = new Button();
            BtnElegirProveedor = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtProveedor
            // 
            txtProveedor.BackColor = Color.FromArgb(182, 207, 250);
            txtProveedor.BorderStyle = BorderStyle.None;
            txtProveedor.Location = new Point(120, 41);
            txtProveedor.Margin = new Padding(0);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(106, 16);
            txtProveedor.TabIndex = 0;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.FromArgb(182, 207, 250);
            txtCantidad.BorderStyle = BorderStyle.None;
            txtCantidad.Location = new Point(120, 88);
            txtCantidad.Margin = new Padding(2, 2, 2, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(106, 16);
            txtCantidad.TabIndex = 1;
            // 
            // txtDetalle
            // 
            txtDetalle.BackColor = Color.FromArgb(182, 207, 250);
            txtDetalle.BorderStyle = BorderStyle.None;
            txtDetalle.Location = new Point(120, 130);
            txtDetalle.Margin = new Padding(2, 2, 2, 2);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(106, 16);
            txtDetalle.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(396, 39);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(182, 207, 250);
            txtPrecio.BorderStyle = BorderStyle.None;
            txtPrecio.Location = new Point(120, 174);
            txtPrecio.Margin = new Padding(2, 2, 2, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(106, 16);
            txtPrecio.TabIndex = 4;
            // 
            // txtProducto
            // 
            txtProducto.BackColor = Color.FromArgb(182, 207, 250);
            txtProducto.BorderStyle = BorderStyle.None;
            txtProducto.Location = new Point(120, 218);
            txtProducto.Margin = new Padding(2, 2, 2, 2);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(106, 16);
            txtProducto.TabIndex = 5;
            txtProducto.TextChanged += txtProducto_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 43);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 6;
            label1.Text = "Proveedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 88);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 7;
            label2.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 132);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(43, 15);
            label3.TabIndex = 8;
            label3.Text = "Detalle";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 178);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "Costo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 220);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 10;
            label5.Text = "Producto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(340, 41);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 11;
            label6.Text = "Fecha:";
            // 
            // btn_Guardar
            // 
            btn_Guardar.BackColor = Color.FromArgb(207, 226, 243);
            btn_Guardar.FlatStyle = FlatStyle.Flat;
            btn_Guardar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btn_Guardar.Location = new Point(509, 205);
            btn_Guardar.Margin = new Padding(2, 2, 2, 2);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(98, 44);
            btn_Guardar.TabIndex = 12;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = false;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // BtnElegirProveedor
            // 
            BtnElegirProveedor.FlatStyle = FlatStyle.Flat;
            BtnElegirProveedor.ForeColor = Color.FromArgb(182, 207, 230);
            BtnElegirProveedor.Image = Properties.Resources.lupa2;
            BtnElegirProveedor.Location = new Point(226, 36);
            BtnElegirProveedor.Margin = new Padding(0);
            BtnElegirProveedor.Name = "BtnElegirProveedor";
            BtnElegirProveedor.Size = new Size(25, 25);
            BtnElegirProveedor.TabIndex = 24;
            BtnElegirProveedor.UseVisualStyleBackColor = true;
            BtnElegirProveedor.Click += BtnElegirProveedor_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(182, 207, 230);
            button1.Image = Properties.Resources.lupa2;
            button1.Location = new Point(231, 215);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(25, 25);
            button1.TabIndex = 25;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormCompraExistente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(624, 270);
            Controls.Add(button1);
            Controls.Add(BtnElegirProveedor);
            Controls.Add(btn_Guardar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtProducto);
            Controls.Add(txtPrecio);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtDetalle);
            Controls.Add(txtCantidad);
            Controls.Add(txtProveedor);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormCompraExistente";
            Text = "FormCompraExistente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProveedor;
        private TextBox txtCantidad;
        private TextBox txtDetalle;
        private DateTimePicker dateTimePicker1;
        private TextBox txtPrecio;
        private TextBox txtProducto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_Guardar;
        private Button BtnElegirProveedor;
        private Button button1;
    }
}