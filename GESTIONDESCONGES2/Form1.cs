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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"data source=DESKTOP-L0UETLL ; initial catalog= GESTION_DES_CONGE2 ;integrated security=true");

        private void bconexion_Click(object sender, EventArgs e)
        {
            try
            {
                FORMINDEX f = new FORMINDEX();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Employe where login='" + tlogin.Text + "' and mot_de_pass='" + tpass.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr[13].ToString() == "Admin")
                    {
                        f.Show();
                        this.Hide();
                        FORMINDEX fd = new FORMINDEX();
                        fd.label1.Text = tlogin.Text;
                    }
                    else
                    {
                        f.Show();
                        f.bunifuThinButton22.Visible = false;
                        f.bservice.Visible = false;
                        f.bcongé.Visible = false;
                        f.pnotification.Visible = false;

                    }


                }

                else
                {
                    MessageBox.Show("Login ou mot de pass est incorrect !");
                }

                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void banuller_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
