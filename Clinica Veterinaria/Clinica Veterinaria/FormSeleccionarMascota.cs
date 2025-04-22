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
    public partial class FormSeleccionarMascota : Form
    {
        SqlConnection cnx;
        //FormAgHospedaje formAgHospedaje;
        private object formOrigen;
        public FormSeleccionarMascota(SqlConnection cnx, object formularioOrigen)
        {
            InitializeComponent();
            this.cnx = cnx;
            this.formOrigen = formularioOrigen;
            //this.formAgHospedaje = formAgHospedaje;
            CargarMascotas("");

        }

        private void CargarMascotas(string filtro)
        {
            /*try
            {
                // Consulta a la vista VistaMascotasConClientes
                string query = "SELECT * FROM VistaMascotasConClientes";

                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Asignar los datos al DataGridView
                    dgvMascotas.DataSource = dt;

                    // Configurar columnas del DataGridView
                    dgvMascotas.Columns["Mascota_id"].HeaderText = "ID";
                    dgvMascotas.Columns["NombreMascota"].HeaderText = "Nombre de la Mascota";
                    dgvMascotas.Columns["Especie"].HeaderText = "Especie";
                    dgvMascotas.Columns["Raza"].HeaderText = "Raza";
                    dgvMascotas.Columns["Peso"].HeaderText = "Peso (kg)";
                    dgvMascotas.Columns["Genero"].HeaderText = "Género";
                    dgvMascotas.Columns["Fecha_nacimiento"].HeaderText = "Fecha de Nacimiento";
                    dgvMascotas.Columns["NombreCliente"].HeaderText = "Nombre del Cliente";

                    // Opcional: Ocultar la columna MascotaID si no es necesaria
                    dgvMascotas.Columns["Mascota_id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las mascotas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            try
            {
                string query = "SELECT * FROM VistaMascotasyClientes";

                if (!string.IsNullOrEmpty(filtro))
                {
                    query += " WHERE NombreMascota LIKE @Filtro";
                }

                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {
                    if (!string.IsNullOrEmpty(filtro))
                    {
                        cmd.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                  
                    dgvMascotas.DataSource = dt;

                   
                    dgvMascotas.Columns["Mascota_id"].HeaderText = "ID";
                    dgvMascotas.Columns["NombreMascota"].HeaderText = "Nombre de la Mascota";
                    dgvMascotas.Columns["Especie"].HeaderText = "Especie";
                    dgvMascotas.Columns["Raza"].HeaderText = "Raza";
                    dgvMascotas.Columns["Peso"].HeaderText = "Peso (kg)";
                    dgvMascotas.Columns["Genero"].HeaderText = "Género";
                    dgvMascotas.Columns["Fecha_nacimiento"].HeaderText = "Fecha de Nacimiento";
                    dgvMascotas.Columns["NombreCliente"].HeaderText = "Nombre del Cliente";

                    
                    dgvMascotas.Columns["Mascota_id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las mascotas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            /* if (dgvMascotas.CurrentRow != null)
             {
                 int idMascota = Convert.ToInt32(dgvMascotas.CurrentRow.Cells["Mascota_ID"].Value);
                 string nombreMascota = dgvMascotas.CurrentRow.Cells["NombreMascota"].Value.ToString();
                 string EspecieMascota = dgvMascotas.CurrentRow.Cells["Especie"].Value.ToString();
                 formAgHospedaje.MascotaId = idMascota;
                 formAgHospedaje.txtMascotaSetText(nombreMascota);



                 this.Close();
             }
             else
             {
                 MessageBox.Show("Debe seleccionar una mascota.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
            */
            if (dgvMascotas.CurrentRow != null)
            {
                int idMascota = Convert.ToInt32(dgvMascotas.CurrentRow.Cells["Mascota_id"].Value);
                string nombreMascota = dgvMascotas.CurrentRow.Cells["NombreMascota"].Value.ToString();

                if (formOrigen is FormAgHospedaje formHospedaje)
                {
                    formHospedaje.MascotaId = idMascota;
                    formHospedaje.txtMascotaSetText(nombreMascota);
                }
                else if (formOrigen is FormClinica formClinica)
                {
                    formClinica.MascotaId = idMascota;
                    formClinica.txtMascotaSetText(nombreMascota);
                }
                else if (formOrigen is FormGrooming formGrooming)
                {
                    formGrooming.MascotaId = idMascota;
                    formGrooming.txtMascotaSetText(nombreMascota);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una mascota.", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarMascotas(txtBuscar.Text.Trim());
        }
    }
}
