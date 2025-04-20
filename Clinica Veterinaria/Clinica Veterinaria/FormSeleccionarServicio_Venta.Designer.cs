namespace Clinica_Veterinaria
{
    partial class FormSeleccionarServicio_Venta
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
            dgvProducto = new DataGridView();
            BtnAcceptar = new Button();
            panelPrincipal = new Panel();
            labelPrincipal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProducto
            // 
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Location = new Point(44, 154);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.RowHeadersWidth = 51;
            dgvProducto.Size = new Size(704, 244);
            dgvProducto.TabIndex = 14;
            // 
            // BtnAcceptar
            // 
            BtnAcceptar.Location = new Point(369, 427);
            BtnAcceptar.Name = "BtnAcceptar";
            BtnAcceptar.Size = new Size(94, 29);
            BtnAcceptar.TabIndex = 13;
            BtnAcceptar.Text = "Confirmar";
            BtnAcceptar.UseVisualStyleBackColor = true;
            BtnAcceptar.Click += BtnAcceptar_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = SystemColors.ActiveCaption;
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(809, 125);
            panelPrincipal.TabIndex = 12;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(224, 41);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(395, 43);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Seleccionar Servicio";
            // 
            // FormSeleccionarServicio_Venta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 477);
            Controls.Add(dgvProducto);
            Controls.Add(BtnAcceptar);
            Controls.Add(panelPrincipal);
            Name = "FormSeleccionarServicio_Venta";
            Text = "FormSeleccionarServicio_Venta";
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProducto;
        private Button BtnAcceptar;
        private Panel panelPrincipal;
        private Label labelPrincipal;
    }
}