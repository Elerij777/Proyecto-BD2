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
    public partial class FormRegister : Form
    {
        private SqlConnection cnx;
        public FormRegister(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;

        }

    }
}
