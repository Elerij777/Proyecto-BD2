namespace Clinica_Veterinaria
{
    partial class FormServicios
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
            btnSalvar = new Button();
            dgvServicios = new DataGridView();
            panelPrincipal = new Panel();
            labelPrincipal = new Label();
            label2 = new Label();
            txtBuscador = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(664, 505);
            btnSalvar.Margin = new Padding(2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(136, 65);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Guardar Cambios";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dgvServicios
            // 
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(49, 195);
            dgvServicios.Margin = new Padding(2);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.RowHeadersWidth = 62;
            dgvServicios.Size = new Size(751, 306);
            dgvServicios.TabIndex = 2;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(207, 226, 243);
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(882, 119);
            panelPrincipal.TabIndex = 15;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(307, 36);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(156, 39);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Servicios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.5F);
            label2.Location = new Point(452, 146);
            label2.Name = "label2";
            label2.Size = new Size(81, 31);
            label2.TabIndex = 17;
            label2.Text = "Buscar";
            // 
            // txtBuscador
            // 
            txtBuscador.BackColor = Color.FromArgb(182, 207, 250);
            txtBuscador.BorderStyle = BorderStyle.None;
            txtBuscador.Font = new Font("Segoe UI", 13.5F);
            txtBuscador.Location = new Point(539, 147);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(230, 30);
            txtBuscador.TabIndex = 18;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(182, 207, 250);
            pictureBox1.BackgroundImage = Properties.Resources.lupa2;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(772, 147);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 32);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // FormServicios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 581);
            Controls.Add(pictureBox1);
            Controls.Add(txtBuscador);
            Controls.Add(label2);
            Controls.Add(panelPrincipal);
            Controls.Add(btnSalvar);
            Controls.Add(dgvServicios);
            Margin = new Padding(2);
            Name = "FormServicios";
            Text = "FormServicios";
            Load += FormServicios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private DataGridView dgvServicios;
        private Panel panelPrincipal;
        private Label labelPrincipal;
        private Label label2;
        private TextBox txtBuscador;
        private PictureBox pictureBox1;
    }
}