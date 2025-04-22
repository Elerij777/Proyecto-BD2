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
            txtCajaAnterior = new TextBox();
            label11 = new Label();
            txtDeposito = new TextBox();
            label12 = new Label();
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
            panelPrincipal.Size = new Size(833, 94);
            panelPrincipal.TabIndex = 10;
            // 
            // labelPrincipal
            // 
            labelPrincipal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(354, 34);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(101, 31);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Arqueo";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(207, 226, 243);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnGuardar.Location = new Point(379, 356);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 44);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 185);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 12;
            label1.Text = "Total en fectivo:";
            // 
            // txtEfectivo
            // 
            txtEfectivo.BackColor = Color.FromArgb(182, 207, 250);
            txtEfectivo.BorderStyle = BorderStyle.None;
            txtEfectivo.Location = new Point(157, 185);
            txtEfectivo.Margin = new Padding(3, 2, 3, 2);
            txtEfectivo.Name = "txtEfectivo";
            txtEfectivo.ReadOnly = true;
            txtEfectivo.Size = new Size(110, 16);
            txtEfectivo.TabIndex = 13;
            // 
            // txtCheques
            // 
            txtCheques.BackColor = Color.FromArgb(182, 207, 250);
            txtCheques.BorderStyle = BorderStyle.None;
            txtCheques.Location = new Point(428, 185);
            txtCheques.Margin = new Padding(3, 2, 3, 2);
            txtCheques.Name = "txtCheques";
            txtCheques.ReadOnly = true;
            txtCheques.Size = new Size(110, 16);
            txtCheques.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 185);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 14;
            label2.Text = "Total en cheques:";
            // 
            // txtTarjeta
            // 
            txtTarjeta.BackColor = Color.FromArgb(182, 207, 250);
            txtTarjeta.BorderStyle = BorderStyle.None;
            txtTarjeta.Location = new Point(665, 184);
            txtTarjeta.Margin = new Padding(3, 2, 3, 2);
            txtTarjeta.Name = "txtTarjeta";
            txtTarjeta.ReadOnly = true;
            txtTarjeta.Size = new Size(110, 16);
            txtTarjeta.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(571, 185);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 16;
            label3.Text = "Total en Tarjeta:";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.FromArgb(182, 207, 250);
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Location = new Point(157, 152);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(110, 16);
            txtTotal.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 152);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 18;
            label4.Text = "Total del dia:";
            // 
            // txtCajaTarjeta
            // 
            txtCajaTarjeta.BackColor = Color.FromArgb(182, 207, 250);
            txtCajaTarjeta.BorderStyle = BorderStyle.None;
            txtCajaTarjeta.Location = new Point(665, 258);
            txtCajaTarjeta.Margin = new Padding(3, 2, 3, 2);
            txtCajaTarjeta.Name = "txtCajaTarjeta";
            txtCajaTarjeta.Size = new Size(110, 16);
            txtCajaTarjeta.TabIndex = 25;
            txtCajaTarjeta.Text = "0.00";
            txtCajaTarjeta.TextChanged += txtCajaTarjeta_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(571, 259);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 24;
            label5.Text = "Total en Tarjeta:";
            // 
            // txtCajaCheques
            // 
            txtCajaCheques.BackColor = Color.FromArgb(182, 207, 250);
            txtCajaCheques.BorderStyle = BorderStyle.None;
            txtCajaCheques.Location = new Point(428, 259);
            txtCajaCheques.Margin = new Padding(3, 2, 3, 2);
            txtCajaCheques.Name = "txtCajaCheques";
            txtCajaCheques.Size = new Size(110, 16);
            txtCajaCheques.TabIndex = 23;
            txtCajaCheques.Text = "0.00";
            txtCajaCheques.TextChanged += txtCajaCheques_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(316, 259);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 22;
            label6.Text = "Total en cheques:";
            // 
            // txtCajaEfectivo
            // 
            txtCajaEfectivo.BackColor = Color.FromArgb(182, 207, 250);
            txtCajaEfectivo.BorderStyle = BorderStyle.None;
            txtCajaEfectivo.Location = new Point(148, 262);
            txtCajaEfectivo.Margin = new Padding(3, 2, 3, 2);
            txtCajaEfectivo.Name = "txtCajaEfectivo";
            txtCajaEfectivo.Size = new Size(110, 16);
            txtCajaEfectivo.TabIndex = 21;
            txtCajaEfectivo.Text = "0.00";
            txtCajaEfectivo.TextChanged += txtCajaEfectivo_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 262);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 20;
            label7.Text = "Total en fectivo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(331, 96);
            label8.Name = "label8";
            label8.Size = new Size(173, 31);
            label8.TabIndex = 1;
            label8.Text = "Total Teorico";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(331, 208);
            label9.Name = "label9";
            label9.Size = new Size(169, 31);
            label9.TabIndex = 26;
            label9.Text = "Total en caja";
            // 
            // txtcajaTotal
            // 
            txtcajaTotal.BackColor = Color.FromArgb(182, 207, 250);
            txtcajaTotal.BorderStyle = BorderStyle.None;
            txtcajaTotal.Location = new Point(148, 300);
            txtcajaTotal.Margin = new Padding(3, 2, 3, 2);
            txtcajaTotal.Name = "txtcajaTotal";
            txtcajaTotal.ReadOnly = true;
            txtcajaTotal.Size = new Size(110, 16);
            txtcajaTotal.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(52, 300);
            label10.Name = "label10";
            label10.Size = new Size(73, 15);
            label10.TabIndex = 27;
            label10.Text = "Total del dia:";
            // 
            // txtCajaAnterior
            // 
            txtCajaAnterior.BackColor = Color.FromArgb(182, 207, 250);
            txtCajaAnterior.BorderStyle = BorderStyle.None;
            txtCajaAnterior.Location = new Point(428, 152);
            txtCajaAnterior.Margin = new Padding(3, 2, 3, 2);
            txtCajaAnterior.Name = "txtCajaAnterior";
            txtCajaAnterior.ReadOnly = true;
            txtCajaAnterior.Size = new Size(110, 16);
            txtCajaAnterior.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(316, 152);
            label11.Name = "label11";
            label11.Size = new Size(85, 15);
            label11.TabIndex = 29;
            label11.Text = "Dinero en caja:";
            // 
            // txtDeposito
            // 
            txtDeposito.BackColor = Color.FromArgb(182, 207, 250);
            txtDeposito.BorderStyle = BorderStyle.None;
            txtDeposito.Location = new Point(428, 303);
            txtDeposito.Margin = new Padding(3, 2, 3, 2);
            txtDeposito.Name = "txtDeposito";
            txtDeposito.Size = new Size(110, 16);
            txtDeposito.TabIndex = 32;
            txtDeposito.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(316, 303);
            label12.Name = "label12";
            label12.Size = new Size(106, 15);
            label12.TabIndex = 31;
            label12.Text = "Dinero a depositar:";
            // 
            // FormArqueo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(833, 410);
            Controls.Add(txtDeposito);
            Controls.Add(label12);
            Controls.Add(txtCajaAnterior);
            Controls.Add(label11);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormArqueo";
            Text = "FormArqueo";
            Load += FormArqueo_Load;
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
        private TextBox txtCajaAnterior;
        private Label label11;
        private TextBox txtDeposito;
        private Label label12;
    }
}