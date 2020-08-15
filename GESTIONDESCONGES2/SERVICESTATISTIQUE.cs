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
    public partial class SERVICESTATISTIQUE : Form
    {
        public SERVICESTATISTIQUE()
        {
            InitializeComponent();
        }
        CBASE c = new CBASE();
        SqlDataAdapter da;
        SqlDataAdapter da2;
        DataSet ds;
        private void SERVICESTATISTIQUE_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from devision",c.con);
            da2 = new SqlDataAdapter("select * from service", c.con);
            ds = new DataSet();
            da.Fill(ds, "devision");
            da2.Fill(ds, "service");

            ds.Tables["devision"].Constraints.Add("devisionID_pk", ds.Tables["devision"].Columns["id_devision"], true);
            ds.Relations.Add("devision_service", ds.Tables["devision"].Columns["id_devision"], ds.Tables["service"].Columns["id_devision"]);
            dataGridView1.DataSource = ds.Tables["devision"];

            childData(0);
        }
        public void childData(int rowIndex)
        {
            var parentRow = ds.Tables["devision"].Rows[rowIndex];
            var childRow = parentRow.GetChildRows("devision_service");
            DataTable childTable = ds.Tables["service"].Clone();
            foreach (var row in childRow)
            {
                childTable.ImportRow(row);
            }
            dataGridView2.DataSource = childTable;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            childData(dataGridView1.CurrentRow.Index);
        }
    }
}
