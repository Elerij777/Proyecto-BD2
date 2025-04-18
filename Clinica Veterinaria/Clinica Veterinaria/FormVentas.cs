using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_Veterinaria
{
    public partial class FormVentas : Form
    {
        SqlConnection cnx;
        public int clienteId = 0;
        public FormVentas(SqlConnection cnx)
        {
            this.cnx = cnx;
            InitializeComponent();
            ConfigurarDataGridView();
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cbEstado.Items.Add("Pagado");
            cbEstado.Items.Add("Pendiente");
            cbEstado.Items.Add("Cancelado");
            cbMetodoPago.Items.Add("Tarjeta");
            cbMetodoPago.Items.Add("Efectivo");
            cbMetodoPago.Items.Add("Cheque");

        }
        private void ConfigurarDataGridView()
        {
            dgvFactura.Columns.Clear();
            dgvFactura.AutoGenerateColumns = false;
            dgvFactura.AllowUserToAddRows = false;
            dgvFactura.RowHeadersVisible = false;
            dgvFactura.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                Visible = false
            });

            // Tipo (Producto / Servicio)
            var tipoColumn = new DataGridViewComboBoxColumn
            {
                Name = "Tipo",
                HeaderText = "Tipo",
                DataSource = new string[] { "Producto", "Servicio" },
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dgvFactura.Columns.Add(tipoColumn);

            // Descripción
            dgvFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Descripcion",
                HeaderText = "Descripción",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // Cantidad
            dgvFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cantidad",
                HeaderText = "Cantidad",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CostoUnitario",
                HeaderText = "Costo Unitario",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Impuesto",
                HeaderText = "Impuesto (%)",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            var empleadoColumn = new DataGridViewComboBoxColumn
            {
                Name = "Empleado",
                HeaderText = "Empleado",
                ReadOnly = true,
                Visible = false,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dgvFactura.Columns.Add(empleadoColumn);

            // Comisión
            dgvFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Comision",
                HeaderText = "Comisión (%)",
                ReadOnly = true,
                Visible = false,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // Subtotal
            dgvFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Subtotal",
                HeaderText = "Subtotal",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }



        private void BtnElegirCliente_Click(object sender, EventArgs e)
        {
            FormSeleccionarCliente_Ventas formSeleccionarCliente = new FormSeleccionarCliente_Ventas(this, cnx);
            formSeleccionarCliente.Visible = true;
        }
        public void setTxtCliente(String Nombre)
        {
            txtCliente.Text = Nombre;
        }
        public void AgregarProducto(string descripcion, int cantidad, decimal costoUnitario, decimal impuesto, int id)
        {
            decimal subtotal = (costoUnitario * cantidad) * (1 + (impuesto / 100));

            dgvFactura.Rows.Add(id,"Producto", descripcion, cantidad, costoUnitario, impuesto, null, null, subtotal);
        }
        public void AgregarServicio(string descripcion, int cantidad, decimal costoUnitario, decimal impuesto, string empleado, decimal comision, int id)
        {
            decimal subtotal = (costoUnitario * cantidad) * (1 + (impuesto / 100));

            int rowIndex = dgvFactura.Rows.Add(id,"Servicio", descripcion, cantidad, costoUnitario, impuesto, empleado, comision, subtotal);

            dgvFactura.Rows[rowIndex].Cells["Empleado"].Value = empleado;
            dgvFactura.Rows[rowIndex].Cells["Comision"].Value = comision;
        }



        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
