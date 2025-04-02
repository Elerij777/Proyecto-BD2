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
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;

namespace Clinica_Veterinaria
{
    public partial class FormVerHumanos : Form
    {
        private SqlConnection cnx;
        private DataTable dtHumanos;

        public FormVerHumanos(SqlConnection conexion)
        {
            InitializeComponent();
            cnx = conexion;
            CargarHumanos();
        }

        private void CargarHumanos()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spObtenerHumanos", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dtHumanos = new DataTable();
                    da.Fill(dtHumanos);

                    dataGridView1.DataSource = dtHumanos;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar humanos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormVerHumanos_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgHumanos form = new FormAgHumanos(cnx);
            form.ShowDialog();
            CargarHumanos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un humano para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["Cliente_id"].Value);
            string nombre = row.Cells["Nombre"].Value.ToString();
            string telefono = row.Cells["Telefono"].Value.ToString();
            string direccion = row.Cells["Direccion"]?.Value?.ToString() ?? "";

            FormAgHumanos formEditar = new FormAgHumanos(cnx)
            {
                Text = "Editar Humano",
                Nombre = nombre,
                Telefono = telefono,
                Direccion = direccion,
                IdHumano = id,
                ModoEdicion = true
            };

            if (formEditar.ShowDialog() == DialogResult.OK)
            {
                CargarHumanos(); // Refrescar la lista
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un humano para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea eliminar este humano?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["Cliente_id"].Value);

                try
                {
                    using (SqlCommand cmd = new SqlCommand("spEliminarHumano", cnx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);

                        cnx.Open();
                        cmd.ExecuteNonQuery();
                        cnx.Close();

                        MessageBox.Show("Humano eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarHumanos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar humano: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}


