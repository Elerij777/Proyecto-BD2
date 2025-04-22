namespace Clinica_Veterinaria
{
    partial class FormSeleccionarProveedor
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
            dgvProveedor = new DataGridView();
            txtBuscar = new TextBox();
            btn_Seleccionar = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
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
            panelPrincipal.TabIndex = 7;
            // 
            // labelPrincipal
            // 
            labelPrincipal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(175, 31);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(288, 31);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Seleccionar Proveedor";
            // 
            // dgvProveedor
            // 
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.Location = new Point(78, 178);
            dgvProveedor.Margin = new Padding(2, 2, 2, 2);
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.RowHeadersWidth = 62;
            dgvProveedor.Size = new Size(561, 128);
            dgvProveedor.TabIndex = 8;
            dgvProveedor.CellContentClick += dgvProveedor_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(182, 207, 250);
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Font = new Font("Segoe UI", 13.5F);
            txtBuscar.Location = new Point(242, 135);
            txtBuscar.Margin = new Padding(2, 2, 2, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(221, 24);
            txtBuscar.TabIndex = 9;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btn_Seleccionar
            // 
            btn_Seleccionar.BackColor = Color.FromArgb(207, 226, 243);
            btn_Seleccionar.FlatStyle = FlatStyle.Flat;
            btn_Seleccionar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btn_Seleccionar.Location = new Point(539, 312);
            btn_Seleccionar.Margin = new Padding(2, 2, 2, 2);
            btn_Seleccionar.Name = "btn_Seleccionar";
            btn_Seleccionar.Size = new Size(100, 44);
            btn_Seleccionar.TabIndex = 10;
            btn_Seleccionar.Text = "Seleccionar";
            btn_Seleccionar.UseVisualStyleBackColor = false;
            btn_Seleccionar.Click += btn_Seleccionar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.5F);
            label1.Location = new Point(175, 134);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 11;
            label1.Text = "Buscar";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(182, 207, 250);
            pictureBox1.BackgroundImage = Properties.Resources.lupa2;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(465, 135);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // FormSeleccionarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(700, 367);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btn_Seleccionar);
            Controls.Add(txtBuscar);
            Controls.Add(dgvProveedor);
            Controls.Add(panelPrincipal);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormSeleccionarProveedor";
            Text = "FormSeleccionarProveedor";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelPrincipal;
        private DataGridView dgvProveedor;
        private TextBox txtBuscar;
        private Button btn_Seleccionar;
        private Label label1;
        private PictureBox pictureBox1;
    }
}