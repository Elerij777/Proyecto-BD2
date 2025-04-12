namespace Clinica_Veterinaria
{
    partial class FormProveedores
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
            btn_Agregar = new Button();
            btn_Modificar = new Button();
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
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1000, 116);
            panelPrincipal.TabIndex = 1;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(351, 36);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(300, 50);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Proveedores";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(793, 328);
            dataGridView1.TabIndex = 2;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(865, 165);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(123, 32);
            btn_Agregar.TabIndex = 3;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_Modificar
            // 
            btn_Modificar.Location = new Point(865, 275);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Size = new Size(123, 32);
            btn_Modificar.TabIndex = 4;
            btn_Modificar.Text = "Modifcar";
            btn_Modificar.UseVisualStyleBackColor = true;
            btn_Modificar.Click += btn_Modificar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(865, 401);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(123, 32);
            btn_Eliminar.TabIndex = 5;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Modificar);
            Controls.Add(btn_Agregar);
            Controls.Add(dataGridView1);
            Controls.Add(panelPrincipal);
            Name = "FormProveedores";
            Text = "FormProveedores";
            Load += FormProveedores_Load;
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelPrincipal;
        private DataGridView dataGridView1;
        private Button btn_Agregar;
        private Button btn_Modificar;
        private Button btn_Eliminar;
    }
}