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
    public partial class FormAgProveedores : Form
    {
        SqlConnection cnx;
        private int proveedorId = -1;
        public FormAgProveedores(SqlConnection conexion)
        {
            InitializeComponent();
            cnx = conexion;
        }

        public FormAgProveedores(SqlConnection conexion, DataRowView proveedor) : this(conexion)
        {
            if (proveedor != null)
            {
                try
                {
                    proveedorId = Convert.ToInt32(proveedor["Proveedor_id"]);
                    txtNombre.Text = proveedor["Nombre"].ToString();
                    txtTelefono.Text = proveedor["Telefono"].ToString();
                    txtDireccion.Text = proveedor["Direccion"].ToString();
                    txtCorreo.Text = proveedor["Correo"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos del proveedor: " + ex.Message);
                }
            }
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    if (cnx.State != ConnectionState.Open)
                    {
                        cnx.Open();
                    }

                    SqlCommand cmd;

                    if (proveedorId == -1)
                    {
                        cmd = new SqlCommand("InsertarProveedor", cnx);
                    }
                    else
                    {
                        cmd = new SqlCommand("ActualizarProveedor", cnx);
                        cmd.Parameters.AddWithValue("@Proveedor_id", proveedorId);
                    }

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text.Trim());
                    cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text.Trim());

                    cmd.ExecuteNonQuery();

                    if (proveedorId == -1)
                    {
                        LimpiarCampos();
                        txtNombre.Focus(); 
                        //MessageBox.Show("Proveedor agregado correctamente.", "Éxito",
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                       // MessageBox.Show("Proveedor actualizado correctamente.", "Éxito",
                      //  MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (cnx.State == ConnectionState.Open)
                    {
                        cnx.Close();
                    }
                }
            }
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return false;
            }
            return true;
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            proveedorId = -1;
        }
    }
}