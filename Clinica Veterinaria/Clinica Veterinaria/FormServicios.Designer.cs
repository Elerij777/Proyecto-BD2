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
            btnSalvar.BackColor = Color.FromArgb(207, 226, 243);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(557, 324);
            btnSalvar.Margin = new Padding(2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(129, 44);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Guardar Cambios";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dgvServicios
            // 
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(10, 146);
            dgvServicios.Margin = new Padding(2);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.RowHeadersWidth = 62;
            dgvServicios.Size = new Size(676, 174);
            dgvServicios.TabIndex = 2;
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
            panelPrincipal.TabIndex = 15;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(269, 27);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(125, 31);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Servicios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.5F);
            label2.Location = new Point(386, 109);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 17;
            label2.Text = "Buscar";
            // 
            // txtBuscador
            // 
            txtBuscador.BackColor = Color.FromArgb(182, 207, 250);
            txtBuscador.BorderStyle = BorderStyle.None;
            txtBuscador.Font = new Font("Segoe UI", 13.5F);
            txtBuscador.Location = new Point(462, 109);
            txtBuscador.Margin = new Padding(0);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(201, 24);
            txtBuscador.TabIndex = 18;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(182, 207, 250);
            pictureBox1.BackgroundImage = Properties.Resources.lupa2;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(663, 109);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // FormServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(700, 369);
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