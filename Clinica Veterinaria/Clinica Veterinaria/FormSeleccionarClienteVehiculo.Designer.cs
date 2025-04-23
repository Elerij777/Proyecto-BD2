namespace Clinica_Veterinaria
{
    partial class FormSeleccionarClienteVehiculo
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
            BtnAcceptar = new Button();
            dgvCliente = new DataGridView();
            panelPrincipal = new Panel();
            labelPrincipal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // BtnAcceptar
            // 
            BtnAcceptar.FlatStyle = FlatStyle.Flat;
            BtnAcceptar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            BtnAcceptar.Location = new Point(344, 394);
            BtnAcceptar.Name = "BtnAcceptar";
            BtnAcceptar.Size = new Size(114, 59);
            BtnAcceptar.TabIndex = 13;
            BtnAcceptar.Text = "Confirmar";
            BtnAcceptar.UseVisualStyleBackColor = true;
            BtnAcceptar.Click += BtnAcceptar_Click;
            // 
            // dgvCliente
            // 
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Location = new Point(39, 145);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowHeadersWidth = 51;
            dgvCliente.Size = new Size(704, 244);
            dgvCliente.TabIndex = 12;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(207, 226, 243);
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(811, 125);
            panelPrincipal.TabIndex = 11;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(224, 41);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(312, 39);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Seleccionar Cliente";
            // 
            // FormSeleccionarClienteVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(811, 476);
            Controls.Add(BtnAcceptar);
            Controls.Add(dgvCliente);
            Controls.Add(panelPrincipal);
            Name = "FormSeleccionarClienteVehiculo";
            Text = "FormSeleccionarClienteVehiculo";
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAcceptar;
        private DataGridView dgvCliente;
        private Panel panelPrincipal;
        private Label labelPrincipal;
    }
}