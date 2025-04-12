namespace Clinica_Veterinaria
{
    partial class FormVerMascotas
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
            dgvMascotas = new DataGridView();
            label2 = new Label();
            txtBuscador = new TextBox();
            txtPdf = new Button();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).BeginInit();
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
            panelPrincipal.TabIndex = 3;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(305, 34);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(192, 43);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Mascotas";
            // 
            // dgvMascotas
            // 
            dgvMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMascotas.Location = new Point(12, 195);
            dgvMascotas.Name = "dgvMascotas";
            dgvMascotas.RowHeadersWidth = 51;
            dgvMascotas.Size = new Size(772, 232);
            dgvMascotas.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(462, 150);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 6;
            label2.Text = "Buscar";
            // 
            // txtBuscador
            // 
            txtBuscador.Location = new Point(520, 143);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(264, 27);
            txtBuscador.TabIndex = 8;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // txtPdf
            // 
            txtPdf.Location = new Point(557, 437);
            txtPdf.Name = "txtPdf";
            txtPdf.Size = new Size(140, 37);
            txtPdf.TabIndex = 9;
            txtPdf.Text = "Generar DNI";
            txtPdf.UseVisualStyleBackColor = true;
            txtPdf.Click += txtPdf_Click;
            // 
            // FormVerMascotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(txtPdf);
            Controls.Add(txtBuscador);
            Controls.Add(label2);
            Controls.Add(dgvMascotas);
            Controls.Add(panelPrincipal);
            Name = "FormVerMascotas";
            Text = "Form4";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelPrincipal;
        private DataGridView dgvMascotas;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox txtBuscador;
        private Button txtPdf;
    }
}