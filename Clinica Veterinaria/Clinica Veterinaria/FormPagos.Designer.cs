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
            txtCliente = new TextBox();
            label1 = new Label();
            panelPrincipal = new Panel();
            labelPrincipal = new Label();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // BtnElegirCliente
            // 
            BtnElegirCliente.BackColor = Color.FromArgb(182, 207, 230);
            BtnElegirCliente.FlatStyle = FlatStyle.Flat;
            BtnElegirCliente.ForeColor = Color.FromArgb(182, 207, 230);
            BtnElegirCliente.Image = Properties.Resources.lupa2;
            BtnElegirCliente.Location = new Point(260, 171);
            BtnElegirCliente.Name = "BtnElegirCliente";
            BtnElegirCliente.Size = new Size(27, 32);
            BtnElegirCliente.TabIndex = 26;
            BtnElegirCliente.UseVisualStyleBackColor = false;
            // 
            // txtCliente
            // 
            txtCliente.BackColor = Color.FromArgb(182, 207, 250);
            txtCliente.BorderStyle = BorderStyle.None;
            txtCliente.Enabled = false;
            txtCliente.Location = new Point(117, 176);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(126, 20);
            txtCliente.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 179);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 24;
            label1.Text = "Compra:";
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
            labelPrincipal.Location = new Point(381, 31);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(114, 39);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Pagos";
            // 
            // FormPagos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(903, 450);
            Controls.Add(BtnElegirCliente);
            Controls.Add(txtCliente);
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
        private TextBox txtCliente;
        private Label label1;
        private Panel panelPrincipal;
        private Label labelPrincipal;
    }
}