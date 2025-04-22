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
            dgvEmpleados.Location = new Point(25, 193);
            dgvEmpleados.Margin = new Padding(2);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 62;
            dgvEmpleados.Size = new Size(751, 275);
            dgvEmpleados.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(182, 207, 250);
            pictureBox1.BackgroundImage = Properties.Resources.lupa2;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(725, 133);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 27);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(207, 226, 243);
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(841, 119);
            panelPrincipal.TabIndex = 14;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(307, 36);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(188, 39);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Empleados";
            // 
            // txtBuscador
            // 
            txtBuscador.BackColor = Color.FromArgb(182, 207, 250);
            txtBuscador.BorderStyle = BorderStyle.None;
            txtBuscador.Font = new Font("Segoe UI", 13.5F);
            txtBuscador.Location = new Point(492, 130);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(230, 30);
            txtBuscador.TabIndex = 15;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.5F);
            label2.Location = new Point(405, 130);
            label2.Name = "label2";
            label2.Size = new Size(81, 31);
            label2.TabIndex = 16;
            label2.Text = "Buscar";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(207, 226, 243);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnGuardar.Location = new Point(615, 488);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(139, 59);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar cambios";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btn_Salvar_Click;
            // 
            // FormEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 559);
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