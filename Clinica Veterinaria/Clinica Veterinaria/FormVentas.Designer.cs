namespace Clinica_Veterinaria
{
    partial class FormVentas
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
            txtCliente = new TextBox();
            BtnElegirCliente = new Button();
            txtFecha = new TextBox();
            label2 = new Label();
            dgvFactura = new DataGridView();
            label4 = new Label();
            BtnAgregarProducto = new Button();
            btnAgregarServivcio = new Button();
            BtnCancelar = new Button();
            BtnGuardarFactura = new Button();
            BtnCotizacion = new Button();
            txtSubTotal = new TextBox();
            label5 = new Label();
            txtImpuesto = new TextBox();
            label6 = new Label();
            txtTotal = new TextBox();
            label7 = new Label();
            cbMetodoPago = new ComboBox();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = SystemColors.ActiveCaption;
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(990, 125);
            panelPrincipal.TabIndex = 5;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(466, 38);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(143, 43);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Ventas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 172);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 6;
            label1.Text = "Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.Enabled = false;
            txtCliente.Location = new Point(114, 169);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(125, 27);
            txtCliente.TabIndex = 7;
            // 
            // BtnElegirCliente
            // 
            BtnElegirCliente.Image = Properties.Resources.lupa1;
            BtnElegirCliente.Location = new Point(257, 164);
            BtnElegirCliente.Name = "BtnElegirCliente";
            BtnElegirCliente.Size = new Size(39, 37);
            BtnElegirCliente.TabIndex = 22;
            BtnElegirCliente.UseVisualStyleBackColor = true;
            BtnElegirCliente.Click += BtnElegirCliente_Click;
            // 
            // txtFecha
            // 
            txtFecha.Enabled = false;
            txtFecha.Location = new Point(114, 215);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(125, 27);
            txtFecha.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 218);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 23;
            label2.Text = "Fecha:";
            // 
            // dgvFactura
            // 
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.Location = new Point(23, 283);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.RowHeadersWidth = 51;
            dgvFactura.Size = new Size(827, 314);
            dgvFactura.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 172);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 27;
            label4.Text = "Metodo De pago:";
            // 
            // BtnAgregarProducto
            // 
            BtnAgregarProducto.Image = Properties.Resources.add__1_;
            BtnAgregarProducto.ImageAlign = ContentAlignment.MiddleRight;
            BtnAgregarProducto.Location = new Point(683, 155);
            BtnAgregarProducto.Name = "BtnAgregarProducto";
            BtnAgregarProducto.Size = new Size(167, 43);
            BtnAgregarProducto.TabIndex = 30;
            BtnAgregarProducto.Text = "Agregar Producto";
            BtnAgregarProducto.TextAlign = ContentAlignment.MiddleLeft;
            BtnAgregarProducto.UseVisualStyleBackColor = true;
            BtnAgregarProducto.Click += BtnAgregarProducto_Click;
            // 
            // btnAgregarServivcio
            // 
            btnAgregarServivcio.Image = Properties.Resources.add__1_;
            btnAgregarServivcio.ImageAlign = ContentAlignment.MiddleRight;
            btnAgregarServivcio.Location = new Point(683, 210);
            btnAgregarServivcio.Name = "btnAgregarServivcio";
            btnAgregarServivcio.Size = new Size(167, 41);
            btnAgregarServivcio.TabIndex = 31;
            btnAgregarServivcio.Text = "Agregar Servicio";
            btnAgregarServivcio.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregarServivcio.UseVisualStyleBackColor = true;
            btnAgregarServivcio.Click += btnAgregarServivcio_Click_1;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(871, 568);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(94, 29);
            BtnCancelar.TabIndex = 32;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardarFactura
            // 
            BtnGuardarFactura.Location = new Point(871, 283);
            BtnGuardarFactura.Name = "BtnGuardarFactura";
            BtnGuardarFactura.Size = new Size(94, 29);
            BtnGuardarFactura.TabIndex = 33;
            BtnGuardarFactura.Text = "Guardar";
            BtnGuardarFactura.UseVisualStyleBackColor = true;
            BtnGuardarFactura.Click += BtnGuardarFactura_Click;
            // 
            // BtnCotizacion
            // 
            BtnCotizacion.Location = new Point(871, 318);
            BtnCotizacion.Name = "BtnCotizacion";
            BtnCotizacion.Size = new Size(94, 29);
            BtnCotizacion.TabIndex = 34;
            BtnCotizacion.Text = "Cotizacion";
            BtnCotizacion.UseVisualStyleBackColor = true;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Enabled = false;
            txtSubTotal.Location = new Point(114, 611);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(125, 27);
            txtSubTotal.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 614);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 35;
            label5.Text = "SubTotal:";
            // 
            // txtImpuesto
            // 
            txtImpuesto.Enabled = false;
            txtImpuesto.Location = new Point(368, 611);
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.Size = new Size(125, 27);
            txtImpuesto.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(292, 614);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 37;
            label6.Text = "Impuesto:";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(632, 615);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(556, 618);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 39;
            label7.Text = "Total:";
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Location = new Point(479, 164);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(151, 28);
            cbMetodoPago.TabIndex = 29;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 652);
            Controls.Add(txtTotal);
            Controls.Add(label7);
            Controls.Add(txtImpuesto);
            Controls.Add(label6);
            Controls.Add(txtSubTotal);
            Controls.Add(label5);
            Controls.Add(BtnCotizacion);
            Controls.Add(BtnGuardarFactura);
            Controls.Add(BtnCancelar);
            Controls.Add(btnAgregarServivcio);
            Controls.Add(BtnAgregarProducto);
            Controls.Add(cbMetodoPago);
            Controls.Add(label4);
            Controls.Add(dgvFactura);
            Controls.Add(txtFecha);
            Controls.Add(label2);
            Controls.Add(BtnElegirCliente);
            Controls.Add(txtCliente);
            Controls.Add(label1);
            Controls.Add(panelPrincipal);
            Name = "FormVentas";
            Text = "FormVentas";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelPrincipal;
        private Label label1;
        private TextBox txtCliente;
        private Button BtnElegirCliente;
        private TextBox txtFecha;
        private Label label2;
        private DataGridView dgvFactura;
        private Label label4;
        private Button BtnAgregarProducto;
        private Button btnAgregarServivcio;
        private Button BtnCancelar;
        private Button BtnGuardarFactura;
        private Button BtnCotizacion;
        private TextBox txtSubTotal;
        private Label label5;
        private TextBox txtImpuesto;
        private Label label6;
        private TextBox txtTotal;
        private Label label7;
        private ComboBox cbMetodoPago;
    }
}