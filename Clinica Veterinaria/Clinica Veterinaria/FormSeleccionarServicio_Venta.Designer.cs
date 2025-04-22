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
            dgvProducto.Location = new Point(38, 116);
            dgvProducto.Margin = new Padding(3, 2, 3, 2);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.RowHeadersWidth = 51;
            dgvProducto.Size = new Size(616, 183);
            dgvProducto.TabIndex = 14;
            // 
            // BtnAcceptar
            // 
            BtnAcceptar.BackColor = Color.FromArgb(207, 226, 243);
            BtnAcceptar.FlatStyle = FlatStyle.Flat;
            BtnAcceptar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            BtnAcceptar.Location = new Point(305, 303);
            BtnAcceptar.Margin = new Padding(3, 2, 3, 2);
            BtnAcceptar.Name = "BtnAcceptar";
            BtnAcceptar.Size = new Size(100, 44);
            BtnAcceptar.TabIndex = 13;
            BtnAcceptar.Text = "Confirmar";
            BtnAcceptar.UseVisualStyleBackColor = false;
            BtnAcceptar.Click += BtnAcceptar_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(207, 226, 243);
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Margin = new Padding(3, 2, 3, 2);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(708, 94);
            panelPrincipal.TabIndex = 12;
            // 
            // labelPrincipal
            // 
            labelPrincipal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(196, 31);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(260, 31);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Seleccionar Servicio";
            // 
            // FormSeleccionarServicio_Venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(708, 358);
            Controls.Add(dgvProducto);
            Controls.Add(BtnAcceptar);
            Controls.Add(panelPrincipal);
            Margin = new Padding(3, 2, 3, 2);
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