namespace Clinica_Veterinaria
{
    partial class FormPagos
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
            BtnElegirCliente = new Button();
            txtCompraId = new TextBox();
            label1 = new Label();
            panelPrincipal = new Panel();
            labelPrincipal = new Label();
            txtMonto = new TextBox();
            label2 = new Label();
            txtObservaciones = new TextBox();
            label3 = new Label();
            button1 = new Button();
            txtBancoId = new TextBox();
            label4 = new Label();
            btnAgregar = new Button();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // BtnElegirCliente
            // 
            BtnElegirCliente.BackColor = Color.FromArgb(182, 207, 230);
            BtnElegirCliente.FlatStyle = FlatStyle.Flat;
            BtnElegirCliente.ForeColor = Color.FromArgb(182, 207, 230);
            BtnElegirCliente.Image = Properties.Resources.lupa2;
            BtnElegirCliente.Location = new Point(301, 171);
            BtnElegirCliente.Name = "BtnElegirCliente";
            BtnElegirCliente.Size = new Size(27, 32);
            BtnElegirCliente.TabIndex = 26;
            BtnElegirCliente.UseVisualStyleBackColor = false;
            BtnElegirCliente.Click += BtnElegirCliente_Click;
            // 
            // txtCompraId
            // 
            txtCompraId.BackColor = Color.FromArgb(182, 207, 250);
            txtCompraId.BorderStyle = BorderStyle.None;
            txtCompraId.Enabled = false;
            txtCompraId.Location = new Point(158, 174);
            txtCompraId.Name = "txtCompraId";
            txtCompraId.Size = new Size(126, 20);
            txtCompraId.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 174);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 24;
            label1.Text = "Compra ID:";
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(207, 226, 243);
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(903, 125);
            panelPrincipal.TabIndex = 23;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(407, 42);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(114, 39);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Pagos";
            // 
            // txtMonto
            // 
            txtMonto.BackColor = Color.FromArgb(182, 207, 250);
            txtMonto.BorderStyle = BorderStyle.None;
            txtMonto.Enabled = false;
            txtMonto.Location = new Point(527, 174);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(126, 20);
            txtMonto.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(465, 174);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 27;
            label2.Text = "Monto:";
            // 
            // txtObservaciones
            // 
            txtObservaciones.BackColor = Color.FromArgb(182, 207, 250);
            txtObservaciones.BorderStyle = BorderStyle.None;
            txtObservaciones.Enabled = false;
            txtObservaciones.Location = new Point(524, 254);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(126, 20);
            txtObservaciones.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 254);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 29;
            label3.Text = "Observaciones:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(182, 207, 230);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(182, 207, 230);
            button1.Image = Properties.Resources.lupa2;
            button1.Location = new Point(301, 251);
            button1.Name = "button1";
            button1.Size = new Size(27, 32);
            button1.TabIndex = 33;
            button1.UseVisualStyleBackColor = false;
            // 
            // txtBancoId
            // 
            txtBancoId.BackColor = Color.FromArgb(182, 207, 250);
            txtBancoId.BorderStyle = BorderStyle.None;
            txtBancoId.Enabled = false;
            txtBancoId.Location = new Point(158, 254);
            txtBancoId.Name = "txtBancoId";
            txtBancoId.Size = new Size(126, 20);
            txtBancoId.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 254);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 31;
            label4.Text = "Cuenta De Banco:";
            label4.Click += label4_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(207, 226, 243);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Image = Properties.Resources.add__1_;
            btnAgregar.Location = new Point(413, 338);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 59);
            btnAgregar.TabIndex = 38;
            btnAgregar.Text = " Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormPagos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(903, 450);
            Controls.Add(btnAgregar);
            Controls.Add(button1);
            Controls.Add(txtBancoId);
            Controls.Add(label4);
            Controls.Add(txtObservaciones);
            Controls.Add(label3);
            Controls.Add(txtMonto);
            Controls.Add(label2);
            Controls.Add(BtnElegirCliente);
            Controls.Add(txtCompraId);
            Controls.Add(label1);
            Controls.Add(panelPrincipal);
            Name = "FormPagos";
            Text = "FormPagos";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnElegirCliente;
        private TextBox txtCompraId;
        private Label label1;
        private Panel panelPrincipal;
        private Label labelPrincipal;
        private TextBox txtMonto;
        private Label label2;
        private TextBox txtObservaciones;
        private Label label3;
        private Button button1;
        private TextBox txtBancoId;
        private Label label4;
        private Button btnAgregar;
    }
}