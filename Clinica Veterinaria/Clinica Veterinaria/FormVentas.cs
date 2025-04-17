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
    public partial class FormVentas : Form
    {
        SqlConnection cnx;
        public FormVentas(SqlConnection cnx)
        {
            this.cnx = cnx;
            InitializeComponent();
        }
    }
}
