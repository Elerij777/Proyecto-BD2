namespace Clinica_Veterinaria
{
    partial class FormProveedores
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
            dataGridView1 = new DataGridView();
            btnGuardar = new Button();
            label1 = new Label();
            txtBuscar = new TextBox();
            pictureBox1 = new PictureBox();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = SystemColors.ActiveCaption;
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Margin = new Padding(2);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(850, 93);
            panelPrincipal.TabIndex = 1;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(281, 29);
            labelPrincipal.Margin = new Padding(2, 0, 2, 0);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(257, 43);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Proveedores";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 174);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(780, 308);
            dataGridView1.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(207, 226, 243);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(657, 495);
            btnGuardar.Margin = new Padding(1);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(149, 59);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.5F);
            label1.Location = new Point(440, 119);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 31);
            label1.TabIndex = 9;
            label1.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(182, 207, 250);
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Font = new Font("Segoe UI", 13.5F);
            txtBuscar.Location = new Point(527, 120);
            txtBuscar.Margin = new Padding(0);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(241, 30);
            txtBuscar.TabIndex = 10;
            txtBuscar.TextChanged += txtBuscador_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(182, 207, 250);
            pictureBox1.BackgroundImage = Properties.Resources.lupa2;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(779, 120);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 32);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 564);
            Controls.Add(pictureBox1);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(dataGridView1);
            Controls.Add(panelPrincipal);
            Margin = new Padding(2);
            Name = "FormProveedores";
            Text = "FormProveedores";
            Load += FormProveedores_Load;
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelPrincipal;
        private DataGridView dataGridView1;
        private Button btnGuardar;
        private Label label1;
        private TextBox txtBuscar;
        private PictureBox pictureBox1;
    }
}