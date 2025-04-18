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
            lupa = new Label();
            pictureBox1 = new PictureBox();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panelPrincipal.Size = new Size(700, 94);
            panelPrincipal.TabIndex = 3;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(267, 26);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(131, 31);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Mascotas";
            // 
            // dgvMascotas
            // 
            dgvMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMascotas.Location = new Point(10, 146);
            dgvMascotas.Margin = new Padding(3, 2, 3, 2);
            dgvMascotas.Name = "dgvMascotas";
            dgvMascotas.RowHeadersWidth = 51;
            dgvMascotas.Size = new Size(676, 174);
            dgvMascotas.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.5F);
            label2.Location = new Point(386, 109);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 6;
            label2.Text = "Buscar";
            // 
            // txtBuscador
            // 
            txtBuscador.BackColor = Color.FromArgb(182, 207, 250);
            txtBuscador.BorderStyle = BorderStyle.None;
            txtBuscador.Font = new Font("Segoe UI", 13.5F);
            txtBuscador.Location = new Point(452, 109);
            txtBuscador.Margin = new Padding(0);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(211, 24);
            txtBuscador.TabIndex = 8;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // txtPdf
            // 
            txtPdf.BackColor = Color.FromArgb(207, 226, 243);
            txtPdf.FlatStyle = FlatStyle.Flat;
            txtPdf.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPdf.Location = new Point(564, 324);
            txtPdf.Margin = new Padding(3, 2, 3, 2);
            txtPdf.Name = "txtPdf";
            txtPdf.Size = new Size(122, 44);
            txtPdf.TabIndex = 9;
            txtPdf.Text = "Generar DNI";
            txtPdf.UseVisualStyleBackColor = false;
            txtPdf.Click += txtPdf_Click;
            // 
            // lupa
            // 
            lupa.AutoSize = true;
            lupa.Image = Properties.Resources.lupa2;
            lupa.Location = new Point(663, 109);
            lupa.Name = "lupa";
            lupa.Size = new Size(0, 15);
            lupa.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(182, 207, 250);
            pictureBox1.BackgroundImage = Properties.Resources.lupa2;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(662, 109);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // FormVerMascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(700, 369);
            Controls.Add(pictureBox1);
            Controls.Add(lupa);
            Controls.Add(txtPdf);
            Controls.Add(txtBuscador);
            Controls.Add(label2);
            Controls.Add(dgvMascotas);
            Controls.Add(panelPrincipal);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormVerMascotas";
            Text = "Form4";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label lupa;
        private PictureBox pictureBox1;
    }
}