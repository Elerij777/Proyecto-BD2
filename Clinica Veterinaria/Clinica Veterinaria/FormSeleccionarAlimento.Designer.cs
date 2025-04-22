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
            btnSeleccionar.BackColor = Color.FromArgb(207, 226, 243);
            btnSeleccionar.FlatStyle = FlatStyle.Flat;
            btnSeleccionar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeleccionar.Location = new Point(339, 340);
            btnSeleccionar.Margin = new Padding(3, 2, 3, 2);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(100, 44);
            btnSeleccionar.TabIndex = 12;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // dgvAlimento
            // 
            dgvAlimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlimento.Location = new Point(18, 112);
            dgvAlimento.Margin = new Padding(3, 2, 3, 2);
            dgvAlimento.Name = "dgvAlimento";
            dgvAlimento.RowHeadersWidth = 51;
            dgvAlimento.Size = new Size(739, 224);
            dgvAlimento.TabIndex = 11;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(207, 226, 243);
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Margin = new Padding(3, 2, 3, 2);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(790, 94);
            panelPrincipal.TabIndex = 10;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(231, 37);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(268, 31);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Seleccionar Alimento";
            // 
            // FormSeleccionarAlimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(790, 394);
            Controls.Add(btnSeleccionar);
            Controls.Add(dgvAlimento);
            Controls.Add(panelPrincipal);
            Margin = new Padding(3, 2, 3, 2);
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