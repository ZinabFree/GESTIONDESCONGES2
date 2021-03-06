﻿using System;
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
    public partial class CONGEANUELE : Form
    {
        public CONGEANUELE()
        {
            InitializeComponent();
        }
        CBASE c = new CBASE();
        private void CONGEANUELE_Load(object sender, EventArgs e)
        {
            Increament_N();
            //}

            tdoteR.Enabled = false;
            tnomR.Enabled = false;

            tdoteR.Enabled = false;
            tnomR.Enabled = false;

            charger_all_dots();
            charger_all_dots2();
            search_withe_namme();
            search_withe_namme_R();
            remplire_gride();
            bupdate.Enabled = false;
            bdelete.Enabled = false;
            bprint.Enabled = false;
        }

        private void badd_Click(object sender, EventArgs e)
        {
            try
            {
                if (badd.Text == "Ajouter")
                {
                    if (tdote.Text == "" || tnomFR.Text == "" || tdoteR.Text == "" || tnomR.Text == "")
                    {
                        MessageBox.Show("Remplire les shamps SVP", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                  if (tduree.Text == "")
                    {
                        MessageBox.Show("Choisir une duree de conge", "Important", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        verifier_conge();
                        //remplire_gride();
                        c.chargeGridAgent(int.Parse(tdote.Text), 1, dataGridView1);
                        badd.Text = "Nouveau";
                        stored_proc_duree();
                        bdelete.Enabled = true;
                        bupdate.Enabled = true;
                        bprint.Enabled = true;
                    }
                }
                else
                {
                    clear();
                    Increament_N();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void modifier_date()
        {
            try
            {
                c.connecter();
                SqlCommand cmd = new SqlCommand("update employe set duree_date_precedent=0+duree_date_actuel,duree_date_actuel=22", c.con);
                cmd.ExecuteNonQuery();
                c.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void remplire_gride()
        {
            try
            {
                c.connecter();
                SqlDataAdapter da = new SqlDataAdapter("select N_conge, N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from Conge where id_type_c=1 ", c.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                c.deconnecter();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ajouter_conge()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into conge (N_conge,N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie, id_type_c,type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement) values('" + tdote.Text +
                                                      "','" + tnomAR.Text + "','" + tprenomAR.Text + "','" + dateD.Text + "','" + DateF.Text + "','" + tduree.Text + "',getdate(),3,,'" + tdoteR.Text + "','" + tnomAR_R.Text + "','" + tprenom_AR_R.Text + "')", c.con);
                c.connecter();
                cmd.ExecuteNonQuery();
                c.deconnecter();
                //verifier_conge();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void search_withe_namme()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from employe", c.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                auto.Add(dt.Rows[i][1].ToString());
            }
            tnomFR.AutoCompleteCustomSource = auto;
            tnomFR.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tnomFR.AutoCompleteMode = AutoCompleteMode.Suggest;
        }
        public void search_withe_namme_R()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from employe", c.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                auto.Add(dt.Rows[i][1].ToString());
            }
            tnomR.AutoCompleteCustomSource = auto;
            tnomR.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tnomR.AutoCompleteMode = AutoCompleteMode.Suggest;
        }
        public void auto_complete()
        {
            SqlDataAdapter da = new SqlDataAdapter("select N_dote from employe", c.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                auto.Add(dt.Rows[i][0].ToString());
            }
            this.tdote.AutoCompleteCustomSource = auto;
            this.tdote.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.tdote.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        public void charger_all_dots()
        {
            //con.Open();
            //SqlCommand cmd = new SqlCommand("select N_dote from employe", con);
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    tdot.Items.Add(dr[0].ToString());
            //    tdoteR.Items.Add(dr[0].ToString());
            //}
            //con.Close();
            SqlDataAdapter da = new SqlDataAdapter("select * from employe", c.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "emp");
            for (int i = 0; i < ds.Tables["emp"].Rows.Count; i++)
            {
                tdote.Items.Add(ds.Tables["emp"].Rows[i][0]);
            }
        }

        public void charger_all_dots2()
        {
            //con.Open();
            //SqlCommand cmd = new SqlCommand("select N_dote from employe", con);
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    tdot.Items.Add(dr[0].ToString());
            //    tdoteR.Items.Add(dr[0].ToString());
            //}
            //con.Close();
            SqlDataAdapter da = new SqlDataAdapter("select * from employe", c.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "emp");
            for (int i = 0; i < ds.Tables["emp"].Rows.Count; i++)
            {
                tdoteR.Items.Add(ds.Tables["emp"].Rows[i][0]);
            }
        }

        private void tdote_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from employe ", c.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "conge");
            for (int i = 0; i < ds.Tables["conge"].Rows.Count; i++)
            {
                if (tdote.SelectedItem.Equals(ds.Tables["conge"].Rows[i][0]))
                {
                    tnomFR.Text = ds.Tables["conge"].Rows[i][1].ToString();
                    TPrenom.Text = ds.Tables["conge"].Rows[i][2].ToString();
                    tnomAR.Text = ds.Tables["conge"].Rows[i][3].ToString();
                    tprenomAR.Text = ds.Tables["conge"].Rows[i][4].ToString();
                    tprecedent.Text = ds.Tables["conge"].Rows[i][11].ToString();
                    tactuel.Text = ds.Tables["conge"].Rows[i][12].ToString();
                }
            }
            c.chargeGridAgent(int.Parse(tdote.Text),1, dataGridView1);
        }

        private void tdoteR_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from employe ", c.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "conge");
            for (int i = 0; i < ds.Tables["conge"].Rows.Count; i++)
            {
                if (tdoteR.SelectedItem.Equals(ds.Tables["conge"].Rows[i][0]))
                {
                    tnomR.Text = ds.Tables["conge"].Rows[i][1].ToString();
                    tprenomR.Text = ds.Tables["conge"].Rows[i][2].ToString();
                    tnomAR_R.Text = ds.Tables["conge"].Rows[i][3].ToString();
                    tprenom_AR_R.Text = ds.Tables["conge"].Rows[i][4].ToString();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (bdelete.Enabled == false && bupdate.Enabled == false)
                {
                    bdelete.Enabled = true; bupdate.Enabled = true; bprint.Enabled = true;
                    badd.Text = "Nouveau";
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    tnconge.Text = dataGridView1.Rows[e.RowIndex].Cells["N_conge"].FormattedValue.ToString();
                    tdote.Text = dataGridView1.Rows[e.RowIndex].Cells["N_dote"].FormattedValue.ToString();
                    //ttypeconge.Text = dataGridView1.Rows[e.RowIndex].Cells["type_de_conge"].FormattedValue.ToString();
                    dateD.Text = dataGridView1.Rows[e.RowIndex].Cells["date_D"].FormattedValue.ToString();
                    // tdureeRest_conge.Text = dataGridView1.Rows[e.RowIndex].Cells["Nb_jour"].FormattedValue.ToString();
                    DateF.Text = dataGridView1.Rows[e.RowIndex].Cells["date_F"].FormattedValue.ToString();
                    tduree.Text = dataGridView1.Rows[e.RowIndex].Cells["nb_jour"].FormattedValue.ToString();
                    //dateSaisie.Text = dataGridView1.Rows[e.RowIndex].Cells["Date_saisie"].FormattedValue.ToString();
                    tdoteR.Text = dataGridView1.Rows[e.RowIndex].Cells["N_dote_remplacement"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tnomFR_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from employe", c.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "emp");

            for (int i = 0; i < ds.Tables["emp"].Rows.Count; i++)
            {
                if (tnomFR.Text.Equals(ds.Tables["emp"].Rows[i][1]))
                {
                    tdote.Text = ds.Tables["emp"].Rows[i][0].ToString();
                }
            }
        }

        private void tnomR_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from employe", c.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "emp");

            for (int i = 0; i < ds.Tables["emp"].Rows.Count; i++)
            {
                if (tnomR.Text.Equals(ds.Tables["emp"].Rows[i][1]))
                {
                    tdoteR.Text = ds.Tables["emp"].Rows[i][0].ToString();
                }
            }
        }
        private void Increament_N()
        {
            try
            {
                //SqlCommand cmd = new SqlCommand("select top 1 N_conge from conge order by N_conge desc", c.con);
                //c.connecter();
                //SqlDataReader dr = cmd.ExecuteReader();

                //while (dr.Read())
                //{
                //    int valus = int.Parse(dr[0].ToString()) + 1;
                //    if (tnconge.Text == "" || tnconge.Text == null)
                //        tnconge.Text = "1";
                //    else
                //        tnconge.Text = valus.ToString();

                //}
                //dr.Close();
                //c.deconnecter();

                c.connecter();
                SqlCommand cmd = new SqlCommand("select max(id)+1 from Detaille_Type_conge", c.con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    tnconge.Text = (dr[0].ToString());
                }
                c.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void stored_proc_duree()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("duree_F_C", c.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = cmd.Parameters.Add("@N_dote", SqlDbType.Int);
                SqlParameter p2 = cmd.Parameters.Add("@duree", SqlDbType.Int);
                p1.Value = int.Parse(tdote.Text);
                p2.Value = int.Parse(tduree.Text);
                c.connecter();
                cmd.ExecuteNonQuery();
                c.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void clear()
        {
            tactuel.Clear();
            tdote.Text = "";
            tnomFR.Clear();
            TPrenom.Clear();
            tnomAR.Clear();
            tprenomAR.Clear();
            tdoteR.Text = "";
            tnomR.Clear();
            tprenomR.Clear();
            tnomAR_R.Clear();
            tprenom_AR_R.Clear();
            tprecedent.Clear();
            dateD.Value = DateTime.Now;
            DateF.Value = DateTime.Now;
            tduree.Clear();
            bupdate.Enabled = false;
            bdelete.Enabled = false;
            bprint.Enabled = false;
            badd.Text = "Ajouter";
        }
        public void ajouter_conge_A()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into conge (N_conge,N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c,type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement) values('" + tnconge.Text + "','" + tdote.Text + "','" + tnomAR.Text + "','" + tprenomAR.Text + "','" + dateD.Text + "','" + DateF.Text + "','" + tduree.Text + "',GETDATE(),year(getdate()),1,'Anuel','" + tdoteR.Text + "','" + tnomAR_R.Text + "','" + tprenom_AR_R.Text + "')", c.con);
                c.connecter();
                cmd.ExecuteNonQuery();
                c.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void verifier_conge()
        {
            try
            {
                c.connecter();
                SqlDataAdapter da = new SqlDataAdapter("select top 1 * from Conge where id_type_c=1 and N_dote='" + tdote.Text + "' and((GETDATE()<=date_D)or(GETDATE() between date_D and date_F) or (GETDATE()=date_F)) order by date_F desc ", c.con);
                DataTable dt = new DataTable();

                da.Fill(dt);
                c.deconnecter();
                if (dt.Rows.Count == 0)
                {
                    ajouter_conge_A();
                }
                else
                {
                    MessageBox.Show("Imposible d'effectuer ce conge !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void stored_proc()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ps_CountWeekDays", c.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pdate1 = cmd.Parameters.Add("@fromdate", SqlDbType.Date);
                SqlParameter pdate2 = cmd.Parameters.Add("@todate", SqlDbType.Date);
                pdate1.Value = dateD.Value;
                pdate2.Value = DateF.Value;
                c.connecter();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    tduree.Text = dr[0].ToString();
                }

                c.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Vouler vous modifier ce conge ?", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    modifier_duree_an();
                    SqlCommand cmd = new SqlCommand("update conge set N_dote='" + tdote.Text + "' ,Nom_employe='" + tnomAR.Text + "',prenom_employe='" + tprenomAR.Text + "',date_D='" + dateD.Text + "',date_F='" + DateF.Text + "',Nb_jour='" + tduree.Text + "',Date_saisie=getdate(),Anne='" + tanne.Text + "',id_type_c=1,type_de_conge='Anuel',N_dote_remplacement='" + tdoteR.Text + "',Nom_remplacement='" + tnomR.Text + "',Prenom_remplacement='" + tprenom_AR_R.Text + "' where id_type_c=1 and N_conge='" + tnconge.Text + "'", c.con);
                    c.connecter();
                    cmd.ExecuteNonQuery();
                    c.deconnecter();
                    // modifier_duree_conge_avec_stored_proc();
                }
                c.chargeGridAgent(int.Parse(tdote.Text), 1, dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void modifier_duree_an()
        {
            SqlCommand cmd = new SqlCommand("modifier_N_J", c.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pduree_N = cmd.Parameters.Add("@duree_N", SqlDbType.Int);
            SqlParameter pN_dote = cmd.Parameters.Add("@N_dote", SqlDbType.Int);

            SqlParameter pN_conge = cmd.Parameters.Add("@N_conge", SqlDbType.Int);

            pduree_N.Value = tduree.Text;
            pN_dote.Value = tdote.Text;
            pN_conge.Value = tnconge.Text;

            c.connecter();
            cmd.ExecuteNonQuery();
            c.deconnecter();
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Vouler vous vraiment supprimer ce conge ?", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //SqlCommand cmd = new SqlCommand("delete conge where N_dote='" + tdote.Text + "' and Nom_employe ='" + tnomAR.Text + "' and date_D='" + dateD.Text + "' and date_F='" + DateF.Text + "' ", con);
                    SqlCommand cmd = new SqlCommand("delete conge where N_conge='" + tnconge.Text + "'", c.con);
                    c.connecter();
                    cmd.ExecuteNonQuery();
                    c.deconnecter();
                    clear();
                }
                c.chargeGridAgent(int.Parse(tdote.Text), 1, dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                stored_proc();
                int total_duree = int.Parse(tprecedent.Text) + int.Parse(tactuel.Text);
                if (int.Parse(tduree.Text) > total_duree)
                {
                    MessageBox.Show("Vous avez depaser le total duree rest !", "Important", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    tdoteR.Enabled = false;
                    tnomR.Enabled = false;
                }
                else
                {
                    tdoteR.Enabled = true;
                    tnomR.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bprint_Click(object sender, EventArgs e)
        {
            try
            {
                c.connecter();
                SqlDataAdapter da = new SqlDataAdapter("select * from employe e inner join conge c on e.N_dote=c.N_dote", c.con);
                da = new SqlDataAdapter("select * from conge c  inner join employe e on e.N_dote=c.N_dote where N_conge='" + tnconge.Text + "'", c.con);
                DataSet ds = new DataSet();
                da.Fill(ds, "employe");
                da.Fill(ds, "conge");
                c.deconnecter();
                PRINTCONGEANUEL pnt = new PRINTCONGEANUEL();
                pnt.SetDataSource(ds);
                REPORTVIEW f = new REPORTVIEW(pnt);
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
