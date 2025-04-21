
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
            panelPrincipal.BackColor = SystemColors.ActiveCaption;
            panelPrincipal.Controls.Add(labelPrincipal);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(998, 125);
            panelPrincipal.TabIndex = 6;
            // 
            // labelPrincipal
            // 
            labelPrincipal.AutoSize = true;
            labelPrincipal.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrincipal.Location = new Point(445, 38);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(177, 43);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "Compras";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 239);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 7;
            label1.Text = "Nombre Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 202);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 8;
            label2.Text = "Costo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 164);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 9;
            label3.Text = "Proveedor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 279);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 10;
            label4.Text = "Cantidad:";
            // 
            // txtProveedor
            // 
            txtProveedor.Enabled = false;
            txtProveedor.Location = new Point(210, 162);
            txtProveedor.Margin = new Padding(2, 2, 2, 2);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(121, 27);
            txtProveedor.TabIndex = 11;
            txtProveedor.TextChanged += txtProveedor_TextChanged;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(210, 202);
            txtCosto.Margin = new Padding(2, 2, 2, 2);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(121, 27);
            txtCosto.TabIndex = 12;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(210, 239);
            txtNombreProducto.Margin = new Padding(2, 2, 2, 2);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(121, 27);
            txtNombreProducto.TabIndex = 13;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(210, 279);
            txtCantidad.Margin = new Padding(2, 2, 2, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(121, 27);
            txtCantidad.TabIndex = 14;
            // 
            // BtnElegirProveedor
            // 
            BtnElegirProveedor.Image = Properties.Resources.lupa1;
            BtnElegirProveedor.Location = new Point(347, 155);
            BtnElegirProveedor.Name = "BtnElegirProveedor";
            BtnElegirProveedor.Size = new Size(39, 37);
            BtnElegirProveedor.TabIndex = 23;
            BtnElegirProveedor.UseVisualStyleBackColor = true;
            BtnElegirProveedor.Click += BtnElegirProveedor_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(445, 162);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 24;
            label5.Text = "Detalle:";
            // 
            // txtDetalle
            // 
            txtDetalle.Location = new Point(562, 155);
            txtDetalle.Margin = new Padding(2, 2, 2, 2);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(241, 27);
            txtDetalle.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(445, 202);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 26;
            label6.Text = "Fecha:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(445, 239);
            label7.Name = "label7";
            label7.Size = new Size(106, 20);
            label7.TabIndex = 27;
            label7.Text = "Tipo Producto:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(445, 279);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 28;
            label8.Text = "Precio:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(562, 197);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(241, 27);
            dateTimePicker1.TabIndex = 29;
            // 
            // comboTipoProducto
            // 
            comboTipoProducto.FormattingEnabled = true;
            comboTipoProducto.Location = new Point(562, 239);
            comboTipoProducto.Margin = new Padding(2, 2, 2, 2);
            comboTipoProducto.Name = "comboTipoProducto";
            comboTipoProducto.Size = new Size(146, 28);
            comboTipoProducto.TabIndex = 30;
            comboTipoProducto.SelectedIndexChanged += comboTipoProducto_SelectedIndexChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(562, 279);
            txtPrecio.Margin = new Padding(2, 2, 2, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 27);
            txtPrecio.TabIndex = 31;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(90, 362);
            btnInsertar.Margin = new Padding(2, 2, 2, 2);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(90, 27);
            btnInsertar.TabIndex = 32;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btn_existente
            // 
            btn_existente.Location = new Point(237, 362);
            btn_existente.Margin = new Padding(2, 2, 2, 2);
            btn_existente.Name = "btn_existente";
            btn_existente.Size = new Size(167, 27);
            btn_existente.TabIndex = 33;
            btn_existente.Text = "Compra Existente";
            btn_existente.UseVisualStyleBackColor = true;
            btn_existente.Click += btn_existente_Click;
            // 
            // dgvCompras
            // 
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Location = new Point(106, 438);
            dgvCompras.Margin = new Padding(2, 2, 2, 2);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.ReadOnly = true;
            dgvCompras.RowHeadersWidth = 62;
            dgvCompras.Size = new Size(782, 180);
            dgvCompras.TabIndex = 34;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(458, 362);
            btnEditar.Margin = new Padding(2, 2, 2, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(90, 27);
            btnEditar.TabIndex = 35;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // FormCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 652);
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
            Margin = new Padding(2, 2, 2, 2);
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