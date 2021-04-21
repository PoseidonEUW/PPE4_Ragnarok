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
        string logAdmin, mdpAdmin;

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
            try
            {
                logAdmin = TextBoxLogAdmin.Text;
                mdpAdmin = TextBoxMdpAdmin.Text;
                Controleur.Vmodele.charger_donnees("IdForAdmin", -1, logAdmin, mdpAdmin);
                Controleur.vmodele.DT[37].Rows[0][0].ToString();
                Form1 FA = new Form1();
                this.Visible = false;
                FA.Show();
            }
            catch
            {
                MessageBox.Show("Erreur dans le login ou le mot de passe!");
                TextBoxLogAdmin.Clear();
                TextBoxMdpAdmin.Clear();
            }
        }

        private void FormConnexionAdmin_Load(object sender, EventArgs e)
        {
            Controleur.init();
            Controleur.Vmodele.seconnecter();
            if (Controleur.Vmodele.Connopen == false)
            {
                MessageBox.Show("Erreur");
            }
        }
    }
}
