namespace Clinica_Veterinaria
{
    partial class FormVerHumanos
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
            dataGridView1 = new DataGridView();
            btnGuardar = new Button();
            btn_Eliminar = new Button();
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
            panelPrincipal.Margin = new Padding(4, 4, 4, 4);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1000, 91);
            panelPrincipal.TabIndex = 3;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(386, 18);
            labelPrincipal.Margin = new Padding(4, 0, 4, 0);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(213, 50);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Humanos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 100);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 4;
            label1.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(129, 98);
            txtBuscar.Margin = new Padding(2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(283, 31);
            txtBuscar.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(71, 148);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(676, 322);
            dataGridView1.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(71, 504);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(185, 34);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(604, 504);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(143, 34);
            btn_Eliminar.TabIndex = 8;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // FormVerHumanos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btn_Eliminar);
            Controls.Add(btnGuardar);
            Controls.Add(dataGridView1);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            Controls.Add(panelPrincipal);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormVerHumanos";
            Text = "FormVerHumanos";
            Load += FormVerHumanos_Load;
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelPrincipal;
        private Label label1;
        private TextBox txtBuscar;
        private DataGridView dataGridView1;
        private Button btnGuardar;
        private Button btn_Eliminar;
    }
}