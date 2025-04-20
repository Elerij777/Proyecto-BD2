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
            txtProveedor.Location = new Point(171, 68);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(150, 31);
            txtProveedor.TabIndex = 0;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(171, 147);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(150, 31);
            txtCantidad.TabIndex = 1;
            // 
            // txtDetalle
            // 
            txtDetalle.Location = new Point(171, 217);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(150, 31);
            txtDetalle.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(566, 65);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(171, 290);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(150, 31);
            txtPrecio.TabIndex = 4;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(171, 364);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(150, 31);
            txtProducto.TabIndex = 5;
            txtProducto.TextChanged += txtProducto_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 71);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 6;
            label1.Text = "Proveedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 147);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 7;
            label2.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 220);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(66, 25);
            label3.TabIndex = 8;
            label3.Text = "Detalle";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 296);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 9;
            label4.Text = "Costo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 367);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 10;
            label5.Text = "Producto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(485, 68);
            label6.Name = "label6";
            label6.Size = new Size(61, 25);
            label6.TabIndex = 11;
            label6.Text = "Fecha:";
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(651, 358);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(112, 34);
            btn_Guardar.TabIndex = 12;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // BtnElegirProveedor
            // 
            BtnElegirProveedor.Image = Properties.Resources.lupa1;
            BtnElegirProveedor.Location = new Point(367, 60);
            BtnElegirProveedor.Margin = new Padding(4);
            BtnElegirProveedor.Name = "BtnElegirProveedor";
            BtnElegirProveedor.Size = new Size(49, 46);
            BtnElegirProveedor.TabIndex = 24;
            BtnElegirProveedor.UseVisualStyleBackColor = true;
            BtnElegirProveedor.Click += BtnElegirProveedor_Click;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.lupa1;
            button1.Location = new Point(367, 356);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(49, 46);
            button1.TabIndex = 25;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormCompraExistente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 450);
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