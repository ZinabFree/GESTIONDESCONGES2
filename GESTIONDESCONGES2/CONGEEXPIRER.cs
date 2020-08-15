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

namespace GESTIONDESCONGES2
{
    public partial class CONGEEXPIRER : Form
    {
        public CONGEEXPIRER()
        {
            InitializeComponent();
        }
        CBASE c = new CBASE();
        private void CONGEEXPIRER_Load(object sender, EventArgs e)
        {
            conges_expirer();
        }

        private void conges_expirer()
        {

            SqlCommand cmd = new SqlCommand("CONGEEXPIRER", c.con);
            cmd.CommandType = CommandType.StoredProcedure;
            c.connecter();
            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            c.deconnecter();
        }
    }
}
