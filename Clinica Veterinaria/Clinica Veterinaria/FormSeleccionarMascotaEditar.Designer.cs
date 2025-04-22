namespace Clinica_Veterinaria
{
    partial class FormSeleccionarMascotaEditar
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
            panel1 = new Panel();
            label1 = new Label();
            labelPrincipal = new Label();
            label2 = new Label();
            txtBuscar = new TextBox();
            pictureBox1 = new PictureBox();
            dgvMascotas = new DataGridView();
            btnSeleccionar = new Button();
            panelPrincipal.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(207, 226, 243);
            panelPrincipal.Controls.Add(panel1);
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(824, 125);
            panelPrincipal.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(207, 226, 243);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 125);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(200, 53);
            label1.Name = "label1";
            label1.Size = new Size(333, 39);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar Mascota";
            // 
            // labelPrincipal
            // 
            labelPrincipal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(200, 53);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(333, 39);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Seleccionar Mascota";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.5F);
            label2.Location = new Point(337, 139);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 31);
            label2.TabIndex = 9;
            label2.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(182, 207, 250);
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Font = new Font("Segoe UI", 13.5F);
            txtBuscar.Location = new Point(422, 139);
            txtBuscar.Margin = new Padding(2, 3, 2, 3);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(224, 30);
            txtBuscar.TabIndex = 10;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(182, 207, 250);
            pictureBox1.BackgroundImage = Properties.Resources.lupa2;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(662, 137);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 32);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // dgvMascotas
            // 
            dgvMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMascotas.Location = new Point(41, 191);
            dgvMascotas.Name = "dgvMascotas";
            dgvMascotas.RowHeadersWidth = 51;
            dgvMascotas.Size = new Size(747, 237);
            dgvMascotas.TabIndex = 18;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.BackColor = Color.FromArgb(207, 226, 243);
            btnSeleccionar.FlatStyle = FlatStyle.Flat;
            btnSeleccionar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnSeleccionar.Location = new Point(674, 434);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(114, 59);
            btnSeleccionar.TabIndex = 19;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // FormSeleccionarMascotaEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 503);
            Controls.Add(btnSeleccionar);
            Controls.Add(dgvMascotas);
            Controls.Add(pictureBox1);
            Controls.Add(txtBuscar);
            Controls.Add(label2);
            Controls.Add(panelPrincipal);
            Name = "FormSeleccionarMascotaEditar";
            Text = "FormSeleccionarMascotaEditar";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelPrincipal;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtBuscar;
        private PictureBox pictureBox1;
        private DataGridView dgvMascotas;
        private Button btnSeleccionar;
    }
}