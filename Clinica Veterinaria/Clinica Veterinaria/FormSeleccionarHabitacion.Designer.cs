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
            dgvHabitaciones.Location = new Point(21, 157);
            dgvHabitaciones.Name = "dgvHabitaciones";
            dgvHabitaciones.RowHeadersWidth = 51;
            dgvHabitaciones.Size = new Size(748, 281);
            dgvHabitaciones.TabIndex = 8;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = SystemColors.ActiveCaption;
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(800, 125);
            panelPrincipal.TabIndex = 7;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(170, 41);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(448, 43);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Seleccionar Habitacion";
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(58, 444);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(94, 29);
            btnSeleccionar.TabIndex = 9;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // FormSeleccionarHabitacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 492);
            Controls.Add(btnSeleccionar);
            Controls.Add(dgvHabitaciones);
            Controls.Add(panelPrincipal);
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