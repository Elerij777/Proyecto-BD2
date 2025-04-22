namespace Clinica_Veterinaria
{
    partial class FormBanco
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
            label1 = new Label();
            txtBuscar = new TextBox();
            dgvBancos = new DataGridView();
            btnGuardar = new Button();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBancos).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = SystemColors.ActiveCaption;
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(803, 73);
            panelPrincipal.TabIndex = 4;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(225, 9);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(332, 43);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Cuentas de Banco";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(428, 87);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 5;
            label1.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(485, 86);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(228, 27);
            txtBuscar.TabIndex = 6;
            txtBuscar.TextChanged += txtBuscador_TextChanged;
            // 
            // dgvBancos
            // 
            dgvBancos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBancos.Location = new Point(12, 147);
            dgvBancos.Name = "dgvBancos";
            dgvBancos.RowHeadersWidth = 51;
            dgvBancos.Size = new Size(776, 222);
            dgvBancos.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(636, 375);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(152, 57);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FormBanco
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 465);
            Controls.Add(btnGuardar);
            Controls.Add(dgvBancos);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            Controls.Add(panelPrincipal);
            Name = "FormBanco";
            Text = "FormBanco";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBancos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelPrincipal;
        private Label label1;
        private TextBox txtBuscar;
        private DataGridView dgvBancos;
        private Button btnGuardar;
    }
}