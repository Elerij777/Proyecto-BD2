using Microsoft.VisualBasic;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Clinica_Veterinaria
{
    public partial class FormVentas : Form
    {
        SqlConnection cnx;
        public int clienteId = 0;
        string input = "";
        double numero = 0;
        public FormVentas(SqlConnection cnx)
        {
            this.cnx = cnx;
            InitializeComponent();
            ConfigurarDataGridView();
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
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
            var tipoColumn = new DataGridViewTextBoxColumn
            {
                Name = "Tipo",
                HeaderText = "Tipo",
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


            // Subtotal
            dgvFactura.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Importe",
                HeaderText = "Importe",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }



        private void BtnElegirCliente_Click(object sender, EventArgs e)
        {
            FormSeleccionarCliente_Ventas formSeleccionarCliente = new FormSeleccionarCliente_Ventas(this, cnx);
            formSeleccionarCliente.Visible = true;
        }
        public void setTxtCliente(string Nombre)
        {
            txtCliente.Text = Nombre;
        }
        public void AgregarProducto(string descripcion, int cantidad, decimal costoUnitario, decimal impuesto, int id)
        {
            foreach (DataGridViewRow fila in dgvFactura.Rows)
            {
                if (fila.Cells["Id"].Value != null && (int)fila.Cells["Id"].Value == id && fila.Cells["Tipo"].Value.ToString() == "Producto")
                {
                    int cantidadExistente = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                    int nuevaCantidad = cantidadExistente + cantidad;

                    decimal NuevoImporte = Math.Round((costoUnitario * nuevaCantidad) * (1 + impuesto), 2);

                    fila.Cells["Cantidad"].Value = nuevaCantidad;
                    fila.Cells["Importe"].Value = NuevoImporte;
                    CalcularTotal();
                    return;
                }
            }


            decimal Importe = Math.Round((costoUnitario * cantidad) * (1 + impuesto), 2);

            dgvFactura.Rows.Add(id, "Producto", descripcion, cantidad, costoUnitario, impuesto, null, Importe);
            CalcularTotal();
        }


        public void AgregarServicio(string descripcion, int cantidad, decimal costoUnitario, decimal impuesto, int empleado, int id)
        {
            foreach (DataGridViewRow fila in dgvFactura.Rows)
            {
                if (fila.Cells["Id"].Value != null
                    && (int)fila.Cells["Id"].Value == id
                    && fila.Cells["Tipo"].Value.ToString() == "Servicio"
                    && Convert.ToInt32(fila.Cells["Empleado"].Value?.ToString()) == empleado)
                {
                    int cantidadExistente = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                    int nuevaCantidad = cantidadExistente + cantidad;

                    decimal NuevoImporte = Math.Round((costoUnitario * nuevaCantidad) * (1 + (impuesto / 100)), 2);

                    fila.Cells["Cantidad"].Value = nuevaCantidad;
                    fila.Cells["Importe"].Value = NuevoImporte;
                    CalcularTotal();
                    return;
                }
            }

            decimal Importe = Math.Round((costoUnitario * cantidad) * (1 + (impuesto / 100)), 2);

            int rowIndex = dgvFactura.Rows.Add(id, "Servicio", descripcion, cantidad, costoUnitario, impuesto, empleado, Importe);

            dgvFactura.Rows[rowIndex].Cells["Empleado"].Value = empleado;
            dgvFactura.Rows[rowIndex].Cells["Importe"].Value = Importe;
            CalcularTotal();
        }
        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow fila in dgvFactura.Rows)
            {
                if (fila.Cells["Importe"].Value != null)
                {
                    if (decimal.TryParse(fila.Cells["Importe"].Value.ToString(), out decimal importe))
                    {
                        total += importe;
                    }
                }
            }

            decimal impuesto = Math.Round(total * 15 / 115, 2);
            decimal subtotal = total - impuesto;
            txtTotal.Text = total.ToString("C2");
            txtImpuesto.Text = impuesto.ToString("C2");
            txtSubTotal.Text = subtotal.ToString("C2");
        }



        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            FormSeleccionarProducto_Ventas formSeleccionarProducto_Ventas = new FormSeleccionarProducto_Ventas(cnx, this);
            formSeleccionarProducto_Ventas.Visible = true;
        }


        private void btnAgregarServivcio_Click_1(object sender, EventArgs e)
        {
            if (clienteId == 0)
            {
                MessageBox.Show("Debes seleccionar un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormSeleccionarServicio_Venta formSeleccionarServicio_Venta = new FormSeleccionarServicio_Venta(cnx, this, clienteId);
            formSeleccionarServicio_Venta.Visible = true;
        }

        private void BtnGuardarFactura_Click(object sender, EventArgs e)
        {
            if (dgvFactura.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto o servicio a la factura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbMetodoPago.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un método de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = 0;
            decimal.TryParse(txtTotal.Text, System.Globalization.NumberStyles.Currency, null, out total);

            if (cbMetodoPago.SelectedItem.ToString() == "Efectivo")
            {
                while (true)
                {
                    input = Interaction.InputBox("Ingrese la cantidad de dinero que le proporcionó el cliente", "Pago en efectivo", "");

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        return;
                    }

                    if (double.TryParse(input, out numero) && numero > 0)
                    {
                        if (numero < (double)total)
                        {
                            MessageBox.Show("La cantidad proporcionada es menor al total de la factura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            double cambio = Math.Round(numero - (double)total, 2);
                            MessageBox.Show($"Pago recibido: L. {numero}\nCambio: L. {cambio}", "Pago en efectivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un número válido mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            GuardarFactura();

            

        }
        private void GuardarFactura()
        {
            if (dgvFactura.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto o servicio a la factura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cnx.Open();

            decimal total = 0;
            decimal.TryParse(txtTotal.Text, System.Globalization.NumberStyles.Currency, null, out total);
            string metodoPago = cbMetodoPago.SelectedItem?.ToString() ?? "Efectivo";
            DateTime fechaFactura = DateTime.Now;

            // Generar XML para productos y servicios
            string productosXml = "<Items>";
            string serviciosXml = "<Items>";

            foreach (DataGridViewRow fila in dgvFactura.Rows)
            {
                if (fila.Cells["Importe"].Value != null)
                {
                    string tipo = fila.Cells["Tipo"].Value.ToString();
                    int id = Convert.ToInt32(fila.Cells["Id"].Value);
                    int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                    decimal costoUnitario = Convert.ToDecimal(fila.Cells["CostoUnitario"].Value);
                    decimal impuesto = Convert.ToDecimal(fila.Cells["Impuesto"].Value);

                    if (tipo == "Producto")
                    {
                        productosXml += $"<Product Id='{id}' Cantidad='{cantidad}' CostoUnitario='{costoUnitario}' Impuesto='{impuesto}' />";
                    }
                    else if (tipo == "Servicio")
                    {
                        // Suponiendo que tienes columna EmpleadoId
                        int empleadoId = Convert.ToInt32(fila.Cells["Empleado"].Value);
                        serviciosXml += $"<Service Id='{id}' Cantidad='{cantidad}' CostoUnitario='{costoUnitario}' Impuesto='{impuesto}' EmpleadoId='{empleadoId}' />";
                    }
                }
            }

            productosXml += "</Items>";
            serviciosXml += "</Items>";

            try
            {
                using (SqlCommand cmd = new SqlCommand("SPGuardarFactura", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ClienteId", clienteId);
                    cmd.Parameters.AddWithValue("@Fecha", fechaFactura);
                    cmd.Parameters.AddWithValue("@Estado", "Finalizado");
                    cmd.Parameters.AddWithValue("@Metodo_pago", metodoPago);
                    cmd.Parameters.AddWithValue("@Abonado", total);
                    cmd.Parameters.AddWithValue("@ProductosXml", productosXml);
                    cmd.Parameters.AddWithValue("@ServiciosXml", serviciosXml);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Factura guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnx.Close();
            }
        }

    }

}

