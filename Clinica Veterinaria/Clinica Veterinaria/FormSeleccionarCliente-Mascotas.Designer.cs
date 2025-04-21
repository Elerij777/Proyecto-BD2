namespace Clinica_Veterinaria
{
    partial class FormSeleccionarCliente_Mascotas
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
            dgvCliente = new DataGridView();
            BtnAcceptar = new Button();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = SystemColors.ActiveCaption;
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(800, 125);
            panelPrincipal.TabIndex = 7;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(224, 41);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(376, 43);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Seleccionar Cliente";
            // 
            // dgvCliente
            // 
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Location = new Point(39, 148);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowHeadersWidth = 51;
            dgvCliente.Size = new Size(704, 244);
            dgvCliente.TabIndex = 9;
            // 
            // BtnAcceptar
            // 
            BtnAcceptar.Location = new Point(343, 409);
            BtnAcceptar.Name = "BtnAcceptar";
            BtnAcceptar.Size = new Size(94, 29);
            BtnAcceptar.TabIndex = 10;
            BtnAcceptar.Text = "Confirmar";
            BtnAcceptar.UseVisualStyleBackColor = true;
            BtnAcceptar.Click += BtnAceptar_Click;
            // 
            // FormSeleccionarCliente_Mascotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnAcceptar);
            Controls.Add(dgvCliente);
            Controls.Add(panelPrincipal);
            Name = "FormSeleccionarCliente_Mascotas";
            Text = "FormSeleccionarCliente_Mascotas";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelPrincipal;
        private DataGridView dgvCliente;
        private Button BtnAcceptar;
    }
}