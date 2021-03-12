using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CarantecAdminPanel
{
    public partial class FormConnexionAdmin : Form
    {
        string logAdmin, mdpAdmin, mode = "admin";
        int erreur;

        public FormConnexionAdmin()
        {
            InitializeComponent();
        }

        private void BoutonExitCoAdmin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BoutonValiderCoAdmin_Click(object sender, EventArgs e)
        {
            logAdmin = TextBoxLogAdmin.Text;
            mdpAdmin = TextBoxMdpAdmin.Text;
            Controleur.GetModele().charger_donnees("ADMIN");
            for(int i = 0; i < Controleur.GetModele().GetDT1().Rows.Count; i++)
            {
                if (logAdmin == Controleur.GetModele().GetDT1().Rows[i]["LOGADMIN"].ToString() && mdpAdmin == Controleur.GetModele().GetDT1().Rows[i]["MDPADMIN"].ToString())
                {
                    MessageBox.Show("Bienvenue " + logAdmin + " !", "Connexion réussie",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    erreur = 1;
                }
            }
            if (erreur == 0)
            {
                MessageBox.Show("Erreur dans le login ou le mdp !");
                TextBoxLogAdmin.Clear();
                TextBoxMdpAdmin.Clear();
            }
        }

        private void FormConnexionAdmin_Load(object sender, EventArgs e)
        {
            Controleur.init();
            Controleur.GetModele().seconnecter();
            if (Controleur.GetModele().GetConnopen() == false)
            {
                MessageBox.Show("Erreur");
            }
        }
    }
}
