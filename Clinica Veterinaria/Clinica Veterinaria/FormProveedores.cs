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
    public partial class FormProveedores : Form
    {
        SqlConnection cnx;
        SqlDataAdapter adpProveedores;
        DataTable tabProveedores;

        public FormProveedores(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;

        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }
        private void CargarProveedores()
        {
            try
            {
                if (cnx.State != ConnectionState.Open)
                {
                    cnx.Open();
                }

                adpProveedores = new SqlDataAdapter("ObtenerProveedores", cnx);
                adpProveedores.SelectCommand.CommandType = CommandType.StoredProcedure;

                tabProveedores = new DataTable();
                adpProveedores.Fill(tabProveedores);
                dataGridView1.DataSource = tabProveedores;

                dataGridView1.Columns["Proveedor_id"].Width = 128;
                dataGridView1.Columns["Nombre"].Width = 150;
                dataGridView1.Columns["Telefono"].Width = 100;
                dataGridView1.Columns["Direccion"].Width = 200;
                dataGridView1.Columns["Correo"].Width = 150;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            FormAgProveedores registro = new FormAgProveedores(cnx);
            if (registro.ShowDialog() == DialogResult.OK)
            {
                CargarProveedores();
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataRowView fila = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
                FormAgProveedores formEdit = new FormAgProveedores(cnx, fila);

                if (formEdit.ShowDialog() == DialogResult.OK)
                {
                    CargarProveedores();
                }
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Proveedor_id"].Value);
                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este proveedor?", "Confirmar", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Asegurarse de que la conexión esté abierta
                        if (cnx.State != ConnectionState.Open)
                        {
                            cnx.Open();
                        }

                        using (SqlCommand cmd = new SqlCommand("EliminarProveedor", cnx))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Proveedor_id", id);
                            cmd.ExecuteNonQuery();

                            //MessageBox.Show("Proveedor eliminado correctamente.");
                            CargarProveedores();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar proveedor: " + ex.Message);
                    }
                    finally
                    {
                        // Cerrar la conexión si ya no se necesita
                        if (cnx.State == ConnectionState.Open)
                        {
                            cnx.Close();
                        }
                    }
                }
            }
        }
    }
}
