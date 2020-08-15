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
    public partial class DEVISIONDESSERVICES : Form
    {
        public DEVISIONDESSERVICES()
        {
            InitializeComponent();
        }
        CBASE c = new CBASE();
        SqlDataAdapter da1;
        SqlDataAdapter da2;
        DataSet ds;
        private void DEVISIONDESSERVICES_Load(object sender, EventArgs e)
        {
            binding_S();
            remplire_combo_id_division();

            chargerGrid_S();

            // Autocomplete();
            groupBox3.Visible = false;
            chargerGrid_D();
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }
        public void chargerGrid_D()
        {
            c.connecter();
            SqlCommand cmd = new SqlCommand("select Id_devision,libelle_D_FR,libelle_D_AR from devision", c.con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            Data_division.DataSource = dt;
            c.deconnecter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                c.connecter();
                SqlCommand cmd = new SqlCommand("insert into devision values('" + idDevision.Text + "','" + devision.Text.Replace("'", "''") + "','" + devisionAR.Text + "')", c.con);

                cmd.ExecuteNonQuery();
                c.deconnecter();
                chargerGrid_D();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.connecter();
            SqlCommand cmd = new SqlCommand("update devision set libelle_D_FR='" + devision.Text + "', libelle_D_AR='" + devisionAR.Text + "' where Id_devision='" + idDevision.Text + "'", c.con);
            cmd.ExecuteNonQuery();
            c.deconnecter();
            chargerGrid_D();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimer c'ette devision", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c.connecter();
                SqlCommand cmd = new SqlCommand("delete devision where Id_devision='" + idDevision.Text + "'", c.con);
                cmd.ExecuteNonQuery();
                c.deconnecter();
                chargerGrid_D();
            }
        }

        private void Data_division_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Data_division.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    Data_division.CurrentRow.Selected = true;
                    idDevision.Text = Data_division.Rows[e.RowIndex].Cells["Id_devision"].FormattedValue.ToString();
                    devision.Text = Data_division.Rows[e.RowIndex].Cells["libelle_D_FR"].FormattedValue.ToString();
                    devisionAR.Text = Data_division.Rows[e.RowIndex].Cells["libelle_D_AR"].FormattedValue.ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (tidservice.Text != "" && tservice.Text != "" && tserviceAR.Text != "" && checkBox2.Checked == false)
                {
                    insert_service();
                }
                else
                if (checkBox2.Checked == true && tid_devision.Text != "")

                {
                    insert_service_devision();
                }

                button7.Enabled = false;
                button5.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                chargerGrid_S();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void chargerGrid_S()
        {

            SqlCommand cmd = new SqlCommand("select * from service", c.con);
            c.connecter();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            Data_Service.DataSource = dt;
            dr.Close();
            c.deconnecter();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (groupBox3.Visible == false)
            {
                groupBox3.Visible = true;
            }
            else
            {
                groupBox3.Visible = false;
            }
        }
        public void remplire_combo_id_division()
        {

            SqlCommand cmd = new SqlCommand("select * from devision", c.con);
            c.connecter();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tid_devision.Items.Add(dr[0].ToString());
            }
            dr.Close();
            c.deconnecter();
        }
        public void insert_service_devision()
        {
            try
            {

                c.connecter();
                SqlCommand cmd = new SqlCommand("insert into service(id_service,libelle_S_FR,libelle_S_AR,id_devision) values('" + tidservice.Text + "','" + tservice.Text.Replace("'", "''") + "','" + tserviceAR.Text + "','" + tid_devision.Text + "')", c.con);
                cmd.ExecuteNonQuery();
                c.deconnecter();
            }
            catch (Exception)
            {

                MessageBox.Show("erreur d'insertion");
            }

        }
        //insert service only
        public void insert_service()
        {


            try
            {
                SqlCommand cmd = new SqlCommand("insert into service(id_service,libelle_S_FR,libelle_S_AR) values('" + tidservice.Text + "','" + tservice.Text.Replace("'", "''") + "','" + tserviceAR.Text + "')", c.con);
                c.connecter();
                cmd.ExecuteNonQuery();
                c.deconnecter();
                chargerGrid_S();
            }
            catch (Exception)
            {

                MessageBox.Show("erreur d'insertion");
            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous supprimer le service ?", "Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    c.connecter();
                    SqlCommand cmd = new SqlCommand("delete service where id_service='" + tidservice.Text + "'", c.con);
                    cmd.ExecuteNonQuery();
                    c.deconnecter();
                    chargerGrid_S();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur de suppresion");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous Modifier le service ?", "Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c.connecter();
                SqlCommand cmd = new SqlCommand("update service set libelle_S_FR='" + tservice.Text + "',libelle_S_AR='" + tserviceAR.Text + "' where id_service='" + tidservice.Text + "'", c.con);
                cmd.ExecuteReader();
                c.deconnecter();
                chargerGrid_S();
            }
        }

        private void Data_Service_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Data_Service.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    Data_Service.CurrentRow.Selected = true;
                    tidservice.Text = Data_Service.Rows[e.RowIndex].Cells["id_service"].FormattedValue.ToString();
                    tservice.Text = Data_Service.Rows[e.RowIndex].Cells["libelle_S_FR"].FormattedValue.ToString();
                    tserviceAR.Text = Data_Service.Rows[e.RowIndex].Cells["libelle_S_AR"].FormattedValue.ToString();
                    tid_devision.Text = Data_Service.Rows[e.RowIndex].Cells["id_devision"].FormattedValue.ToString();
                    button5.Enabled = true;
                    button4.Enabled = true;
                    button6.Enabled = true;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tid_devision_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from devision where id_devision='" + tid_devision.Text + "'", c.con);
            c.connecter();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string devFR = (string)dr[1].ToString();
                tdevisionFR.Text = devFR;
                string devAR = (string)dr[2].ToString();
                tdevisionAR.Text = devAR;

            }
            dr.Close();
            c.deconnecter();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tidservice.Clear();
            tservice.Clear();
            tserviceAR.Clear();
            checkBox2.Checked = false;
            tid_devision.Text = "";
            tdevisionFR.Clear();
            tdevisionAR.Clear();
            button7.Enabled = true;
            button6.Enabled = false;
            button5.Enabled = false;
            button4.Enabled = false;
        }
        public void binding_S()
        {
            //////////////////////////////////////////////////////
            da1 = new SqlDataAdapter("select * from devision", c.con);
            da2 = new SqlDataAdapter("select * from service", c.con);
            ds = new DataSet();
            da1.Fill(ds, "devision_");
            da2.Fill(ds, "service_");

            ds.Tables["devision_"].Constraints.Add("devisionID_pk", ds.Tables["devision_"].Columns["id_devision"], true);
            ds.Relations.Add("devision_service", ds.Tables["devision_"].Columns["id_devision"], ds.Tables["service_"].Columns["id_devision"]);
            Data_all.DataSource = ds.Tables["devision_"];

            childData(0);
            //////////////////////////////////////////////////////
        }
        public void childData(int rowIndex)
        {
            var parentRow = ds.Tables["devision_"].Rows[rowIndex];
            var childRow = parentRow.GetChildRows("devision_service");
            DataTable childTable = ds.Tables["service_"].Clone();
            foreach (var row in childRow)
            {
                childTable.ImportRow(row);
            }
            Data_all_contant.DataSource = childTable;
        }

        private void Data_all_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Data_all_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            childData(Data_all.CurrentRow.Index);
        }
        public void service_N()
        {
            c.connecter();
            SqlDataAdapter da = new SqlDataAdapter("select * from service s where s.id_devision is null", c.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            c.deconnecter();
            Data_all_contant.DataSource = dt;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                service_N();
                Data_all.Enabled = false;
            }
            else
            {
                binding_S();
                Data_all.Enabled = true;
            }
        }
    }
}
