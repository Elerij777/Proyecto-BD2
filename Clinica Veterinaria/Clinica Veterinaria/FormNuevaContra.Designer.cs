namespace Clinica_Veterinaria
{
    partial class FormNuevaContra
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
            label1 = new Label();
            label2 = new Label();
            txtNewPass = new TextBox();
            txtConfrimPass = new TextBox();
            bntAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 68);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 0;
            label1.Text = "Nueva Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 142);
            label2.Name = "label2";
            label2.Size = new Size(189, 25);
            label2.TabIndex = 1;
            label2.Text = "Confirmar Contraseña:";
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(292, 62);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(273, 31);
            txtNewPass.TabIndex = 2;
            // 
            // txtConfrimPass
            // 
            txtConfrimPass.Location = new Point(292, 139);
            txtConfrimPass.Name = "txtConfrimPass";
            txtConfrimPass.Size = new Size(273, 31);
            txtConfrimPass.TabIndex = 3;
            // 
            // bntAceptar
            // 
            bntAceptar.Location = new Point(470, 217);
            bntAceptar.Name = "bntAceptar";
            bntAceptar.Size = new Size(143, 63);
            bntAceptar.TabIndex = 4;
            bntAceptar.Text = "Aceptar";
            bntAceptar.UseVisualStyleBackColor = true;
            bntAceptar.Click += bntAceptar_Click;
            // 
            // FormNuevaContra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 302);
            Controls.Add(bntAceptar);
            Controls.Add(txtConfrimPass);
            Controls.Add(txtNewPass);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormNuevaContra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormNuevaContra";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNewPass;
        private TextBox txtConfrimPass;
        private Button bntAceptar;
    }
}