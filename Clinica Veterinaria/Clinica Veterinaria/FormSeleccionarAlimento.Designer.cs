namespace Clinica_Veterinaria
{
    partial class FormSeleccionarAlimento
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
            btnSeleccionar = new Button();
            dgvAlimento = new DataGridView();
            panelPrincipal = new Panel();
            labelPrincipal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAlimento).BeginInit();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(21, 454);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(94, 29);
            btnSeleccionar.TabIndex = 12;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // dgvAlimento
            // 
            dgvAlimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlimento.Location = new Point(21, 149);
            dgvAlimento.Name = "dgvAlimento";
            dgvAlimento.RowHeadersWidth = 51;
            dgvAlimento.Size = new Size(845, 299);
            dgvAlimento.TabIndex = 11;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = SystemColors.ActiveCaption;
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(903, 125);
            panelPrincipal.TabIndex = 10;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(264, 49);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(411, 43);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Seleccionar Alimento";
            // 
            // FormSeleccionarAlimento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 525);
            Controls.Add(btnSeleccionar);
            Controls.Add(dgvAlimento);
            Controls.Add(panelPrincipal);
            Name = "FormSeleccionarAlimento";
            Text = "FormSeleccionarAlimento";
            ((System.ComponentModel.ISupportInitialize)dgvAlimento).EndInit();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSeleccionar;
        private DataGridView dgvAlimento;
        private Panel panelPrincipal;
        private Label labelPrincipal;
    }
}