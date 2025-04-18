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
    public partial class FormGrooming: Form
    {
        private SqlConnection cnx;
        public FormGrooming(SqlConnection cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
        }
    }
}
