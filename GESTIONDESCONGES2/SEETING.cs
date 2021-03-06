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
    public partial class SEETING : Form
    {
        public SEETING()
        {
            InitializeComponent();
        }
        CBASE c = new CBASE();
        private void SEETING_Load(object sender, EventArgs e)
        {
            charger();
            //charger_list_D();
            r1.Checked = true;
            lid.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment modifier la date !", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("update jours_ferier set date_jours_D='" + date1.Text + "', date_jours_F='" + date2.Text + "' where id_jour='" + lid.Text + "'", c.con);
                c.connecter();
                cmd.ExecuteNonQuery();
                c.deconnecter();
                charger();
                MessageBox.Show("Modifier avec succes");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tnom.Text != "" && tmactuele.Text != "" && tmconfirmer.Text != "" && tmnouveau.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("select e.Login,e.Mot_de_pass from Employe e where e.Login='" + tnom.Text + "' and e.Mot_de_pass='" + tmactuele.Text + "'", c.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    if (tmnouveau.Text == tmconfirmer.Text)
                    {
                        if (MessageBox.Show("Voulez vous vraiment modifier le mot de pass ?", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            SqlCommand cmd = new SqlCommand("update employe set Mot_de_pass='" + tmconfirmer.Text + "' where Login='" + tnom.Text + "'and Mot_de_pass='" + tmactuele.Text + "'", c.con);
                            c.connecter();
                            cmd.ExecuteNonQuery();
                            c.deconnecter();
                            MessageBox.Show("Votre mot de pass a eté bien modifier");
                        }

                    }
                    else
                    {
                        MessageBox.Show("erreur de comfermation du mot de pass", "Important", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    c.deconnecter();
                }
                else
                {
                    MessageBox.Show("le nom d'utilisateure ou mot de pass est encorrect", "Important", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            else
            {
                MessageBox.Show("Pour modifier votre mot de pass il sufi de remplire les shamps presentaient", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tmactuele.UseSystemPasswordChar = false;
                tmnouveau.UseSystemPasswordChar = false;
                tmconfirmer.UseSystemPasswordChar = false;
            }
            else
            {
                tmactuele.UseSystemPasswordChar = true;
                tmnouveau.UseSystemPasswordChar = true;
                tmconfirmer.UseSystemPasswordChar = true;
            }
        }
        public void charger()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from jours_ferier", c.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void charger_list_D()
        {
            if (r1.Checked)
            {
                c.connecter();
                SqlDataAdapter da = new SqlDataAdapter("select jour_firier from jours_ferier where id_jour=1 or id_jour=2 or id_jour=3 or id_jour=4 ", c.con);
                DataSet ds = new DataSet();
                da.Fill(ds, "jour");
                for (int i = 0; i < ds.Tables["jour"].Rows.Count; i++)
                {
                    comboBox1.Items.Add(ds.Tables["jour"].Rows[i][0]);
                }
                c.deconnecter();
            }
            else

            {
                c.connecter();
                SqlDataAdapter da = new SqlDataAdapter("select jour_firier from jours_ferier where id_jour=5 or id_jour=6 or id_jour=7 or id_jour=8 or id_jour=9 or id_jour=10 or id_jour=11 or id_jour=12 ", c.con);
                DataSet ds = new DataSet();
                da.Fill(ds, "jour");
                for (int i = 0; i < ds.Tables["jour"].Rows.Count; i++)
                {
                    comboBox1.Items.Add(ds.Tables["jour"].Rows[i][0]);
                }
                c.deconnecter();
            }

        }

        private void r1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            lid.Visible = false;
            date1.Value = DateTime.Now;
            date2.Value = DateTime.Now;
            charger_list_D();
        }

        private void r2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            lid.Visible = false;
            date1.Value = DateTime.Now;
            date2.Value = DateTime.Now;
            charger_list_D();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lid.Visible = true;
            c.connecter();
            SqlDataAdapter da = new SqlDataAdapter("select * from jours_ferier", c.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "bind_jour");
            for (int i = 0; i < ds.Tables["bind_jour"].Rows.Count; i++)
            {
                if (comboBox1.SelectedItem.Equals(ds.Tables["bind_jour"].Rows[i][1]))
                {
                    lid.Text = ds.Tables["bind_jour"].Rows[i][0].ToString();
                    date1.Text = ds.Tables["bind_jour"].Rows[i][2].ToString();
                    date2.Text = ds.Tables["bind_jour"].Rows[i][3].ToString();


                }
            }
            c.deconnecter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tnom.Clear();
            tmactuele.Clear();
            tmconfirmer.Clear();
            tmnouveau.Clear();

        }
    }
}
