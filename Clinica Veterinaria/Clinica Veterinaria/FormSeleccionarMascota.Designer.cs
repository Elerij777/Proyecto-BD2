namespace Clinica_Veterinaria
{
    partial class FormSeleccionarMascota
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
            btnSeleccionar = new Button();
            label1 = new Label();
            txtBuscar = new TextBox();
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
            panelPrincipal.TabIndex = 5;
            // 
            // labelPrincipal
            // 
            labelPrincipal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(175, 31);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(266, 31);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Seleccionar Mascota";
            // 
            // dgvMascotas
            // 
            dgvMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMascotas.Location = new Point(18, 141);
            dgvMascotas.Margin = new Padding(3, 2, 3, 2);
            dgvMascotas.Name = "dgvMascotas";
            dgvMascotas.RowHeadersWidth = 51;
            dgvMascotas.Size = new Size(654, 178);
            dgvMascotas.TabIndex = 6;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.BackColor = Color.FromArgb(207, 226, 243);
            btnSeleccionar.FlatStyle = FlatStyle.Flat;
            btnSeleccionar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnSeleccionar.Location = new Point(572, 323);
            btnSeleccionar.Margin = new Padding(3, 2, 3, 2);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(100, 44);
            btnSeleccionar.TabIndex = 7;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.5F);
            label1.Location = new Point(208, 106);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 8;
            label1.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(182, 207, 250);
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Font = new Font("Segoe UI", 13.5F);
            txtBuscar.Location = new Point(275, 106);
            txtBuscar.Margin = new Padding(2, 2, 2, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(196, 24);
            txtBuscar.TabIndex = 9;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(182, 207, 250);
            pictureBox1.BackgroundImage = Properties.Resources.lupa2;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(473, 106);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // FormSeleccionarMascota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(700, 367);
            Controls.Add(pictureBox1);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            Controls.Add(btnSeleccionar);
            Controls.Add(dgvMascotas);
            Controls.Add(panelPrincipal);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormSeleccionarMascota";
            Text = "FormSeleccionarMascota";
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
        private Button btnSeleccionar;
        private Label label1;
        private TextBox txtBuscar;
        private PictureBox pictureBox1;
    }
}