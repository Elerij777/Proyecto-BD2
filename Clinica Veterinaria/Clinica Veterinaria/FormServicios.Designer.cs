namespace Clinica_Veterinaria
{
    partial class FormServicios
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
            btnSalvar = new Button();
            dgvServicios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(433, 458);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(143, 62);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dgvServicios
            // 
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(49, 40);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.RowHeadersWidth = 62;
            dgvServicios.Size = new Size(939, 383);
            dgvServicios.TabIndex = 2;
            // 
            // FormServicios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 597);
            Controls.Add(btnSalvar);
            Controls.Add(dgvServicios);
            Name = "FormServicios";
            Text = "FormServicios";
            Load += FormServicios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalvar;
        private DataGridView dgvServicios;
    }
}