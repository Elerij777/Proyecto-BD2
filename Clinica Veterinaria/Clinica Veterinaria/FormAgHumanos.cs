using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clinica_Veterinaria
{
    public partial class FormAgHumanos : Form
    {
        SqlConnection cnx;

        public FormAgHumanos(SqlConnection cnx)
        {
            this.cnx = cnx;
            InitializeComponent();
            centrar_label();
        }
        public int IdHumano { get; set; }
        public bool ModoEdicion { get; set; } = false;
        public void centrar_label() 
        {
            labelPrincipal.Left = (this.panelPrincipal.Width - labelPrincipal.Width) / 2;
            labelPrincipal.Top = (this.panelPrincipal.Height - labelPrincipal.Height) / 2;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string direccion = txtDireccion.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Nombre y Teléfono son obligatorios.", "⚠️ Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand(ModoEdicion ? "spActualizarHumano" : "spInsertarHumano", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (ModoEdicion)
                    {
                        cmd.Parameters.AddWithValue("@id", IdHumano);
                    }

                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@direccion", direccion);

                    cnx.Open();
                    int result = cmd.ExecuteNonQuery();
                    cnx.Close();

                    if (result > 0)
                    {
                        MessageBox.Show(ModoEdicion ? "Cliente actualizado con éxito." : "Cliente registrado con éxito.",
                                      "✅ Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo completar la operación.", "❌ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el cliente: " + ex.Message, "❌ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Agrega estas propiedades al FormAgHumanos
        public string Nombre
        {
            get { return txtNombre.Text; }
            set { txtNombre.Text = value; }
        }

        public string Telefono
        {
            get { return txtTelefono.Text; }
            set { txtTelefono.Text = value; }
        }

        public string Direccion
        {
            get { return txtDireccion.Text; }
            set { txtDireccion.Text = value; }
        }
    }
}
