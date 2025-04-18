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
            btn_Salvar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(31, 40);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 62;
            dgvEmpleados.Size = new Size(939, 383);
            dgvEmpleados.TabIndex = 0;
            // 
            // btn_Salvar
            // 
            btn_Salvar.Location = new Point(415, 458);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(143, 62);
            btn_Salvar.TabIndex = 1;
            btn_Salvar.Text = "Salvar";
            btn_Salvar.UseVisualStyleBackColor = true;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // FormEmpleados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btn_Salvar);
            Controls.Add(dgvEmpleados);
            Name = "FormEmpleados";
            Text = "FormEmpleados";
            Load += FormEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmpleados;
        private Button btn_Salvar;
    }
}