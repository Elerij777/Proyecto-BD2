namespace Clinica_Veterinaria
{
    partial class FormSeleccionarHabitacion
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
            dgvHabitaciones = new DataGridView();
            panelPrincipal = new Panel();
            labelPrincipal = new Label();
            btnSeleccionar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHabitaciones).BeginInit();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHabitaciones
            // 
            dgvHabitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHabitaciones.Location = new Point(24, 118);
            dgvHabitaciones.Margin = new Padding(3, 2, 3, 2);
            dgvHabitaciones.Name = "dgvHabitaciones";
            dgvHabitaciones.RowHeadersWidth = 51;
            dgvHabitaciones.Size = new Size(654, 211);
            dgvHabitaciones.TabIndex = 8;
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
            panelPrincipal.TabIndex = 7;
            // 
            // labelPrincipal
            // 
            labelPrincipal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(197, 28);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(292, 31);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Seleccionar Habitacion";
            labelPrincipal.Click += labelPrincipal_Click;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.BackColor = Color.FromArgb(207, 226, 243);
            btnSeleccionar.FlatStyle = FlatStyle.Flat;
            btnSeleccionar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnSeleccionar.Location = new Point(293, 333);
            btnSeleccionar.Margin = new Padding(3, 2, 3, 2);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(100, 44);
            btnSeleccionar.TabIndex = 9;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // FormSeleccionarHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(700, 385);
            Controls.Add(btnSeleccionar);
            Controls.Add(dgvHabitaciones);
            Controls.Add(panelPrincipal);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormSeleccionarHabitacion";
            Text = "Seleccionar Habitacion ";
            ((System.ComponentModel.ISupportInitialize)dgvHabitaciones).EndInit();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHabitaciones;
        private Panel panelPrincipal;
        private Label labelPrincipal;
        private Button btnSeleccionar;
    }
}