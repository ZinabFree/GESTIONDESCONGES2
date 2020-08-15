using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace GESTIONDESCONGES2
{
    

    class CBASE
    {
        public SqlConnection con = new SqlConnection(@"data source=DESKTOP-L0UETLL ; initial catalog= GESTION_DES_CONGE2 ;integrated security=true");

        public void connecter()
        {
            con.Open();
        }
        public void deconnecter()
        {
            con.Close();
        }
        public void chargeGridAgent(int dote,int idTypeC, DataGridView data)
        {
            connecter();
            SqlDataAdapter da = new SqlDataAdapter("select N_conge, N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from Conge where N_dote='" + dote+"' and id_type_c='"+ idTypeC + "' ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            deconnecter();
            
            data.DataSource = dt;
        }
        public void chargeGridAgentM(int dote, int idTypeC, DataGridView data)
        {
            connecter();
            SqlDataAdapter da = new SqlDataAdapter("select N_conge, N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from Conge where N_dote='" + dote + "' and id_type_c='" + idTypeC + "' ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            deconnecter();

            data.DataSource = dt;
        }
    }
}
