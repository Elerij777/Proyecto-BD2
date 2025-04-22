namespace Clinica_Veterinaria
{
    partial class FormEmpleados
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
            dgvEmpleados = new DataGridView();
            pictureBox1 = new PictureBox();
            panelPrincipal = new Panel();
            labelPrincipal = new Label();
            txtBuscador = new TextBox();
            label2 = new Label();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(22, 145);
            dgvEmpleados.Margin = new Padding(2);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 62;
            dgvEmpleados.Size = new Size(657, 206);
            dgvEmpleados.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(182, 207, 250);
            pictureBox1.BackgroundImage = Properties.Resources.lupa2;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(631, 97);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(207, 226, 243);
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Margin = new Padding(3, 2, 3, 2);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(736, 89);
            panelPrincipal.TabIndex = 14;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(269, 27);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(149, 31);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Empleados";
            // 
            // txtBuscador
            // 
            txtBuscador.BackColor = Color.FromArgb(182, 207, 250);
            txtBuscador.BorderStyle = BorderStyle.None;
            txtBuscador.Font = new Font("Segoe UI", 13.5F);
            txtBuscador.Location = new Point(430, 98);
            txtBuscador.Margin = new Padding(0);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(201, 24);
            txtBuscador.TabIndex = 15;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.5F);
            label2.Location = new Point(364, 97);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 16;
            label2.Text = "Buscar";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(207, 226, 243);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnGuardar.Location = new Point(557, 364);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(122, 44);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar cambios";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btn_Salvar_Click;
            // 
            // FormEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(736, 419);
            Controls.Add(btnGuardar);
            Controls.Add(label2);
            Controls.Add(txtBuscador);
            Controls.Add(panelPrincipal);
            Controls.Add(pictureBox1);
            Controls.Add(dgvEmpleados);
            Margin = new Padding(2);
            Name = "FormEmpleados";
            Text = "FormEmpleados";
            Load += FormEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmpleados;
        private PictureBox pictureBox1;
        private Panel panelPrincipal;
        private Label labelPrincipal;
        private TextBox txtBuscador;
        private Label label2;
        private Button btnGuardar;
    }
}