namespace Clinica_Veterinaria
{
    partial class FormSeleccionarVehiculosTransporte
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
            btnSeleccionar = new Button();
            dtvVehiculos = new DataGridView();
            panelPrincipal = new Panel();
            labelPrincipal = new Label();
            ((System.ComponentModel.ISupportInitialize)dtvVehiculos).BeginInit();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.BackColor = Color.FromArgb(207, 226, 243);
            btnSeleccionar.FlatStyle = FlatStyle.Flat;
            btnSeleccionar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnSeleccionar.Location = new Point(335, 418);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(114, 59);
            btnSeleccionar.TabIndex = 12;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // dtvVehiculos
            // 
            dtvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvVehiculos.Location = new Point(27, 131);
            dtvVehiculos.Name = "dtvVehiculos";
            dtvVehiculos.RowHeadersWidth = 51;
            dtvVehiculos.Size = new Size(747, 281);
            dtvVehiculos.TabIndex = 11;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(207, 226, 243);
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(800, 125);
            panelPrincipal.TabIndex = 10;
            // 
            // labelPrincipal
            // 
            labelPrincipal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(240, 49);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(337, 39);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Seleccionar Vehiculo";
            // 
            // FormSeleccionarVehiculosTransporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(800, 476);
            Controls.Add(btnSeleccionar);
            Controls.Add(dtvVehiculos);
            Controls.Add(panelPrincipal);
            Name = "FormSeleccionarVehiculosTransporte";
            Text = "FormSeleccionarVehiculosTransporte";
            ((System.ComponentModel.ISupportInitialize)dtvVehiculos).EndInit();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSeleccionar;
        private DataGridView dtvVehiculos;
        private Panel panelPrincipal;
        private Label labelPrincipal;
    }
}