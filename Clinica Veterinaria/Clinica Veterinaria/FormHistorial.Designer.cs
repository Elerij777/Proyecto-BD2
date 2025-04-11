namespace Clinica_Veterinaria
{
    partial class FormHistorial
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
            dataGridView1 = new DataGridView();
            panelPrincipal = new Panel();
            labelPrincipal = new Label();
            txtBuscar = new TextBox();
            label1 = new Label();
            chkClinica = new CheckBox();
            chkGrooming = new CheckBox();
            chkHospedaje = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 262);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1018, 299);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(207, 226, 243);
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Margin = new Padding(4, 3, 4, 3);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1077, 97);
            panelPrincipal.TabIndex = 3;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(408, 30);
            labelPrincipal.Margin = new Padding(4, 0, 4, 0);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(165, 46);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Historial";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(170, 129);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(440, 31);
            txtBuscar.TabIndex = 4;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 129);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 5;
            label1.Text = "Buscar";
            // 
            // chkClinica
            // 
            chkClinica.AutoSize = true;
            chkClinica.Location = new Point(744, 111);
            chkClinica.Name = "chkClinica";
            chkClinica.Size = new Size(88, 29);
            chkClinica.TabIndex = 6;
            chkClinica.Text = "Clinica";
            chkClinica.UseVisualStyleBackColor = true;
            chkClinica.CheckedChanged += chkClinica_CheckedChanged;
            // 
            // chkGrooming
            // 
            chkGrooming.AutoSize = true;
            chkGrooming.Location = new Point(744, 147);
            chkGrooming.Name = "chkGrooming";
            chkGrooming.Size = new Size(119, 29);
            chkGrooming.TabIndex = 7;
            chkGrooming.Text = "Grooming";
            chkGrooming.UseVisualStyleBackColor = true;
            chkGrooming.CheckedChanged += chkGrooming_CheckedChanged;
            // 
            // chkHospedaje
            // 
            chkHospedaje.AutoSize = true;
            chkHospedaje.Location = new Point(745, 183);
            chkHospedaje.Name = "chkHospedaje";
            chkHospedaje.Size = new Size(123, 29);
            chkHospedaje.TabIndex = 8;
            chkHospedaje.Text = "Hospedaje";
            chkHospedaje.UseVisualStyleBackColor = true;
            chkHospedaje.CheckedChanged += chkHospedaje_CheckedChanged;
            // 
            // FormHistorial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 562);
            Controls.Add(chkHospedaje);
            Controls.Add(chkGrooming);
            Controls.Add(chkClinica);
            Controls.Add(label1);
            Controls.Add(txtBuscar);
            Controls.Add(panelPrincipal);
            Controls.Add(dataGridView1);
            Name = "FormHistorial";
            Text = "FormHistorial";
            Load += FormHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panelPrincipal;
        private Label labelPrincipal;
        private TextBox txtBuscar;
        private Label label1;
        private CheckBox chkClinica;
        private CheckBox chkGrooming;
        private CheckBox chkHospedaje;
    }
}