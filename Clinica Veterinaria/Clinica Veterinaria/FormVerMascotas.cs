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
    public partial class FormVerMascotas : Form
    {
        private SqlConnection cnx;
       

        public FormVerMascotas(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
         
            CargarMascotas(""); 
        }

        private void CargarMascotas(string busqueda)
        {
            try
            {
                
                using (SqlCommand cmd = new SqlCommand("spBuscarMascotasOClientes", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Busqueda", busqueda);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                   
                    dgvMascotas.DataSource = dt;

                    /
                    dgvMascotas.Columns["Mascota_ID"].HeaderText = "ID";
                    dgvMascotas.Columns["NombreMascota"].HeaderText = "Nombre de la Mascota";
                    dgvMascotas.Columns["Especie"].HeaderText = "Especie";
                    dgvMascotas.Columns["Raza"].HeaderText = "Raza";
                    dgvMascotas.Columns["Peso"].HeaderText = "Peso (kg)";
                    dgvMascotas.Columns["Genero"].HeaderText = "Género";
                    dgvMascotas.Columns["Fecha_Nacimiento"].HeaderText = "Fecha de Nacimiento";
                    dgvMascotas.Columns["NombreCliente"].HeaderText = "Nombre del Cliente";

                    dgvMascotas.Columns["Mascota_ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las mascotas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            CargarMascotas(txtBuscador.Text.Trim());
        }

        private void txtPdf_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que este seleccionado una en el dgv
                if (dgvMascotas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecciona una mascota para generar el PDF.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow filaSeleccionada = dgvMascotas.SelectedRows[0];
                string mascotaId = filaSeleccionada.Cells["Mascota_ID"].Value.ToString();
                string nombreMascota = filaSeleccionada.Cells["NombreMascota"].Value.ToString();
                string duenio = filaSeleccionada.Cells["NombreCliente"].Value.ToString();
                string genero = filaSeleccionada.Cells["Genero"].Value.ToString() == "M" ? "Masculino" : "Femenino";
                string raza = filaSeleccionada.Cells["Raza"].Value.ToString();
                string nacimiento = DateTime.Parse(filaSeleccionada.Cells["Fecha_Nacimiento"].Value.ToString()).ToString("dd/MM/yyyy");
                string domicilio = "Dirección del cliente";

                //convertidor de la imagen
                byte[] fotoMascota = ObtenerFotoMascotaDesdeBD(mascotaId);

                if (fotoMascota == null || fotoMascota.Length == 0)
                {
                    MessageBox.Show("La mascota seleccionada no tiene una foto asociada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

              
                PdfDocument documento = new PdfDocument();
                //No hagan caso a esto tenia que ponerle titulo ahuevo
                documento.Info.Title = "Documento Nacional de Identificación de Mascotas";

                
                PdfPage pagina = documento.AddPage();
                pagina.Orientation = PdfSharp.PageOrientation.Landscape;


                XGraphics gfx = XGraphics.FromPdfPage(pagina);

                // Carga la imagen base del DNI que deje en resources
                if (Properties.Resources.DNIMascotas != null)
                {
                    using (var stream = new System.IO.MemoryStream())
                    {
                        Properties.Resources.DNIMascotas.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                        XImage imagenFondo = XImage.FromStream(stream);

                        
                        gfx.DrawImage(imagenFondo, 0, 0, pagina.Width, pagina.Height);
                    }
                }
                else
                {
                    MessageBox.Show("La imagen DNIMascotas no está disponible en los recursos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Dibuja la imagen de la mascota en el PDF
                using (var streamFoto = new System.IO.MemoryStream(fotoMascota, 0, fotoMascota.Length, writable: false, publiclyVisible: true))
                {
                    //Recortado a medida no tocar
                    XImage xImagenMascota = XImage.FromStream(streamFoto);
                    gfx.DrawImage(xImagenMascota, 50, 150, 300, 300); 
                }

                // Fuentes que use para titulos y texto si quieren cambienle el nombre
                XFont fuenteTitulo = new XFont("Arial", 20, XFontStyleEx.Bold);
                XFont fuenteTexto = new XFont("Arial", 18, XFontStyleEx.Regular); 

                // NO MUEVAN NINGUNA COORDENADA ESTAN TODAS ADAPTADAS DE FORMA ADECUADA A LA IMAGEN
                gfx.DrawString("NOMBRE", fuenteTitulo, XBrushes.Black, new XPoint(400, 150));
                gfx.DrawString(nombreMascota, fuenteTexto, XBrushes.Black, new XPoint(400, 170));

                gfx.DrawString("DUEÑO", fuenteTitulo, XBrushes.Black, new XPoint(400, 200));
                gfx.DrawString(duenio, fuenteTexto, XBrushes.Black, new XPoint(400, 220));

                gfx.DrawString("GÉNERO", fuenteTitulo, XBrushes.Black, new XPoint(400, 250));
                gfx.DrawString(genero, fuenteTexto, XBrushes.Black, new XPoint(400, 270));

                gfx.DrawString("RAZA", fuenteTitulo, XBrushes.Black, new XPoint(400, 300));
                gfx.DrawString(raza, fuenteTexto, XBrushes.Black, new XPoint(400, 320));

                gfx.DrawString("NACIMIENTO", fuenteTitulo, XBrushes.Black, new XPoint(400, 350));
                gfx.DrawString(nacimiento, fuenteTexto, XBrushes.Black, new XPoint(400, 370));

                gfx.DrawString("DOMICILIO", fuenteTitulo, XBrushes.Black, new XPoint(400, 400));
                gfx.DrawString(domicilio, fuenteTexto, XBrushes.Black, new XPoint(400, 420));

                // Archivo temporal de pdf si lo quieren guardar denle guardar en su visor
                string rutaTemporal = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "MascotaDNI.pdf");
                documento.Save(rutaTemporal);

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

        //Aqui convierto la foto, tomenlo en cuenta pa otras cosas 
        private byte[] ObtenerFotoMascotaDesdeBD(string mascotaId)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Foto FROM Mascotas WHERE Mascota_ID = @MascotaId", cnx))
                {
                    cmd.Parameters.AddWithValue("@MascotaId", mascotaId);

                    cnx.Open();
                    object resultado = cmd.ExecuteScalar();
                    cnx.Close();

                    if (resultado != DBNull.Value)
                    {
                        return (byte[])resultado;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la foto de la mascota: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }

            return null;
        }
    }
}
