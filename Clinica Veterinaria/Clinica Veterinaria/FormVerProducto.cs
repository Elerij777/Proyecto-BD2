using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;


namespace Clinica_Veterinaria
{
    public partial class FormVerProducto : Form
    {
        private SqlConnection cnx;
        private DataTable dtProductos;
        SqlDataAdapter adpProductos;

        public FormVerProducto(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
            dataGridView1.AllowUserToDeleteRows = true;
            ConfigurarDataAdapter();
            CargarProductos("");
        }

        public void ConfigurarDataAdapter()
        {
            try
            {
                adpProductos = new SqlDataAdapter("spObtenerProductos", cnx);
                adpProductos.SelectCommand.CommandType = CommandType.StoredProcedure;

                adpProductos.InsertCommand = new SqlCommand("spInsertarProducto", cnx);
                adpProductos.InsertCommand.CommandType = CommandType.StoredProcedure;
                adpProductos.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50, "Nombre");
                adpProductos.InsertCommand.Parameters.Add("@Existencias", SqlDbType.Int, 4, "Existencias");
                adpProductos.InsertCommand.Parameters.Add("@Costo", SqlDbType.Decimal, 10, "Costo");
                adpProductos.InsertCommand.Parameters.Add("@Precio", SqlDbType.Decimal, 10, "Precio");
                adpProductos.InsertCommand.Parameters.Add("@Fecha_caducidad", SqlDbType.DateTime, 0, "Fecha_caducidad");
                adpProductos.InsertCommand.Parameters.Add("@Tipo_producto", SqlDbType.VarChar, 50, "Tipo_producto");

                adpProductos.UpdateCommand = new SqlCommand("spActualizarProducto", cnx);
                adpProductos.UpdateCommand.CommandType = CommandType.StoredProcedure;
                adpProductos.UpdateCommand.Parameters.Add("@ProductoID", SqlDbType.Int, 4, "Producto_ID");
                adpProductos.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50, "Nombre");
                adpProductos.UpdateCommand.Parameters.Add("@Existencias", SqlDbType.Int, 4, "Existencias");
                adpProductos.UpdateCommand.Parameters.Add("@Costo", SqlDbType.Decimal, 10, "Costo");
                adpProductos.UpdateCommand.Parameters.Add("@Precio", SqlDbType.Decimal, 10, "Precio");
                adpProductos.UpdateCommand.Parameters.Add("@Fecha_caducidad", SqlDbType.DateTime, 0, "Fecha_caducidad");
                adpProductos.UpdateCommand.Parameters.Add("@Tipo_producto", SqlDbType.VarChar, 50, "Tipo_producto");

                adpProductos.DeleteCommand = new SqlCommand("spEliminarProducto", cnx);
                adpProductos.DeleteCommand.CommandType = CommandType.StoredProcedure;
                adpProductos.DeleteCommand.Parameters.Add("@ProductoID", SqlDbType.Int, 4, "Producto_ID");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al configurar el DataAdapter: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductos(string nombre)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spObtenerProductosPorNombre", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", nombre);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    dtProductos = new DataTable();
                    adapter.Fill(dtProductos);

                    dataGridView1.DataSource = dtProductos;

                    if (dataGridView1.Columns.Contains("Producto_ID"))
                    {
                        dataGridView1.Columns["Producto_ID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow row in dtProductos.Rows)
                {
                    if (row.RowState == DataRowState.Deleted) continue;

                    if (string.IsNullOrWhiteSpace(row["Nombre"]?.ToString()))
                    {
                        MessageBox.Show("El nombre no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (row["Existencias"] == DBNull.Value || Convert.ToInt32(row["Existencias"]) < 0)
                    {
                        MessageBox.Show("Las existencias no pueden ser negativas.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                int registrosAfectados = adpProductos.Update(dtProductos);
                dtProductos.Clear();
                adpProductos.Fill(dtProductos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(txtBuscador.Text.Trim());
        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                PdfDocument documento = new PdfDocument();
                documento.Info.Title = "Inventario";

                int productosPorPagina = 20; // Máximo de productos por página
                int totalProductos = dtProductos.Rows.Count;
                int paginas = (int)Math.Ceiling((double)totalProductos / productosPorPagina);

                for (int paginaActual = 0; paginaActual < paginas; paginaActual++)
                {
                    PdfPage pagina = documento.AddPage();
                    pagina.Orientation = PdfSharp.PageOrientation.Portrait;

                    XGraphics gfx = XGraphics.FromPdfPage(pagina);

                    // Carga la imagen base de la plantilla
                    if (Properties.Resources.plantillaInventario != null)
                    {
                        using (var stream = new System.IO.MemoryStream())
                        {
                            Properties.Resources.plantillaInventario.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                            XImage imagenFondo = XImage.FromStream(stream);
                            gfx.DrawImage(imagenFondo, 0, 0, pagina.Width, pagina.Height);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La imagen de plantilla no está disponible en los recursos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Fuentes
                    XFont fuenteSubtitulo = new XFont("Arial", 20, XFontStyleEx.Bold);
                    XFont fuenteTexto = new XFont("Arial", 12, XFontStyleEx.Regular);

                    // Fecha actual
                    string fechaActual = DateTime.Now.ToString("dd/MM/yyyy");
                    gfx.DrawString($"Fecha: {fechaActual}", fuenteTexto, XBrushes.SteelBlue, new XPoint(60, 110));

                    // Subtítulo
                    gfx.DrawString("Listado de Productos", fuenteSubtitulo, XBrushes.SteelBlue, new XPoint(60, 170));

                    // Cantidad de productos
                    gfx.DrawString($"Cantidad de productos: {totalProductos}", fuenteTexto, XBrushes.SteelBlue, new XPoint(60, 190));

                    // Coordenadas iniciales para la tabla
                    double xInicio = 50;
                    double yInicio = 220;
                    double anchoColumnaNombre = 200; // Más ancho para "Nombre"
                    double anchoColumnaPequena = 70; // Más estrecho para "Costo" y "Precio"
                    double altoFila = 20;

                    // Dibujar encabezados de la tabla
                    string[] encabezados = { "Nombre", "Existencias", "Costo", "Precio", "Caducidad" };
                    double[] anchosColumnas = { anchoColumnaNombre, anchoColumnaPequena, anchoColumnaPequena, anchoColumnaPequena, anchoColumnaPequena + 30 };

                    double xActual = xInicio;
                    for (int i = 0; i < encabezados.Length; i++)
                    {
                        gfx.DrawRectangle(XPens.Black, XBrushes.SkyBlue, xActual, yInicio, anchosColumnas[i], altoFila);
                        gfx.DrawString(encabezados[i], fuenteTexto, XBrushes.Black, new XRect(xActual, yInicio, anchosColumnas[i], altoFila), XStringFormats.Center);
                        xActual += anchosColumnas[i];
                    }

                    // Dibujar filas de la tabla
                    yInicio += altoFila; // Mover hacia abajo para las filas
                    int inicio = paginaActual * productosPorPagina;
                    int fin = Math.Min(inicio + productosPorPagina, totalProductos);

                    for (int i = inicio; i < fin; i++)
                    {
                        DataRow row = dtProductos.Rows[i];
                        xActual = xInicio;
                        for (int j = 0; j < encabezados.Length; j++)
                        {
                            string valor = j switch
                            {
                                0 => row["Nombre"].ToString(),
                                1 => row["Existencias"].ToString(),
                                2 => string.Format("{0:C2}", row["Costo"]),
                                3 => string.Format("{0:C2}", row["Precio"]),
                                4 => Convert.ToDateTime(row["Fecha_caducidad"]).ToString("dd/MM/yyyy"),
                                _ => ""
                            };

                            gfx.DrawRectangle(XPens.Black, xActual, yInicio, anchosColumnas[j], altoFila);
                            gfx.DrawString(valor, fuenteTexto, XBrushes.Black, new XRect(xActual, yInicio, anchosColumnas[j], altoFila), XStringFormats.Center);
                            xActual += anchosColumnas[j];
                        }
                        yInicio += altoFila;
                    }
                }

                // Guardar el PDF en una ruta temporal
                string rutaTemporal = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "Inventario.pdf");
                documento.Save(rutaTemporal);

                // Abrir el PDF
                Process.Start(new ProcessStartInfo
                {
                    FileName = rutaTemporal,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
