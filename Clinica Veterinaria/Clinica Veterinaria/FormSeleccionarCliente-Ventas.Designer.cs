namespace Clinica_Veterinaria
{
    partial class FormSeleccionarCliente_Ventas
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
            BtnAcceptar = new Button();
            dgvCliente = new DataGridView();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
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
            panelPrincipal.Size = new Size(743, 94);
            panelPrincipal.TabIndex = 6;
            panelPrincipal.Paint += panelPrincipal_Paint;
            // 
            // labelPrincipal
            // 
            labelPrincipal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(196, 31);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(248, 31);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Seleccionar Cliente";
            // 
            // BtnAcceptar
            // 
            BtnAcceptar.BackColor = Color.FromArgb(207, 226, 243);
            BtnAcceptar.FlatStyle = FlatStyle.Flat;
            BtnAcceptar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            BtnAcceptar.Location = new Point(344, 308);
            BtnAcceptar.Margin = new Padding(3, 2, 3, 2);
            BtnAcceptar.Name = "BtnAcceptar";
            BtnAcceptar.Size = new Size(100, 44);
            BtnAcceptar.TabIndex = 7;
            BtnAcceptar.Text = "Confirmar";
            BtnAcceptar.UseVisualStyleBackColor = false;
            BtnAcceptar.Click += BtnAcceptar_Click;
            // 
            // dgvCliente
            // 
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Location = new Point(71, 121);
            dgvCliente.Margin = new Padding(3, 2, 3, 2);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowHeadersWidth = 51;
            dgvCliente.Size = new Size(616, 183);
            dgvCliente.TabIndex = 8;
            // 
            // FormSeleccionarCliente_Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(743, 356);
            Controls.Add(dgvCliente);
            Controls.Add(BtnAcceptar);
            Controls.Add(panelPrincipal);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormSeleccionarCliente_Ventas";
            Text = "FormSeleccionarCliente_Ventas";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelPrincipal;
        private Button BtnAcceptar;
        private DataGridView dgvCliente;
    }
}