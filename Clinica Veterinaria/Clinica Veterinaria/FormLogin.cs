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


namespace Clinica_Veterinaria
{
    public partial class FormLogin : Form
    {
        SqlConnection cnx;
        public FormLogin()
        {
            InitializeComponent();
            String url = "Server=3.128.144.165,1433;Database=DB20212021280;User Id=erick.turcios;Password=ET20212021280;TrustServerCertificate=True;";
            cnx = new SqlConnection(url);
            //SetPlaceholder(txtUsuario, "Usuario");
            //SetPlaceholder(txtPassword, "Contraseña");
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



        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = Encriptar.GetSHA256(txtPassword.Text);
            try
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("SELECT dbo.FInicioSesion(@usuario)", cnx);
                cmd.Parameters.AddWithValue("@usuario", usuario);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    int inicioSesion = Convert.ToInt32(result);

                    if (inicioSesion == 0)
                    {
                        FormNuevaContra formNuevaContra = new FormNuevaContra(cnx, usuario);
                        formNuevaContra.ShowDialog();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else if (inicioSesion == 1)
                    {
                        // Validar el login con SPLogin
                        SqlCommand cmd2 = new SqlCommand("SPLogin", cnx);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@usuario", usuario);
                        cmd2.Parameters.AddWithValue("@password", password);

                        SqlDataReader reader2 = cmd2.ExecuteReader();
                        if (reader2.Read())
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsuario.Clear();
                            txtPassword.Clear();
                            txtUsuario.Focus();
                        }
                        reader2.Close();
                    }
                    else
                    {
                        MessageBox.Show("Estado de inicio de sesión desconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

