using Microsoft.VisualBasic;
using PdfSharp.Drawing;
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
        private int DocumentoId;
        int facturaid = 0;

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
            if (facturaid == 0)
            {
                GuardarFactura();
            }
            else
            {
                PagarFacturaPendiente();
            }



        }
        private void GuardarFactura()
        {
            if (dgvFactura.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto o servicio a la factura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                        int empleadoId = Convert.ToInt32(fila.Cells["Empleado"].Value);
                        serviciosXml += $"<Service Id='{id}' Cantidad='{cantidad}' CostoUnitario='{costoUnitario}' Impuesto='{impuesto}' EmpleadoId='{empleadoId}' />";
                    }
                }
            }

            productosXml += "</Items>";
            serviciosXml += "</Items>";

            try
            {
                cnx.Open();

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
                GenerarPDF("plantillaFactura");
                LimpiarControles();
            }
        }
        private void GenerarPDF(string plantilla)
        {
            try
            {
                // Determinar el texto del documento según la plantilla
                string documentoTexto;
                if (plantilla == "plantillaCotizacion")
                {
                    documentoTexto = "Cotización";
                }
                else if (plantilla == "plantillaFactura")
                {
                    // Recuperar el Factura_id de la última factura
                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.ObtenerUltimaFacturaId()", cnx))
                    {
                        cnx.Open();
                        DocumentoId = (int)cmd.ExecuteScalar();
                        cnx.Close();
                    }
                    documentoTexto = $"Factura N: {DocumentoId}";
                }
                else
                {
                    documentoTexto = "Documento";
                }

                // Crear el documento PDF
                var documento = new PdfSharp.Pdf.PdfDocument();
                documento.Info.Title = "Documento";

                var pagina = documento.AddPage();
                pagina.Orientation = PdfSharp.PageOrientation.Portrait;

                var gfx = PdfSharp.Drawing.XGraphics.FromPdfPage(pagina);

                // Cargar la imagen de la plantilla desde los recursos
                if (Properties.Resources.ResourceManager.GetObject(plantilla) is Bitmap plantillaImagen)
                {
                    using (var stream = new System.IO.MemoryStream())
                    {
                        plantillaImagen.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                        var imagen = PdfSharp.Drawing.XImage.FromStream(stream);
                        gfx.DrawImage(imagen, 0, 0, pagina.Width, pagina.Height);
                    }
                }
                else
                {
                    MessageBox.Show($"La imagen de la plantilla '{plantilla}' no está disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var fontRegular = new PdfSharp.Drawing.XFont("Arial", 10, XFontStyleEx.Regular);
                var fontBold = new PdfSharp.Drawing.XFont("Arial", 10, XFontStyleEx.Bold);

                // Información del cliente
                gfx.DrawString($"Cliente:", fontBold, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XPoint(50, 180));
                gfx.DrawString(txtCliente.Text, fontRegular, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XPoint(100, 180));

                gfx.DrawString($"Fecha:", fontBold, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XPoint(50, 200));
                gfx.DrawString(txtFecha.Text, fontRegular, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XPoint(100, 200));

                // Mostrar el texto del documento (Factura N o Cotización)
                gfx.DrawString("Documento:", fontBold, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XPoint(400, 180));
                gfx.DrawString(documentoTexto, fontRegular, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XPoint(480, 180));

                // Configuración de la tabla
                int startX = 50;
                int startY = 250;
                int rowHeight = 25;
                int[] colWidths = { 180, 70, 70, 60, 80 };

                string[] headers = { "PRODUCTO / SERVICIO", "CANTIDAD", "PRECIO", "IVA", "TOTAL" };

                int currentX = startX;
                for (int i = 0; i < headers.Length; i++)
                {
                    gfx.DrawRectangle(PdfSharp.Drawing.XBrushes.LightSkyBlue, currentX, startY, colWidths[i], rowHeight);
                    gfx.DrawRectangle(PdfSharp.Drawing.XPens.Black, currentX, startY, colWidths[i], rowHeight);
                    gfx.DrawString(headers[i], fontBold, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XPoint(currentX + 5, startY + 16));
                    currentX += colWidths[i];
                }

                int y = startY + rowHeight;
                foreach (DataGridViewRow fila in dgvFactura.Rows)
                {
                    if (fila.Cells["Descripcion"].Value != null)
                    {
                        currentX = startX;

                        string[] valores = {
                            fila.Cells["Descripcion"].Value.ToString(),
                            fila.Cells["Cantidad"].Value.ToString(),
                            fila.Cells["CostoUnitario"].Value.ToString(),
                            fila.Cells["Impuesto"].Value.ToString(),
                            fila.Cells["Importe"].Value.ToString()
                        };

                        for (int i = 0; i < valores.Length; i++)
                        {
                            gfx.DrawRectangle(PdfSharp.Drawing.XPens.Black, currentX, y, colWidths[i], rowHeight);
                            gfx.DrawString(valores[i], fontRegular, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XPoint(currentX + 5, y + 16));
                            currentX += colWidths[i];
                        }

                        y += rowHeight;
                    }
                }

                int totalStartY = y + 30;
                gfx.DrawLine(PdfSharp.Drawing.XPens.Black, 400, totalStartY - 10, 580, totalStartY - 10);

                gfx.DrawString("Subtotal:", fontBold, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XPoint(400, totalStartY));
                gfx.DrawString(txtSubTotal.Text, fontRegular, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XPoint(500, totalStartY));

                gfx.DrawString("IVA (15%):", fontBold, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XPoint(400, totalStartY + 20));
                gfx.DrawString(txtImpuesto.Text, fontRegular, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XPoint(500, totalStartY + 20));

                gfx.DrawString("Total:", fontBold, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XPoint(400, totalStartY + 40));
                gfx.DrawString(txtTotal.Text, fontBold, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XPoint(500, totalStartY + 40));

                string rutaPDF = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "Documento.pdf");
                documento.Save(rutaPDF);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = rutaPDF,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarFacturasPendientesYAgregarServicio(int clienteId)
        {
            dgvFactura.Rows.Clear();
            facturaid = 0;
            int idFactura = 0;

            using (SqlCommand cmd = new SqlCommand("sp_CargarFacturasPendientesPorCliente", cnx))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteId", clienteId);

                try
                {
                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("El cliente no tiene facturas pendientes.");
                            return;
                        }

                        while (reader.Read())
                        {
                            if (facturaid == 0)
                            {
                                facturaid = Convert.ToInt32(reader["Facturas_id"]);
                                MessageBox.Show("Factura id: " + facturaid);
                            }

                            int servicioId = Convert.ToInt32(reader["Servicio_id"]);
                            string descripcion = reader["ServicioNombre"].ToString();
                            int cantidad = Convert.ToInt32(reader["Cantidad"]);
                            decimal costo = Convert.ToDecimal(reader["Costo_unitario"]);
                            decimal impuesto = Convert.ToDecimal(reader["Impuesto"]);
                            decimal total = costo * cantidad * (1 + impuesto);

                            dgvFactura.Rows.Add(servicioId, "Servicio", descripcion, cantidad, costo, impuesto, null, total);
                        }
                        if (dgvFactura.Rows.Count > 0 && !dgvFactura.Rows[dgvFactura.Rows.Count - 1].IsNewRow)
                        {
                            facturaid = Convert.ToInt32(dgvFactura.Rows[0].Cells["Facturas_id"].Value);

                        }

                    }

                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error al cargar la factura pendiente: " + ex.Message);
                    //return;
                }
                finally
                {
                    cnx.Close();
                }

            }
        }


        private void LimpiarControles()
        {
            facturaid = 0;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }

            foreach (Control control in this.Controls)
            {
                if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
            }

            dgvFactura.Rows.Clear();


            clienteId = 0;


            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void BtnCotizacion_Click(object sender, EventArgs e)
        {
            GenerarPDF("plantillaCotizacion");
            LimpiarControles();
        }
        private void PagarFacturaPendiente()
        {
            if (dgvFactura.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto o servicio a la factura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID de la factura pendiente (debes tenerlo disponible en tu formulario)


            if (facturaid == 0)
            {
                MessageBox.Show("No se ha seleccionado una factura pendiente para pagar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                        int empleadoId = Convert.ToInt32(fila.Cells["Empleado"].Value);
                        serviciosXml += $"<Service Id='{id}' Cantidad='{cantidad}' CostoUnitario='{costoUnitario}' Impuesto='{impuesto}' EmpleadoId='{empleadoId}' />";
                    }
                }
            }

            productosXml += "</Items>";
            serviciosXml += "</Items>";

            try
            {
                cnx.Open();

                using (SqlCommand cmd = new SqlCommand("SPPagarFacturaPendiente", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FacturaId", facturaid);
                    cmd.Parameters.AddWithValue("@ClienteId", clienteId);
                    cmd.Parameters.AddWithValue("@Fecha", fechaFactura);
                    cmd.Parameters.AddWithValue("@Estado", "Finalizado");
                    cmd.Parameters.AddWithValue("@Metodo_pago", metodoPago);
                    cmd.Parameters.AddWithValue("@Abonado", total);
                    cmd.Parameters.AddWithValue("@ProductosXml", productosXml);
                    cmd.Parameters.AddWithValue("@ServiciosXml", serviciosXml);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Factura pagada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al pagar la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnx.Close();
                GenerarPDF("plantillaFactura");
                LimpiarControles();
            }
        }
    }

}

