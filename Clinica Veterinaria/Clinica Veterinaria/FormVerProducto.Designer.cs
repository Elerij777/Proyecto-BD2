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
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = SystemColors.ActiveCaption;
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(827, 125);
            panelPrincipal.TabIndex = 3;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(301, 38);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(221, 43);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Productos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 199);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(803, 239);
            dataGridView1.TabIndex = 4;
            // 
            // txtBuscador
            // 
            txtBuscador.Location = new Point(365, 144);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(439, 27);
            txtBuscador.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(307, 144);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 6;
            label1.Text = "Buscar";
            // 
            // FormVerProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 507);
            Controls.Add(label1);
            Controls.Add(txtBuscador);
            Controls.Add(dataGridView1);
            Controls.Add(panelPrincipal);
            Name = "FormVerProducto";
            Text = "FormVerProducto";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Panel panelPrincipal;
        private Label labelPrincipal;
        private DataGridView dataGridView1;
        private TextBox txtBuscador;
        private Label label1;
    }
}