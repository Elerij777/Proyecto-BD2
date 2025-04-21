namespace Clinica_Veterinaria
{
    partial class FormHospedaje
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
            button1 = new Button();
            dgvHospedaje = new DataGridView();
            btnSalida = new Button();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHospedaje).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = SystemColors.ActiveCaption;
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(800, 125);
            panelPrincipal.TabIndex = 3;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(343, 46);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(208, 43);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Hospedaje";
            // 
            // button1
            // 
            button1.Location = new Point(200, 398);
            button1.Name = "button1";
            button1.Size = new Size(166, 29);
            button1.TabIndex = 4;
            button1.Text = "Registrar LLegada";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvHospedaje
            // 
            dgvHospedaje.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHospedaje.Location = new Point(28, 147);
            dgvHospedaje.Name = "dgvHospedaje";
            dgvHospedaje.RowHeadersWidth = 51;
            dgvHospedaje.Size = new Size(725, 229);
            dgvHospedaje.TabIndex = 5;
            // 
            // btnSalida
            // 
            btnSalida.Location = new Point(453, 398);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(166, 29);
            btnSalida.TabIndex = 6;
            btnSalida.Text = "Registrar Salida";
            btnSalida.UseVisualStyleBackColor = true;
            btnSalida.Click += btnSalida_Click;
            // 
            // FormHospedaje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalida);
            Controls.Add(dgvHospedaje);
            Controls.Add(button1);
            Controls.Add(panelPrincipal);
            Name = "FormHospedaje";
            Text = "FormHospedaje";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHospedaje).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelPrincipal;
        private Button button1;
        private DataGridView dgvHospedaje;
        private Button btnSalida;
    }
}