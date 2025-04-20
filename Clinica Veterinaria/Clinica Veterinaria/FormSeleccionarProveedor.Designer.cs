namespace Clinica_Veterinaria
{
    partial class FormSeleccionarProveedor
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
            dgvProveedor = new DataGridView();
            txtBuscar = new TextBox();
            btn_Seleccionar = new Button();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
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
            labelPrincipal.Size = new Size(518, 50);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Seleccionar Proveedor";
            // 
            // dgvProveedor
            // 
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.Location = new Point(112, 297);
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.RowHeadersWidth = 62;
            dgvProveedor.Size = new Size(801, 213);
            dgvProveedor.TabIndex = 8;
            dgvProveedor.CellContentClick += dgvProveedor_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(112, 224);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(314, 31);
            txtBuscar.TabIndex = 9;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btn_Seleccionar
            // 
            btn_Seleccionar.Location = new Point(112, 536);
            btn_Seleccionar.Name = "btn_Seleccionar";
            btn_Seleccionar.Size = new Size(112, 34);
            btn_Seleccionar.TabIndex = 10;
            btn_Seleccionar.Text = "Seleccionar";
            btn_Seleccionar.UseVisualStyleBackColor = true;
            btn_Seleccionar.Click += btn_Seleccionar_Click;
            // 
            // FormSeleccionarProveedor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 612);
            Controls.Add(btn_Seleccionar);
            Controls.Add(txtBuscar);
            Controls.Add(dgvProveedor);
            Controls.Add(panelPrincipal);
            Name = "FormSeleccionarProveedor";
            Text = "FormSeleccionarProveedor";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelPrincipal;
        private DataGridView dgvProveedor;
        private TextBox txtBuscar;
        private Button btn_Seleccionar;
    }
}