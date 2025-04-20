namespace Clinica_Veterinaria
{
    partial class FormSeleccionarProducto
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
            txtBuscar = new TextBox();
            label1 = new Label();
            dgvProductos = new DataGridView();
            btn_Seleccionar = new Button();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = SystemColors.ActiveCaption;
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Margin = new Padding(4);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1000, 156);
            panelPrincipal.TabIndex = 7;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(250, 52);
            labelPrincipal.Margin = new Padding(4, 0, 4, 0);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(499, 50);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Seleccionar Producto";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(215, 189);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(314, 31);
            txtBuscar.TabIndex = 9;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 192);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 10;
            label1.Text = "Buscar";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(93, 281);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(801, 213);
            dgvProductos.TabIndex = 11;
            // 
            // btn_Seleccionar
            // 
            btn_Seleccionar.Location = new Point(93, 532);
            btn_Seleccionar.Name = "btn_Seleccionar";
            btn_Seleccionar.Size = new Size(112, 34);
            btn_Seleccionar.TabIndex = 12;
            btn_Seleccionar.Text = "Seleccionar";
            btn_Seleccionar.UseVisualStyleBackColor = true;
            btn_Seleccionar.Click += btn_Seleccionar_Click;
            // 
            // FormSeleccionarProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 612);
            Controls.Add(btn_Seleccionar);
            Controls.Add(dgvProductos);
            Controls.Add(label1);
            Controls.Add(txtBuscar);
            Controls.Add(panelPrincipal);
            Name = "FormSeleccionarProducto";
            Text = "FormSeleccionarProducto";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelPrincipal;
        private TextBox txtBuscar;
        private Label label1;
        private DataGridView dgvProductos;
        private Button btn_Seleccionar;
    }
}