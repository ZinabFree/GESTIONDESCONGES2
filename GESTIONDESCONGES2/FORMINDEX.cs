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
    public partial class FORMINDEX : Form
    {
        public FORMINDEX()
        {
            InitializeComponent();
        }

        private void bcongé_Click(object sender, EventArgs e)
        {
            if (Ptype_congé.Visible == false)
            {
                Ptype_congé.Visible = true;

            }
            else
            {
                Ptype_congé.Visible = false;
            }
        }

        private void FORMINDEX_Load(object sender, EventArgs e)
        {
            Form_in_Panel(new STATISTIQUES());
            //notification();
            Ptype_congé.Visible = false;
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form_in_Panel(new MISEAJOURSEMPLOYES());
        }
        private void Form_in_Panel(object FormP)
        {
            if (this.Pcontainer.Controls.Count > 0)
                this.Pcontainer.Controls.RemoveAt(0);
            Form fh = FormP as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Pcontainer.Controls.Add(fh);
            this.Pcontainer.Tag = fh;
            fh.Show();
        }

        private void bservice_Click(object sender, EventArgs e)
        {
            DEVISIONDESSERVICES s = new DEVISIONDESSERVICES();
            s.Show();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Form_in_Panel(new CONGEANUELE());
            if (Ptype_congé.Visible == true)
            {
                Ptype_congé.Visible = false;
            }
            else
            {
                Ptype_congé.Visible = true;
            }
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            Form_in_Panel(new CONGEEXCEPTIONEL());
            if (Ptype_congé.Visible == true)
            {
                Ptype_congé.Visible = false;
            }
            else
            {
                Ptype_congé.Visible = true;
            }
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            Form_in_Panel(new CONGEMALADIE());
            if (Ptype_congé.Visible == true)
            {
                Ptype_congé.Visible = false;
            }
            else
            {
                Ptype_congé.Visible = true;
            }
        }

        private void bacceuil_Click(object sender, EventArgs e)
        {
            Form_in_Panel(new STATISTIQUES());
            //pnotification.Image = Properties.Resources.N1;
        }

        private void pnotification_Click(object sender, EventArgs e)
        {
            CONGEEXPIRER c = new CONGEEXPIRER();
            c.Show();
        }
        CBASE c = new CBASE();
        private void procNotification()
        {
            SqlCommand cmd = new SqlCommand("notifocation", c.con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter returnValue = cmd.Parameters.Add("value", SqlDbType.Int);
            returnValue.Direction = ParameterDirection.ReturnValue;
            if (returnValue.Value.ToString() == "1")
            {
                //pnotification.Image = Properties.Resources.N1;
            }
            else
            {
                //pnotification.Image = Properties.Resources.N;
            }
        }

        private void pnotification_MouseHover(object sender, EventArgs e)
        {
            pnotification.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pnotification_MouseLeave(object sender, EventArgs e)
        {
            pnotification.BorderStyle = BorderStyle.None;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SEETING S = new SEETING();
            S.Show();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BorderStyle = BorderStyle.None;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
