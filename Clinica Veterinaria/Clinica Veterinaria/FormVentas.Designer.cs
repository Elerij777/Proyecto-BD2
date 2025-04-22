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
            panelPrincipal.BackColor = Color.FromArgb(207, 226, 243);
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Margin = new Padding(3, 2, 3, 2);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(866, 94);
            panelPrincipal.TabIndex = 5;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(333, 23);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(99, 31);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Ventas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 129);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 6;
            label1.Text = "Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.BackColor = Color.FromArgb(182, 207, 250);
            txtCliente.BorderStyle = BorderStyle.None;
            txtCliente.Enabled = false;
            txtCliente.Location = new Point(100, 127);
            txtCliente.Margin = new Padding(3, 2, 3, 2);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(110, 16);
            txtCliente.TabIndex = 7;
            // 
            // BtnElegirCliente
            // 
            BtnElegirCliente.BackColor = Color.FromArgb(182, 207, 230);
            BtnElegirCliente.FlatStyle = FlatStyle.Flat;
            BtnElegirCliente.ForeColor = Color.FromArgb(182, 207, 230);
            BtnElegirCliente.Image = Properties.Resources.lupa2;
            BtnElegirCliente.Location = new Point(225, 123);
            BtnElegirCliente.Margin = new Padding(3, 2, 3, 2);
            BtnElegirCliente.Name = "BtnElegirCliente";
            BtnElegirCliente.Size = new Size(24, 24);
            BtnElegirCliente.TabIndex = 22;
            BtnElegirCliente.UseVisualStyleBackColor = false;
            BtnElegirCliente.Click += BtnElegirCliente_Click;
            // 
            // txtFecha
            // 
            txtFecha.BackColor = Color.FromArgb(182, 207, 250);
            txtFecha.BorderStyle = BorderStyle.None;
            txtFecha.Enabled = false;
            txtFecha.Location = new Point(100, 161);
            txtFecha.Margin = new Padding(3, 2, 3, 2);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(110, 16);
            txtFecha.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 164);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 23;
            label2.Text = "Fecha:";
            // 
            // dgvFactura
            // 
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.Location = new Point(20, 212);
            dgvFactura.Margin = new Padding(3, 2, 3, 2);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.RowHeadersWidth = 51;
            dgvFactura.Size = new Size(724, 236);
            dgvFactura.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(295, 129);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 27;
            label4.Text = "Metodo De pago:";
            // 
            // BtnAgregarProducto
            // 
            BtnAgregarProducto.BackColor = Color.FromArgb(207, 226, 243);
            BtnAgregarProducto.FlatStyle = FlatStyle.Flat;
            BtnAgregarProducto.Image = Properties.Resources.add__1_;
            BtnAgregarProducto.ImageAlign = ContentAlignment.MiddleRight;
            BtnAgregarProducto.Location = new Point(598, 116);
            BtnAgregarProducto.Margin = new Padding(3, 2, 3, 2);
            BtnAgregarProducto.Name = "BtnAgregarProducto";
            BtnAgregarProducto.Size = new Size(146, 44);
            BtnAgregarProducto.TabIndex = 30;
            BtnAgregarProducto.Text = "Agregar Producto";
            BtnAgregarProducto.TextAlign = ContentAlignment.MiddleLeft;
            BtnAgregarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnAgregarProducto.UseVisualStyleBackColor = false;
            BtnAgregarProducto.Click += BtnAgregarProducto_Click;
            // 
            // btnAgregarServivcio
            // 
            btnAgregarServivcio.BackColor = Color.FromArgb(207, 226, 243);
            btnAgregarServivcio.FlatStyle = FlatStyle.Flat;
            btnAgregarServivcio.Image = Properties.Resources.add__1_;
            btnAgregarServivcio.ImageAlign = ContentAlignment.MiddleRight;
            btnAgregarServivcio.Location = new Point(598, 164);
            btnAgregarServivcio.Margin = new Padding(3, 2, 3, 2);
            btnAgregarServivcio.Name = "btnAgregarServivcio";
            btnAgregarServivcio.Size = new Size(146, 44);
            btnAgregarServivcio.TabIndex = 31;
            btnAgregarServivcio.Text = "Agregar Servicio";
            btnAgregarServivcio.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregarServivcio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarServivcio.UseVisualStyleBackColor = false;
            btnAgregarServivcio.Click += btnAgregarServivcio_Click_1;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.FromArgb(207, 226, 243);
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            BtnCancelar.Location = new Point(762, 404);
            BtnCancelar.Margin = new Padding(3, 2, 3, 2);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(90, 44);
            BtnCancelar.TabIndex = 32;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardarFactura
            // 
            BtnGuardarFactura.BackColor = Color.FromArgb(207, 226, 243);
            BtnGuardarFactura.FlatStyle = FlatStyle.Flat;
            BtnGuardarFactura.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            BtnGuardarFactura.Location = new Point(762, 212);
            BtnGuardarFactura.Margin = new Padding(3, 2, 3, 2);
            BtnGuardarFactura.Name = "BtnGuardarFactura";
            BtnGuardarFactura.Size = new Size(90, 44);
            BtnGuardarFactura.TabIndex = 33;
            BtnGuardarFactura.Text = "Guardar";
            BtnGuardarFactura.UseVisualStyleBackColor = false;
            BtnGuardarFactura.Click += BtnGuardarFactura_Click;
            // 
            // BtnCotizacion
            // 
            BtnCotizacion.BackColor = Color.FromArgb(207, 226, 243);
            BtnCotizacion.FlatStyle = FlatStyle.Flat;
            BtnCotizacion.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            BtnCotizacion.Location = new Point(762, 260);
            BtnCotizacion.Margin = new Padding(3, 2, 3, 2);
            BtnCotizacion.Name = "BtnCotizacion";
            BtnCotizacion.Size = new Size(90, 44);
            BtnCotizacion.TabIndex = 34;
            BtnCotizacion.Text = "Cotizacion";
            BtnCotizacion.UseVisualStyleBackColor = false;
            BtnCotizacion.Click += BtnCotizacion_Click;
            // 
            // txtSubTotal
            // 
            txtSubTotal.BackColor = Color.FromArgb(182, 207, 250);
            txtSubTotal.BorderStyle = BorderStyle.None;
            txtSubTotal.Enabled = false;
            txtSubTotal.Location = new Point(100, 458);
            txtSubTotal.Margin = new Padding(3, 2, 3, 2);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(110, 16);
            txtSubTotal.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 460);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 35;
            label5.Text = "SubTotal:";
            // 
            // txtImpuesto
            // 
            txtImpuesto.BackColor = Color.FromArgb(182, 207, 250);
            txtImpuesto.BorderStyle = BorderStyle.None;
            txtImpuesto.Enabled = false;
            txtImpuesto.Location = new Point(322, 458);
            txtImpuesto.Margin = new Padding(3, 2, 3, 2);
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.Size = new Size(110, 16);
            txtImpuesto.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(256, 460);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 37;
            label6.Text = "Impuesto:";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.FromArgb(182, 207, 250);
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(553, 461);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(110, 16);
            txtTotal.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(486, 464);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 39;
            label7.Text = "Total:";
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.BackColor = Color.FromArgb(182, 207, 250);
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Location = new Point(419, 123);
            cbMetodoPago.Margin = new Padding(3, 2, 3, 2);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(133, 23);
            cbMetodoPago.TabIndex = 29;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(866, 495);
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
            Margin = new Padding(3, 2, 3, 2);
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