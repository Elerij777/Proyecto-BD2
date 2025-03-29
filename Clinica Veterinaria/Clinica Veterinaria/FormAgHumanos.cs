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
        public FormAgHumanos()
        {
            InitializeComponent();
            centrar_label();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
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
                string query = "INSERT INTO Clientes (Nombre, Telefono, Direccion) VALUES (@nombre, @telefono, @direccion)";

                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@direccion", direccion);

                    cnx.Open();
                    int result = cmd.ExecuteNonQuery();
                    cnx.Close();

                    if (result > 0)
                    {
                        MessageBox.Show("Cliente registrado con éxito.", "✅ Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombre.Clear();
                        txtTelefono.Clear();
                        txtDireccion.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el cliente.", "❌ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el cliente: " + ex.Message, "❌ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
