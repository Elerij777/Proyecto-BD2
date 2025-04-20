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
    public partial class FormSeleccionarProveedor : Form
    {
        SqlConnection cnx;
        private object formOrigen;
        public FormSeleccionarProveedor(SqlConnection cnx, object formularioOrigen)
        {
            InitializeComponent();
            this.cnx = cnx;
            this.formOrigen = formularioOrigen;
            CargarProveedor("");
        }
        private void CargarProveedor(string filtro)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spCargarProveedores", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@Filtro", string.IsNullOrEmpty(filtro) ? (object)DBNull.Value : filtro);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvProveedor.DataSource = dt;

                    dgvProveedor.Columns["Proveedor_id"].HeaderText = "ID";
                    dgvProveedor.Columns["Nombre"].HeaderText = "Nombre";
                    dgvProveedor.Columns["Correo"].HeaderText = "Correo";
                    dgvProveedor.Columns["Telefono"].HeaderText = "Telefono";
                    dgvProveedor.Columns["Direccion"].HeaderText = "Direccion";

                    dgvProveedor.Columns["Proveedor_id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.CurrentRow != null)
            {
                int idProveedor = Convert.ToInt32(dgvProveedor.CurrentRow.Cells["Proveedor_id"].Value);
                string nombreProveedor = dgvProveedor.CurrentRow.Cells["Nombre"].Value.ToString();

                if (formOrigen is FormCompras formCompras)
                {
                    formCompras.ProveedorId = idProveedor;
                    formCompras.txtProveedorSetText(nombreProveedor);
                }
               else if (formOrigen is FormCompraExistente formCompraExistente)
                {
                    formCompraExistente.ProveedorId = idProveedor;
                    formCompraExistente.txtProveedorSetText(nombreProveedor);
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Proveedor.", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarProveedor(txtBuscar.Text.Trim());
        }

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
