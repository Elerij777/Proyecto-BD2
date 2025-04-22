
namespace Clinica_Veterinaria
{
    partial class FormCompras
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtProveedor = new TextBox();
            txtCosto = new TextBox();
            txtNombreProducto = new TextBox();
            txtCantidad = new TextBox();
            BtnElegirProveedor = new Button();
            label5 = new Label();
            txtDetalle = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboTipoProducto = new ComboBox();
            txtPrecio = new TextBox();
            btnInsertar = new Button();
            btn_existente = new Button();
            dgvCompras = new DataGridView();
            btnEditar = new Button();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
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
            panelPrincipal.Size = new Size(873, 94);
            panelPrincipal.TabIndex = 6;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(389, 28);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(124, 31);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Compras";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 179);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombre Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 152);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 8;
            label2.Text = "Costo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 123);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 9;
            label3.Text = "Proveedor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 209);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 10;
            label4.Text = "Cantidad:";
            // 
            // txtProveedor
            // 
            txtProveedor.BackColor = Color.FromArgb(182, 207, 250);
            txtProveedor.BorderStyle = BorderStyle.None;
            txtProveedor.Enabled = false;
            txtProveedor.Location = new Point(184, 123);
            txtProveedor.Margin = new Padding(0);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(106, 16);
            txtProveedor.TabIndex = 11;
            txtProveedor.TextChanged += txtProveedor_TextChanged;
            // 
            // txtCosto
            // 
            txtCosto.BackColor = Color.FromArgb(182, 207, 250);
            txtCosto.BorderStyle = BorderStyle.None;
            txtCosto.Location = new Point(184, 152);
            txtCosto.Margin = new Padding(2);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(106, 16);
            txtCosto.TabIndex = 12;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.BackColor = Color.FromArgb(182, 207, 250);
            txtNombreProducto.BorderStyle = BorderStyle.None;
            txtNombreProducto.Location = new Point(184, 179);
            txtNombreProducto.Margin = new Padding(2);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(106, 16);
            txtNombreProducto.TabIndex = 13;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.FromArgb(182, 207, 250);
            txtCantidad.BorderStyle = BorderStyle.None;
            txtCantidad.Location = new Point(184, 209);
            txtCantidad.Margin = new Padding(2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(106, 16);
            txtCantidad.TabIndex = 14;
            // 
            // BtnElegirProveedor
            // 
            BtnElegirProveedor.BackColor = Color.FromArgb(182, 207, 230);
            BtnElegirProveedor.FlatStyle = FlatStyle.Flat;
            BtnElegirProveedor.ForeColor = Color.FromArgb(182, 207, 230);
            BtnElegirProveedor.Image = Properties.Resources.lupa2;
            BtnElegirProveedor.Location = new Point(290, 118);
            BtnElegirProveedor.Margin = new Padding(0);
            BtnElegirProveedor.Name = "BtnElegirProveedor";
            BtnElegirProveedor.Size = new Size(24, 24);
            BtnElegirProveedor.TabIndex = 23;
            BtnElegirProveedor.UseVisualStyleBackColor = false;
            BtnElegirProveedor.Click += BtnElegirProveedor_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(389, 122);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 24;
            label5.Text = "Detalle:";
            // 
            // txtDetalle
            // 
            txtDetalle.BackColor = Color.FromArgb(182, 207, 250);
            txtDetalle.BorderStyle = BorderStyle.None;
            txtDetalle.Location = new Point(492, 122);
            txtDetalle.Margin = new Padding(2);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(211, 16);
            txtDetalle.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(389, 152);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 26;
            label6.Text = "Fecha:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(389, 179);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 27;
            label7.Text = "Tipo Producto:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(389, 209);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 28;
            label8.Text = "Precio:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(492, 148);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 23);
            dateTimePicker1.TabIndex = 29;
            // 
            // comboTipoProducto
            // 
            comboTipoProducto.BackColor = Color.FromArgb(182, 207, 250);
            comboTipoProducto.FormattingEnabled = true;
            comboTipoProducto.Location = new Point(492, 179);
            comboTipoProducto.Margin = new Padding(2);
            comboTipoProducto.Name = "comboTipoProducto";
            comboTipoProducto.Size = new Size(128, 23);
            comboTipoProducto.TabIndex = 30;
            comboTipoProducto.SelectedIndexChanged += comboTipoProducto_SelectedIndexChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(182, 207, 250);
            txtPrecio.BorderStyle = BorderStyle.None;
            txtPrecio.Location = new Point(492, 209);
            txtPrecio.Margin = new Padding(2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(106, 16);
            txtPrecio.TabIndex = 31;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.FromArgb(207, 226, 243);
            btnInsertar.FlatStyle = FlatStyle.Flat;
            btnInsertar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnInsertar.Location = new Point(79, 272);
            btnInsertar.Margin = new Padding(2);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(79, 44);
            btnInsertar.TabIndex = 32;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btn_existente
            // 
            btn_existente.BackColor = Color.FromArgb(207, 226, 243);
            btn_existente.FlatStyle = FlatStyle.Flat;
            btn_existente.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btn_existente.Location = new Point(205, 272);
            btn_existente.Margin = new Padding(2);
            btn_existente.Name = "btn_existente";
            btn_existente.Size = new Size(146, 44);
            btn_existente.TabIndex = 33;
            btn_existente.Text = "Compra Existente";
            btn_existente.UseVisualStyleBackColor = false;
            btn_existente.Click += btn_existente_Click;
            // 
            // dgvCompras
            // 
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Location = new Point(93, 328);
            dgvCompras.Margin = new Padding(2);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.ReadOnly = true;
            dgvCompras.RowHeadersWidth = 62;
            dgvCompras.Size = new Size(684, 135);
            dgvCompras.TabIndex = 34;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(207, 226, 243);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnEditar.Location = new Point(401, 272);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(79, 44);
            btnEditar.TabIndex = 35;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // FormCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 207, 230);
            ClientSize = new Size(873, 489);
            Controls.Add(btnEditar);
            Controls.Add(dgvCompras);
            Controls.Add(btn_existente);
            Controls.Add(btnInsertar);
            Controls.Add(txtPrecio);
            Controls.Add(comboTipoProducto);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtDetalle);
            Controls.Add(label5);
            Controls.Add(BtnElegirProveedor);
            Controls.Add(txtCantidad);
            Controls.Add(txtNombreProducto);
            Controls.Add(txtCosto);
            Controls.Add(txtProveedor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelPrincipal);
            Margin = new Padding(2);
            Name = "FormCompras";
            Text = "FormComprascs";
            Load += FormCompras_Load_1;
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Panel panelPrincipal;
        private Label labelPrincipal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtProveedor;
        private TextBox txtCosto;
        private TextBox txtNombreProducto;
        private TextBox txtCantidad;
        private Button BtnElegirProveedor;
        private Label label5;
        private TextBox txtDetalle;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboTipoProducto;
        private TextBox txtPrecio;
        private Button btnInsertar;
        private Button btn_existente;
        private DataGridView dgvCompras;
        private Button btnEditar;
    }
}