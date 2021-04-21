using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarantecAdminPanel
{
    public partial class FormCRUDParticiper : Form
    {

        public FormCRUDParticiper()
        {

            InitializeComponent();
            CbManif.SelectedIndex = -1;
            CbPersonne.SelectedIndex = -1;
            Controleur.Vmodele.charger_donnees("participer", -1, "","");
            Controleur.Vmodele.charger_donnees("manifestation", -1, "","");
            for (int i = 0; i < Controleur.vmodele.DT[3].Rows.Count; i++)
            {
                CbManif.Items.Add(Controleur.vmodele.DT[3].Rows[i][3].ToString());
            }
        }

        private void cbManif_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private string getTypeManif(string item)
        {
            Controleur.Vmodele.charger_donnees("nomManifToIdManif", -1, CbManif.SelectedItem.ToString(),"");
            string idManif = Controleur.vmodele.DT[23].Rows[0][0].ToString();
            Controleur.Vmodele.charger_donnees("verifTypeManif", -1, idManif.ToString(),"") ;
            if (Controleur.vmodele.DT[35].Rows[0][0].ToString() != "") return Controleur.vmodele.DT[35].Rows[0][0].ToString();
            else if (Controleur.vmodele.DT[35].Rows[0][1].ToString() != "") return Controleur.vmodele.DT[35].Rows[0][1].ToString();
            else if (Controleur.vmodele.DT[35].Rows[0][2].ToString() != "") return Controleur.vmodele.DT[35].Rows[0][2].ToString();
            else if (Controleur.vmodele.DT[35].Rows[0][3].ToString() != "") return Controleur.vmodele.DT[35].Rows[0][3].ToString();
            else return "";
        }

        private void cbManif_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Controleur.Vmodele.charger_donnees("animateurPersonne", -1, "","");
            Controleur.Vmodele.charger_donnees("artistePersonne", -1, "","");
            Controleur.Vmodele.charger_donnees("intervenantSpecialisePersonne", -1, "","");
            CbPersonne.Enabled = true;
            CbPersonne.Items.Clear();
            CbPersonne.SelectedIndex = -1;
            string typeManif = getTypeManif(CbManif.SelectedItem.ToString());
            int numVmodele = 0;
            if (typeManif == "atelier")
            {
                labelSpecial.Text = "Animateur";
                numVmodele = 27;
            }
            if (typeManif == "concert")
            {
                labelSpecial.Text = "Artiste";
                numVmodele = 26;
            }
            if (typeManif == "conference" || typeManif == "debat")
            {
                labelSpecial.Text = "Animateur/\nIntervenant Spécialisé";
                numVmodele = 27;
                for (int i = 0; i < Controleur.vmodele.DT[numVmodele].Rows.Count; i++)
                {
                    CbPersonne.Items.Add(Controleur.vmodele.DT[numVmodele].Rows[i][1].ToString() + " " + Controleur.vmodele.DT[numVmodele].Rows[i][2].ToString());
                }
                numVmodele = 28;
            }
            for (int i = 0; i < Controleur.vmodele.DT[numVmodele].Rows.Count; i++)
            {
                CbPersonne.Items.Add(Controleur.vmodele.DT[numVmodele].Rows[i][1].ToString() + " " + Controleur.vmodele.DT[numVmodele].Rows[i][2].ToString());
            }
        }
    }
}
