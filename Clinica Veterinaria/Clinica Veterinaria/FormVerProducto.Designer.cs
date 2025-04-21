namespace Clinica_Veterinaria
{
    partial class FormVerProducto
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
            txtBuscador = new TextBox();
            label1 = new Label();
            btnImprimir = new Button();
            btnGuardar = new Button();
            pictureBox1 = new PictureBox();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(207, 226, 243);
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
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(305, 35);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(170, 39);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Productos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 195);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(773, 232);
            dataGridView1.TabIndex = 4;
            // 
            // txtBuscador
            // 
            txtBuscador.BackColor = Color.FromArgb(182, 207, 250);
            txtBuscador.BorderStyle = BorderStyle.None;
            txtBuscador.Font = new Font("Segoe UI", 13.5F);
            txtBuscador.Location = new Point(517, 145);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(241, 30);
            txtBuscador.TabIndex = 5;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.5F);
            label1.Location = new Point(441, 145);
            label1.Name = "label1";
            label1.Size = new Size(81, 31);
            label1.TabIndex = 6;
            label1.Text = "Buscar";
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(207, 226, 243);
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnImprimir.Location = new Point(645, 432);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(139, 59);
            btnImprimir.TabIndex = 7;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(207, 226, 243);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnGuardar.Location = new Point(498, 432);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(139, 59);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar cambios";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(182, 207, 250);
            pictureBox1.BackgroundImage = Properties.Resources.lupa2;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(757, 145);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 32);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // FormVerProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(800, 492);
            Controls.Add(pictureBox1);
            Controls.Add(btnGuardar);
            Controls.Add(btnImprimir);
            Controls.Add(label1);
            Controls.Add(txtBuscador);
            Controls.Add(dataGridView1);
            Controls.Add(panelPrincipal);
            Name = "FormVerProducto";
            Text = "FormVerProducto";
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
        private TextBox txtBuscador;
        private Label label1;
        private Button btnImprimir;
        private Button btnGuardar;
        private PictureBox pictureBox1;
    }
}