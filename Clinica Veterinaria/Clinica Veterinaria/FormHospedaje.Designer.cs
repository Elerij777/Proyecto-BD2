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
            panelPrincipal.BackColor = Color.FromArgb(207, 226, 243);
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Margin = new Padding(3, 2, 3, 2);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(700, 94);
            panelPrincipal.TabIndex = 3;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(300, 34);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(144, 31);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Hospedaje";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(207, 226, 243);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            button1.Location = new Point(362, 286);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(145, 44);
            button1.TabIndex = 4;
            button1.Text = "Registrar LLegada";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgvHospedaje
            // 
            dgvHospedaje.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHospedaje.Location = new Point(24, 110);
            dgvHospedaje.Margin = new Padding(3, 2, 3, 2);
            dgvHospedaje.Name = "dgvHospedaje";
            dgvHospedaje.RowHeadersWidth = 51;
            dgvHospedaje.Size = new Size(634, 172);
            dgvHospedaje.TabIndex = 5;
            // 
            // btnSalida
            // 
            btnSalida.BackColor = Color.FromArgb(207, 226, 243);
            btnSalida.FlatStyle = FlatStyle.Flat;
            btnSalida.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnSalida.Location = new Point(513, 286);
            btnSalida.Margin = new Padding(3, 2, 3, 2);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(145, 44);
            btnSalida.TabIndex = 6;
            btnSalida.Text = "Registrar Salida";
            btnSalida.UseVisualStyleBackColor = false;
            btnSalida.Click += btnSalida_Click;
            // 
            // FormHospedaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(700, 338);
            Controls.Add(btnSalida);
            Controls.Add(dgvHospedaje);
            Controls.Add(button1);
            Controls.Add(panelPrincipal);
            Margin = new Padding(3, 2, 3, 2);
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