namespace Clinica_Veterinaria
{
    partial class FormArqueo
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
            btnGuardar = new Button();
            label1 = new Label();
            txtEfectivo = new TextBox();
            txtCheques = new TextBox();
            label2 = new Label();
            txtTarjeta = new TextBox();
            label3 = new Label();
            txtTotal = new TextBox();
            label4 = new Label();
            txtCajaTarjeta = new TextBox();
            label5 = new Label();
            txtCajaCheques = new TextBox();
            label6 = new Label();
            txtCajaEfectivo = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtcajaTotal = new TextBox();
            label10 = new Label();
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
            panelPrincipal.Size = new Size(943, 125);
            panelPrincipal.TabIndex = 10;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(405, 46);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(154, 43);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Arqueo";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(242, 449);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "button1";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 247);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 12;
            label1.Text = "Total en fectivo:";
            // 
            // txtEfectivo
            // 
            txtEfectivo.Location = new Point(179, 240);
            txtEfectivo.Name = "txtEfectivo";
            txtEfectivo.ReadOnly = true;
            txtEfectivo.Size = new Size(125, 27);
            txtEfectivo.TabIndex = 13;
            // 
            // txtCheques
            // 
            txtCheques.Location = new Point(490, 244);
            txtCheques.Name = "txtCheques";
            txtCheques.ReadOnly = true;
            txtCheques.Size = new Size(125, 27);
            txtCheques.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 247);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 14;
            label2.Text = "Total en cheques:";
            // 
            // txtTarjeta
            // 
            txtTarjeta.Location = new Point(782, 244);
            txtTarjeta.Name = "txtTarjeta";
            txtTarjeta.ReadOnly = true;
            txtTarjeta.Size = new Size(125, 27);
            txtTarjeta.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(653, 247);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 16;
            label3.Text = "Total en Tarjeta:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(490, 203);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(370, 210);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 18;
            label4.Text = "Total del dia:";
            // 
            // txtCajaTarjeta
            // 
            txtCajaTarjeta.Location = new Point(782, 342);
            txtCajaTarjeta.Name = "txtCajaTarjeta";
            txtCajaTarjeta.Size = new Size(125, 27);
            txtCajaTarjeta.TabIndex = 25;
            txtCajaTarjeta.TextChanged += txtCajaTarjeta_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(653, 345);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 24;
            label5.Text = "Total en Tarjeta:";
            // 
            // txtCajaCheques
            // 
            txtCajaCheques.Location = new Point(490, 342);
            txtCajaCheques.Name = "txtCajaCheques";
            txtCajaCheques.Size = new Size(125, 27);
            txtCajaCheques.TabIndex = 23;
            txtCajaCheques.TextChanged += txtCajaCheques_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(361, 345);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 22;
            label6.Text = "Total en cheques:";
            // 
            // txtCajaEfectivo
            // 
            txtCajaEfectivo.Location = new Point(179, 338);
            txtCajaEfectivo.Name = "txtCajaEfectivo";
            txtCajaEfectivo.Size = new Size(125, 27);
            txtCajaEfectivo.TabIndex = 21;
            txtCajaEfectivo.TextChanged += txtCajaEfectivo_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 345);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 20;
            label7.Text = "Total en fectivo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(323, 141);
            label8.Name = "label8";
            label8.Size = new Size(278, 43);
            label8.TabIndex = 1;
            label8.Text = "Total Teorico";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(323, 284);
            label9.Name = "label9";
            label9.Size = new Size(258, 43);
            label9.TabIndex = 26;
            label9.Text = "Total en caja";
            // 
            // txtcajaTotal
            // 
            txtcajaTotal.Location = new Point(481, 386);
            txtcajaTotal.Name = "txtcajaTotal";
            txtcajaTotal.ReadOnly = true;
            txtcajaTotal.Size = new Size(125, 27);
            txtcajaTotal.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(361, 393);
            label10.Name = "label10";
            label10.Size = new Size(95, 20);
            label10.TabIndex = 27;
            label10.Text = "Total del dia:";
            // 
            // FormArqueo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 507);
            Controls.Add(txtcajaTotal);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtCajaTarjeta);
            Controls.Add(label5);
            Controls.Add(txtCajaCheques);
            Controls.Add(label6);
            Controls.Add(txtCajaEfectivo);
            Controls.Add(label7);
            Controls.Add(txtTotal);
            Controls.Add(label4);
            Controls.Add(txtTarjeta);
            Controls.Add(label3);
            Controls.Add(txtCheques);
            Controls.Add(label2);
            Controls.Add(txtEfectivo);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(panelPrincipal);
            Name = "FormArqueo";
            Text = "FormArqueo";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelPrincipal;
        private Button btnGuardar;
        private Label label1;
        private TextBox txtEfectivo;
        private TextBox txtCheques;
        private Label label2;
        private TextBox txtTarjeta;
        private Label label3;
        private TextBox txtTotal;
        private Label label4;
        private TextBox txtCajaTarjeta;
        private Label label5;
        private TextBox txtCajaCheques;
        private Label label6;
        private TextBox txtCajaEfectivo;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtcajaTotal;
        private Label label10;
    }
}