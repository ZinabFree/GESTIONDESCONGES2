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
    public partial class STATISTIQUES : Form
    {
        public STATISTIQUES()
        {
            InitializeComponent();
        }
        CBASE c = new CBASE();
        private void STATISTIQUES_Load(object sender, EventArgs e)
        {
            charger_tous();
            rtous.Checked = true;
            searchwithefullname();
            searchwithename();
        }
        private void searchwithename()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from employe", c.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                auto.Add(dt.Rows[i][3].ToString());
            }
            tnom.AutoCompleteCustomSource = auto;
            tnom.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tnom.AutoCompleteMode = AutoCompleteMode.Suggest;
        }
        private void searchwithefullname()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from employe", c.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                auto.Add(dt.Rows[i][4].ToString());
            }
            tprenom.AutoCompleteCustomSource = auto;
            tprenom.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tprenom.AutoCompleteMode = AutoCompleteMode.Suggest;
        }
        private void bprint_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlDataAdapter da = new SqlDataAdapter("select * from conge", con);
            //DataSet ds = new DataSet();

            //da.Fill(ds, "conge");
            //print_all r1 = new print_all();
            //r1.SetDataSource(ds);
            //christal_report p = new christal_report(r1);
            //p.Show();
            //con.Close();
        }
        public void charger_tous()
        {
            c.connecter();
            SqlDataAdapter da = new SqlDataAdapter("select N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from conge", c.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //dataGridView1.Rows.Clear();
            dataGridView1.DataSource = dt;
            c.deconnecter();
        }
        public void conge_anuel()
        {
            c.connecter();
            SqlDataAdapter da = new SqlDataAdapter("select N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from conge where id_type_c=1", c.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            // dataGridView1.Rows.Clear();
            dataGridView1.DataSource = dt;
            c.deconnecter();
        }
        public void congeexceptionelle()
        {
            c.connecter();
            SqlDataAdapter da = new SqlDataAdapter("select N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from conge where id_type_c=2", c.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            // dataGridView1.Rows.Clear();
            dataGridView1.DataSource = dt;
            c.deconnecter();

        }
        public void conge_maladie()
        {
            c.connecter();
            SqlDataAdapter da = new SqlDataAdapter("select N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from conge where id_type_c=3", c.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //dataGridView1.Rows.Clear();
            dataGridView1.DataSource = dt;
            c.deconnecter();

        }

        private void rtous_CheckedChanged(object sender, EventArgs e)
        {
            charger_tous();
        }

        private void ranuel_CheckedChanged(object sender, EventArgs e)
        {
            conge_anuel();
        }

        private void rexceptionel_CheckedChanged(object sender, EventArgs e)
        {
            congeexceptionelle();
        }

        private void rmaladie_CheckedChanged(object sender, EventArgs e)
        {
            conge_maladie();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rtous.Checked)
            {
                tous_chercher_avec_date();
            }
            else
             if (ranuel.Checked)
            {
                anuelle_chercher_avec_date();
            }
            else
             if (rexceptionel.Checked)
            {
                exceptionelle_chercher_avec_date();
            }
            else
             if (rmaladie.Checked)
            {
                maladie_chercher_avec_date();
            }
        }
        public void tous_chercher_avec_date()
        {
            c.connecter();
            SqlDataAdapter da = new SqlDataAdapter(" select N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from Conge c where c.date_D between '" + date1.Text + "' and '" + date2.Text + "' or c.date_F between '" + date1.Text + "' and '" + date2.Text + "'", c.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            c.deconnecter();
        }
        public void anuelle_chercher_avec_date()
        {
            c.connecter();
            SqlDataAdapter da = new SqlDataAdapter(" select N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from Conge c  where c.id_type_c=1 and c.date_D between '" + date1.Text + "' and '" + date2.Text + "' or c.date_F between '" + date1.Text + "' and '" + date2.Text + "'", c.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            c.deconnecter();
        }
        public void exceptionelle_chercher_avec_date()
        {
            c.connecter();
            SqlDataAdapter da = new SqlDataAdapter(" select N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from Conge c  where c.id_type_c=2 and c.date_D between '" + date1.Text + "' and '" + date2.Text + "' or c.date_F between '" + date1.Text + "' and '" + date2.Text + "'", c.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            c.deconnecter();
        }
        public void maladie_chercher_avec_date()
        {
            c.connecter();
            SqlDataAdapter da = new SqlDataAdapter(" select N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from Conge c  where c.id_type_c=3 and c.date_D between '" + date1.Text + "' and '" + date2.Text + "' or c.date_F between '" + date1.Text + "' and '" + date2.Text + "'", c.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            c.deconnecter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tnom.Text == "" || tprenom.Text == "")
            {
                MessageBox.Show("Entrer le nom et le prenom pour effectuer la recherch", "Important", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (button2.Text == "Afficher")
                {
                    if (rtous.Checked)
                    {
                        selectAll_();
                    }
                    else
                    if (ranuel.Checked)
                    {
                        selectAllCongeexceptionelle(1);
                    }
                    else
                    if (rexceptionel.Checked)
                    {
                        selectAllCongeexceptionelle(2);
                    }
                    else
                    if (rmaladie.Checked)
                    {
                        selectAllCongeexceptionelle(3);
                    }
                    button2.Text = "Anuler";
                }
                else
                {
                    button2.Text = "Afficher";
                    tnom.Clear();
                    tprenom.Clear();
                    rtous.Checked = true;
                }
            }
        }
        private void selectAll_()
        {
            c.connecter();
            SqlDataAdapter da = new SqlDataAdapter(" select c.N_dote, c.Nom_employe, c.prenom_employe, c.date_D, c.date_F, c.Nb_jour, c.Date_saisie,c.Anne, c.id_type_c, c.type_de_conge, c.N_dote_remplacement, c.Nom_remplacement, c.Prenom_remplacement from Conge c inner join Employe e on e.N_dote=c.N_dote where e.Nom_AR in (select c.Nom_employe from Conge) and e.Prenom_AR in (select c.prenom_employe from Conge)", c.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            c.deconnecter();
        }
        private void selectAllCongeexceptionelle(int idtypeconge)
        {
            c.connecter();
            SqlDataAdapter da = new SqlDataAdapter(" select c.N_dote, c.Nom_employe, c.prenom_employe, c.date_D, c.date_F, c.Nb_jour, c.Date_saisie,c.Anne, c.id_type_c, c.type_de_conge, c.N_dote_remplacement, c.Nom_remplacement, c.Prenom_remplacement from Conge c inner join Employe e on e.N_dote=c.N_dote where e.Nom_AR in (select c.Nom_employe from Conge) and e.Prenom_AR in (select c.prenom_employe from Conge) and id_type_c='" + idtypeconge + "'", c.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            c.deconnecter();
        }
    }
}
