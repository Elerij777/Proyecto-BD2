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
            label3 = new Label();
            label4 = new Label();
            cbEstado = new ComboBox();
            cbMetodoPago = new ComboBox();
            BtnAgregarProducto = new Button();
            btnAgregarServivcio = new Button();
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
            panelPrincipal.Size = new Size(870, 125);
            panelPrincipal.TabIndex = 5;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(351, 38);
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
            BtnElegirCliente.Image = Properties.Resources.lupa;
            BtnElegirCliente.Location = new Point(257, 164);
            BtnElegirCliente.Name = "BtnElegirCliente";
            BtnElegirCliente.Size = new Size(39, 36);
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
            dgvFactura.Location = new Point(21, 263);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.RowHeadersWidth = 51;
            dgvFactura.Size = new Size(827, 251);
            dgvFactura.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(407, 176);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 26;
            label3.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 218);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 27;
            label4.Text = "Metodo De pago:";
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(479, 173);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(151, 28);
            cbEstado.TabIndex = 28;
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Location = new Point(479, 210);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(151, 28);
            cbMetodoPago.TabIndex = 29;
            // 
            // BtnAgregarProducto
            // 
            BtnAgregarProducto.Location = new Point(683, 169);
            BtnAgregarProducto.Name = "BtnAgregarProducto";
            BtnAgregarProducto.Size = new Size(147, 29);
            BtnAgregarProducto.TabIndex = 30;
            BtnAgregarProducto.Text = "Agregar Producto";
            BtnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // btnAgregarServivcio
            // 
            btnAgregarServivcio.Location = new Point(683, 213);
            btnAgregarServivcio.Name = "btnAgregarServivcio";
            btnAgregarServivcio.Size = new Size(147, 29);
            btnAgregarServivcio.TabIndex = 31;
            btnAgregarServivcio.Text = "Agregar Servicio";
            btnAgregarServivcio.UseVisualStyleBackColor = true;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 539);
            Controls.Add(btnAgregarServivcio);
            Controls.Add(BtnAgregarProducto);
            Controls.Add(cbMetodoPago);
            Controls.Add(cbEstado);
            Controls.Add(label4);
            Controls.Add(label3);
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
        private Label label3;
        private Label label4;
        private ComboBox cbEstado;
        private ComboBox cbMetodoPago;
        private Button BtnAgregarProducto;
        private Button btnAgregarServivcio;
    }
}