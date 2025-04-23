namespace Clinica_Veterinaria
{
    partial class FormAgregarVehiculo
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
            BtnRegistrar = new Button();
            txtAnio = new TextBox();
            txtMarca = new TextBox();
            txtMatricula = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(207, 226, 243);
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(967, 125);
            panelPrincipal.TabIndex = 27;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(334, 47);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(273, 39);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Insertar Vehiculo";
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.BackColor = Color.FromArgb(207, 226, 243);
            BtnRegistrar.FlatStyle = FlatStyle.Flat;
            BtnRegistrar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegistrar.Image = Properties.Resources.add__1_;
            BtnRegistrar.Location = new Point(451, 315);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(126, 59);
            BtnRegistrar.TabIndex = 34;
            BtnRegistrar.Text = " Registrar";
            BtnRegistrar.TextAlign = ContentAlignment.MiddleLeft;
            BtnRegistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnRegistrar.UseVisualStyleBackColor = false;
            BtnRegistrar.Click += BtnRegistrar_Click;
            // 
            // txtAnio
            // 
            txtAnio.BackColor = Color.FromArgb(182, 207, 250);
            txtAnio.BorderStyle = BorderStyle.FixedSingle;
            txtAnio.Location = new Point(440, 241);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(171, 27);
            txtAnio.TabIndex = 33;
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.FromArgb(182, 207, 250);
            txtMarca.BorderStyle = BorderStyle.FixedSingle;
            txtMarca.Location = new Point(440, 190);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(171, 27);
            txtMarca.TabIndex = 32;
            // 
            // txtMatricula
            // 
            txtMatricula.BackColor = Color.FromArgb(182, 207, 250);
            txtMatricula.BorderStyle = BorderStyle.FixedSingle;
            txtMatricula.Location = new Point(440, 145);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(171, 27);
            txtMatricula.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(394, 243);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 30;
            label3.Text = "Año:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 192);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 29;
            label2.Text = "Marca:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 148);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 28;
            label1.Text = "Matricula:";
            // 
            // FormAgregarVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(967, 450);
            Controls.Add(BtnRegistrar);
            Controls.Add(txtAnio);
            Controls.Add(txtMarca);
            Controls.Add(txtMatricula);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelPrincipal);
            Name = "FormAgregarVehiculo";
            Text = "FormAgregarVehiculo";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelPrincipal;
        private Label labelPrincipal;
        private Button BtnRegistrar;
        private TextBox txtAnio;
        private TextBox txtMarca;
        private TextBox txtMatricula;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}