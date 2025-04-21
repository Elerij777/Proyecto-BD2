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
    public partial class FormNuevaContra : Form
    {
        private SqlConnection cnx;
        private string usuario;
        public FormNuevaContra(SqlConnection cnx, string usuario)
        {
            InitializeComponent();
            this.cnx = cnx;
            this.usuario = usuario;
        }

        private void bntAceptar_Click(object sender, EventArgs e)
        {
            string password = txtNewPass.Text;
            string passwordConfirm = txtConfrimPass.Text;
            try
            {
                if (password == passwordConfirm)
                {
                    if (password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsDigit) && password.Any(ch => !char.IsLetterOrDigit(ch)))
                    {
                        SqlCommand cmd = new SqlCommand("SPActualizarContraseña", cnx);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@password", Encriptar.GetSHA256(password));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Contraseña actualizada correctamente");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La contraseña debe tener al menos 8 caracteres, una mayúscula, un número y un carácter especial.");
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la contraseña: " + ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }

    }
}
