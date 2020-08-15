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
    public partial class typeConge : Form
    {
        public typeConge()
        {
            InitializeComponent();
        }
        CBASE c = new CBASE();
        private void typeConge_Load(object sender, EventArgs e)
        {
            chargerGrid();
            increament();
        }
        public void charger_tous()
        {
            //con.Open();
            //SqlDataAdapter da = new SqlDataAdapter("select N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from conge",con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            ////dataGridView1.Rows.Clear();
            //dataGridView1.DataSource = dt;
            //con.Close();
        }
        private void chargerGrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("select id,libelle_conge,Nb_jour from Detaille_Type_conge where id_type=2 ", c.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bajouter_Click(object sender, EventArgs e)
        {
            if (bajouter.Text == "Ajouter")
            {
                SqlCommand cmd = new SqlCommand("insert into Detaille_Type_conge values(2,'" + tlebeleconge.Text.Replace("'", "''") + "','" + tnbjours.Text + "')", c.con);
                c.connecter();
                cmd.ExecuteNonQuery();
                c.deconnecter();
                chargerGrid();
                bajouter.Text = "Nouveau";
            }
            else
            {
                tlebeleconge.Clear();
                tnbjours.Clear();
                increament();
                bmodifier.Enabled = false;
                bsupprimer.Enabled = false;
                bajouter.Text = "Ajouter";
            }
        }
        private void increament()
        {
            c.connecter();
            SqlCommand cmd = new SqlCommand("select max(id)+1 from Detaille_Type_conge", c.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tnumero.Text = (dr[0].ToString());
            }
            c.deconnecter();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    bmodifier.Enabled = true;
                    bsupprimer.Enabled = true;
                    bajouter.Text = "Nouveau";
                    dataGridView1.CurrentRow.Selected = true;
                    tnumero.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                    tlebeleconge.Text = dataGridView1.Rows[e.RowIndex].Cells["libelle_conge"].FormattedValue.ToString();
                    tnbjours.Text = dataGridView1.Rows[e.RowIndex].Cells["Nb_jour"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bmodifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment modifier ce type de congé ?", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("update Detaille_Type_conge set libelle_conge ='" + tlebeleconge.Text.Replace("'", "''") + "',Nb_jour ='" + tnbjours.Text + "' where Id='" + tnumero.Text + "'", c.con);
                    c.connecter();
                    cmd.ExecuteNonQuery();
                    c.deconnecter();
                    chargerGrid();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bsupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer ce type de congé ?", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("delete from Detaille_Type_conge where Id='" + tnumero.Text + "'", c.con);
                    c.connecter();
                    cmd.ExecuteNonQuery();
                    c.deconnecter();
                    chargerGrid();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            charger_type();
        }
        public void charger_type()
        {
            try
            {
                c.connecter();
                SqlCommand cmd = new SqlCommand("select * from Detaille_Type_conge where id_type=2", c.con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CONGEEXCEPTIONEL c = new CONGEEXCEPTIONEL();
                    c.ttypeconge.Items.Add(dr[2].ToString());

                }
                c.deconnecter();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
