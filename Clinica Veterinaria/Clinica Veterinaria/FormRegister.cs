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
using System.Runtime.InteropServices;

namespace Clinica_Veterinaria
{
    public partial class FormRegister : Form
    {
        private SqlConnection cnx;
        public FormRegister(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
            centrar_label();
            SetPlaceholder(txtNombre, "Nombre");
            SetPlaceholder(txtApellido, "Apellido");

        }

        private void SetPlaceholder(TextBox textbox, string placeholder)
        {
            textbox.Text = placeholder;
            textbox.ForeColor = Color.Gray;

            textbox.Enter += (sender, e) =>
            {
                if (textbox.Text == placeholder)
                {
                    textbox.Text = "";
                    textbox.ForeColor = Color.Black;
                }
            };

            textbox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textbox.Text))
                {
                    textbox.Text = placeholder;
                    textbox.ForeColor = Color.Gray;
                }
            };
        }

        public void centrar_label()
        {
            labelPrincipal.Left = (this.panelPrincipal.Width - labelPrincipal.Width) / 2;
            labelPrincipal.Top = (this.panelPrincipal.Height - labelPrincipal.Height) / 2;
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRol.SelectedItem.ToString() == "Recepcionista")
            {
                cmbRol.Text = "Recepcionista";
            }
            else if (cmbRol.SelectedItem.ToString() == "Veterinario")
            {
                cmbRol.Text = "Veterinario";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string rol = cmbRol.Text.Trim();
            string password;

            try
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("SPAgregarUsuario", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@rol", rol);
                password = nombre[0].ToString().ToUpper() + apellido[0].ToString().ToUpper() + rol[0].ToString().ToUpper() + "Rintintin";
                cmd.Parameters.AddWithValue("@password", Encriptar.GetSHA256(password));
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("SPUltimoUsuario", cnx);
                cmd2.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd2.ExecuteReader();
                if (reader.Read())
                {
                    string usuario = reader["Usuario"].ToString();
                    MessageBox.Show($"Usuario agregado exitosamente.\nUsuario: {usuario}\nContraseña: {password}", "Credenciales Generadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }
    }
}
