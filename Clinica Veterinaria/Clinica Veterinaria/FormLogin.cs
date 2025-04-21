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
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = Encriptar.GetSHA256(txtPassword.Text);

            try
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("SELECT Usuario, Rol FROM Usuarios WHERE Usuario = @usuario AND Contraseña = @password", cnx);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string rol = reader["Rol"].ToString();
                    this.DialogResult = DialogResult.OK; // Indica que el login fue exitoso
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
                reader.Close();
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

