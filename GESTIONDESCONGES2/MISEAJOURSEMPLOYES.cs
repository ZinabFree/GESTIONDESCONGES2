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
    public partial class MISEAJOURSEMPLOYES : Form
    {
        public MISEAJOURSEMPLOYES()
        {
            InitializeComponent();
        }
        CBASE c = new CBASE();
        private void MISEAJOURSEMPLOYES_Load(object sender, EventArgs e)
        {
            tstatue.Items.Add("Admin");
            tstatue.Items.Add("Agent");
            chargerGrid();
            remplire_combo();
            charger_service();

            bupdate.Enabled = false;
            bdelete.Enabled = false;
           
            bnew.Enabled = false;
            tdure.Text = "0";
        }
        private void chargerGrid()
        {
            try
            {
                c.connecter();
                SqlCommand cmd = new SqlCommand("select N_dote,Nom_FR,Prenom_FR,Nom_AR,Prenom_AR,Grade_FR,Grade_AR,id_service,service_AR,duree_date_precedent,duree_date_actuel,statue from EMPLOYE ", c.con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                grid.DataSource = dt;
                c.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //methode verifier
        }
        public void verifier()
        {
            try
            {
                //con.Open();
                //SqlCommand cmd = new SqlCommand("select N_dote from employe where N_dote='" + tid.Text + "'", con);
                //SqlDataReader dr = cmd.ExecuteReader();
                //DataTable dt = new DataTable();
                //dt.Load(dr);
                //con.Close();
                //if (dt.Rows.Count > 0)
                //    MessageBox.Show("L'employé excist deja", "Important", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //else
                //{
                //    ajouter();
                //    chargerGrid();
                //}
                SqlDataAdapter da = new SqlDataAdapter("select N_dote from employe where N_dote='" + tid.Text + "'", c.con);
                DataSet ds = new DataSet();
                da.Fill(ds, "employe");
                if (ds.Tables["employe"].Rows.Count > 0)
                {
                    MessageBox.Show("L'employé exsiste deja", "Important", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ajouter();
                    chargerGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ajouter()
        {
            try
            {
                //SqlCommand cmd = new SqlCommand("insert into employe(N_dote,Nom_FR,Prenom_FR,Nom_AR,Prenom_AR,Grade_FR,Grade_AR,id_service,service_AR,duree_date_precedent,duree_date_actuel) values('" + tid.Text + "', '" + tnom.Text + "', '" + tprenom.Text + "', '" + tnomAR.Text + "', '" + tprenomAR.Text + "', '" + tgrade.Text + "', '" + tgradeAR.Text + "','" + tidservice.Text + "','" + tserviceAR.Text + "',0,'" + tdure.Text + "')", c.con);
                //c.connecter();
                //cmd.ExecuteNonQuery();
                //c.deconnecter();

                SqlCommand cmd = new SqlCommand("ADDEMPLOYES", c.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pndote = cmd.Parameters.Add("@Ndote", SqlDbType.Int);
                SqlParameter pnomFR = cmd.Parameters.Add("@NomFR", SqlDbType.VarChar, 50);
                SqlParameter pprenomFR = cmd.Parameters.Add("@PrenomFR", SqlDbType.VarChar, 50);
                SqlParameter pnomAR = cmd.Parameters.Add("@NomAR", SqlDbType.VarChar, 50);
                SqlParameter pprenomAR = cmd.Parameters.Add("@PrenomAR", SqlDbType.VarChar, 50);
                SqlParameter pgradeFR = cmd.Parameters.Add("@GradeFR", SqlDbType.VarChar, 50);
                SqlParameter pgradeAR = cmd.Parameters.Add("@GradeAR", SqlDbType.VarChar, 50);
                SqlParameter pserviceFR = cmd.Parameters.Add("@ServiceFR", SqlDbType.VarChar, 50);
                SqlParameter pserviceAR = cmd.Parameters.Add("@ServiceAR", SqlDbType.VarChar, 50);
                //SqlParameter plogin = cmd.Parameters.Add("@Login", SqlDbType.VarChar, 50);
                //SqlParameter ppass = cmd.Parameters.Add("@pass", SqlDbType.VarChar, 10);
                //SqlParameter pdateDP = cmd.Parameters.Add("@dureeDP", SqlDbType.VarChar, 10);
                SqlParameter pdureeDA = cmd.Parameters.Add("@DureDA", SqlDbType.Int);
                SqlParameter pstatue = cmd.Parameters.Add("@Statue", SqlDbType.VarChar, 50);
                SqlParameter pidService = cmd.Parameters.Add("@idS", SqlDbType.Int);
                SqlParameter preturnValue = cmd.Parameters.Add("@returnValue", SqlDbType.Int);

                pndote.Value = tid.Text;
                pnomFR.Value = tnom.Text;
                pprenomFR.Value = tprenom.Text;
                pnomAR.Value = tnomAR.Text;
                pprenomAR.Value = tprenomAR.Text;
                pgradeFR.Value = tgrade.Text;
                pgradeAR.Value = tgradeAR.Text;
                pserviceFR.Value = tservice.Text;
                pserviceAR.Value = tserviceAR.Text;
                //plogin.Value = tnom.Text +" "+ tprenom.Text;
                //ppass.Value = tnom.Text;
                //pdateDP.Value = 0;
                pdureeDA.Value = tdure.Text;
                pstatue.Value = tstatue.Text;
                pidService.Value = tidservice.Text;
                preturnValue.Direction = ParameterDirection.ReturnValue;
                c.connecter();
                cmd.ExecuteNonQuery();
                c.deconnecter();
                if (preturnValue.Value.ToString() == "1")
                {
                    MessageBox.Show("Employe Ajouter");
                }
                else
                {
                    MessageBox.Show("Numero dote existe deja");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void badd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tid.Text != "" && tnom.Text != "" && tprenom.Text != "" && tgrade.Text != "" && tservice.Text != "" && tnomAR.Text != "" && tprenomAR.Text != "" && tgradeAR.Text != "" && tdure.Text != "" && tservice.Text != "" && tserviceAR.Text != "" && tidservice.Text != "")
                {
                    ajouter();
                    chargerGrid();
                }
                else
                {
                    MessageBox.Show("Remplire tous les shamps SVP !", "Important", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            bupdate.Enabled = true;
            bdelete.Enabled = true;
            bsearch.Enabled = true;
            bnew.Enabled = true;
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    grid.CurrentRow.Selected = true;
                    tid.Text = grid.Rows[e.RowIndex].Cells["N_dote"].FormattedValue.ToString();
                    tnom.Text = grid.Rows[e.RowIndex].Cells["Nom_FR"].FormattedValue.ToString();
                    tprenom.Text = grid.Rows[e.RowIndex].Cells["Prenom_FR"].FormattedValue.ToString();
                    tgrade.Text = grid.Rows[e.RowIndex].Cells["Grade_FR"].FormattedValue.ToString();
                    tstatue.Text = grid.Rows[e.RowIndex].Cells["statue"].FormattedValue.ToString();
                    tnomAR.Text = grid.Rows[e.RowIndex].Cells["Nom_AR"].FormattedValue.ToString();
                    tprenomAR.Text = grid.Rows[e.RowIndex].Cells["Prenom_AR"].FormattedValue.ToString();
                    tgradeAR.Text = grid.Rows[e.RowIndex].Cells["Grade_AR"].FormattedValue.ToString();
                    tdure.Text = grid.Rows[e.RowIndex].Cells["duree_date_actuel"].FormattedValue.ToString();
                    tidservice.Text = grid.Rows[e.RowIndex].Cells["id_service"].FormattedValue.ToString();
                    //tservice.Text = grid.Rows[e.RowIndex].Cells["service_FR"].FormattedValue.ToString();
                    //tserviceAR.Text = grid.Rows[e.RowIndex].Cells["service_AR"].FormattedValue.ToString();
                }
                bupdate.Enabled = true;
                bdelete.Enabled = true;
                bsearch.Enabled = true;
                bnew.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void verifier_entier(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tid_KeyPress(object sender, KeyPressEventArgs e)
        {
            verifier_entier(e);
        }

        private void bupdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update employe set Nom_FR  ='" + tnom.Text + "',Prenom_FR ='" + tprenom.Text + "',Grade_FR ='" + tgrade.Text + "', Nom_AR ='" + tnomAR.Text + "',Prenom_AR ='" + tprenomAR.Text + "',Grade_AR ='" + tgradeAR.Text + "',id_service='" + tidservice.Text + "',Service_AR='" + tserviceAR.Text + "',duree_date_actuel='" + tdure.Text + "'where N_dote='" + tid.Text + "'", c.con);
            c.connecter();
            cmd.ExecuteNonQuery();
            c.deconnecter();
            chargerGrid();
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimer l'employé ?", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c.connecter();
                SqlCommand cmd = new SqlCommand("delete employe where N_dote='" + tid.Text + "'", c.con);
                cmd.ExecuteNonQuery();
                c.deconnecter();
                chargerGrid();
            }
        }

        private void bsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"data source=DESKTOP-L0UETLL ; initial catalog= GESTION_DES_CONGE2 ;integrated security=true");

            con1.Open();
            SqlCommand cmd = new SqlCommand("select * from employe where N_dote='" + tid.Text + "'", con1);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tnom.Text = dr[1].ToString();
                tprenom.Text = dr[2].ToString();
                tgrade.Text = dr[5].ToString();
                tnomAR.Text = dr[3].ToString();
                tprenomAR.Text = dr[4].ToString();
                tgradeAR.Text = dr[6].ToString();
                tdure.Text = dr[12].ToString();
                tidservice.Text = dr[16].ToString();
                tstatue.SelectedText = dr[13].ToString();
                //tservice.SelectedText = dr[7].ToString();
                //tserviceAR.Text = dr[8].ToString();   
                dr.Close();
            }

            else
                MessageBox.Show("Enixiste !");
            con1.Close();
        }

        private void tidservice_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from service", c.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "service");
            for (int i = 0; i < ds.Tables["service"].Rows.Count; i++)
            {
                if (tidservice.SelectedItem.Equals(ds.Tables["service"].Rows[i][0]))
                {
                    tservice.Text = ds.Tables["service"].Rows[i][1].ToString();
                    tserviceAR.Text = ds.Tables["service"].Rows[i][2].ToString();
                }
            }
        }
        public void Autocomplete()
        {

            SqlCommand cmd = new SqlCommand("select * from service", c.con);
            c.connecter();
            SqlDataReader dr = cmd.ExecuteReader();

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                auto.Add(dr.GetString(1));
            }
            tidservice.AutoCompleteMode = AutoCompleteMode.Suggest;
            tidservice.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tidservice.AutoCompleteCustomSource = auto;
            c.deconnecter();
        }
        // remplire combobox 
        public void remplire_combo()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from service", c.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "service");
            for (int i = 0; i < ds.Tables["service"].Rows.Count; i++)
            {
                tidservice.Items.Add(ds.Tables["service"].Rows[i][0]);
            }
        }
        public void charger_service()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from service", c.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "service");
            for (int i = 0; i < ds.Tables["service"].Rows.Count; i++)
            {
                tservice.Items.Add(ds.Tables["service"].Rows[i][1]);
            }
        }

        private void tservice_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from service", c.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "service");
            for (int i = 0; i < ds.Tables["service"].Rows.Count; i++)
            {
                if (tservice.SelectedItem.Equals(ds.Tables["service"].Rows[i][1]))
                {
                    tidservice.Text = ds.Tables["service"].Rows[i][0].ToString();

                }
            }
        }

        private void bnew_Click(object sender, EventArgs e)
        {
            clear();
            bupdate.Enabled = false;
            bdelete.Enabled = false;
            bsearch.Enabled = false;
            bnew.Enabled = false;
        }
        public void clear()
        {
            tdure.Clear();
            tid.Clear();
            tnom.Clear();
            tnomAR.Clear();
            tprenom.Clear();
            tprenomAR.Clear();
            tidservice.Text = "";
            tservice.Text = "";
            tserviceAR.Clear();
            tgrade.Clear();
            tgradeAR.Clear();
        }

        private void tdure_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tdure_Click(object sender, EventArgs e)
        {
            if (tdure.Text == "0")
            {
                tdure.Text = "";
            }
        }
    }
}
