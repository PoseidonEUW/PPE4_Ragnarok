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
    public partial class Form1 : Form
    {
        private BindingSource bindingSource1;
        public string tableG;
        public string select;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controleur.init();
            Controleur.Vmodele.seconnecter();
            if (Controleur.Vmodele.Connopen == false) MessageBox.Show("Erreur dans la connexion");
            dgvDonnees.Visible = false;
        }

        public void btnTables(string table)
        {
            tableG = table;
            Controleur.Vmodele.charger_donnees(table, -1, "","");      // chargement des données de la table sélectionné dans le DT correspondant
            // un DT par table
            bindingSource1 = new BindingSource();
            if (table == "utilisateur")
            {
                Controleur.Vmodele.charger_donnees("personnesimplifie", -1, "","");
                Controleur.Vmodele.charger_donnees("adherentPersonne", -1, "","");
                Controleur.Vmodele.charger_donnees("artistePersonne", -1, "","");
                Controleur.Vmodele.charger_donnees("animateurPersonne", -1, "","");
                Controleur.Vmodele.charger_donnees("intervenantSpecialisePersonne", -1, "","");
                dgvDonnees.DataSource = bindingSource1;
                bindingSource1.DataSource = Controleur.Vmodele.DT[29];
            }
            else if (table == "festivalDisplay")
            {
                bindingSource1.DataSource = Controleur.Vmodele.DT[9];
                dgvDonnees.DataSource = bindingSource1;
                dgvDonnees.Columns["ANNEEFESTIVAL"].HeaderText = "Année";
                dgvDonnees.Columns["NOMFESTIVAL"].HeaderText = "Nom";
                dgvDonnees.Columns["LIBELLETHEMATIQUE"].HeaderText = "Libelle";
                dgvDonnees.Columns["NOMPRENOMPERSONNE"].HeaderText = "Nom prénom de l'organisateur";
            }
            else if (table == "manifestation")
            {
                bindingSource1.DataSource = Controleur.Vmodele.DT[3];
                dgvDonnees.DataSource = bindingSource1;
            }
            else if (table == "reservation")
            {
                bindingSource1.DataSource = Controleur.Vmodele.DT[4];
                dgvDonnees.DataSource = bindingSource1;

            }
            else if (table == "lieu")
            {
                bindingSource1.DataSource = Controleur.Vmodele.DT[5];
                dgvDonnees.DataSource = bindingSource1;

            }
            else if (table == "avis")
            {
                bindingSource1.DataSource = Controleur.Vmodele.DT[6];
                dgvDonnees.DataSource = bindingSource1;
            }
            else if (table == "public")
            {
                bindingSource1.DataSource = Controleur.Vmodele.DT[7];
                dgvDonnees.DataSource = bindingSource1;
            }
            else if (table == "participer")
            {
                bindingSource1.DataSource = Controleur.Vmodele.DT[34];
                dgvDonnees.DataSource = bindingSource1;
            }

            // mise à jour du dataGridView via le bindingSource rempli par le DataTable
            dgvDonnees.Refresh();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeco_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormConnexionAdmin FCA = new FormConnexionAdmin();
            FCA.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Controleur.Vmodele.Connopen)    // si connexion ouverte
            {
                Controleur.Vmodele.sedeconnecter();
            }
        }

        private void refreshBtnColor(string btn)
        {
            select = btn;
            btnFestival.Image = CarantecAdminPanel.Properties.Resources.FestivalInverse;
            btnManifestation.Image = CarantecAdminPanel.Properties.Resources.ManifestationsInverse;
            btnReservation.Image = CarantecAdminPanel.Properties.Resources.ReservationInverse;
            btnLieux.Image = CarantecAdminPanel.Properties.Resources.LieuxInverse;
            btnAvis.Image = CarantecAdminPanel.Properties.Resources.AvisInverse;
            btnPublic.Image = CarantecAdminPanel.Properties.Resources.PublicInverse;
            btnUsers.Image = CarantecAdminPanel.Properties.Resources.UserInverse;
            btnParticiper.Image = CarantecAdminPanel.Properties.Resources.ParticipationInverse;
            switch (btn)
            {
                case "btnFestival":
                    btnFestival.Image = CarantecAdminPanel.Properties.Resources.FestivalInverseRed;
                    break;
                case "btnManifestation":
                    btnManifestation.Image = CarantecAdminPanel.Properties.Resources.ManifestationsInverseRed;
                    break;
                case "btnReservation":
                    btnReservation.Image = CarantecAdminPanel.Properties.Resources.ReservationInverseRed;
                    break;
                case "btnLieux":
                    btnLieux.Image = CarantecAdminPanel.Properties.Resources.LieuxInverseRed;
                    break;
                case "btnAvis":
                    btnAvis.Image = CarantecAdminPanel.Properties.Resources.AvisInverseRedH;
                    break;
                case "btnPublic":
                    btnPublic.Image = CarantecAdminPanel.Properties.Resources.PublicInverseRed;
                    break;
                case "btnUsers":
                    btnUsers.Image = CarantecAdminPanel.Properties.Resources.UserInverseRed;
                    break;
                case "btnParticiper":
                    btnParticiper.Image = CarantecAdminPanel.Properties.Resources.ParticipationInverseRed;
                    break;
            }
        }

        private void btnFestival_Click(object sender, EventArgs e)
        {
            refreshBtnColor("btnFestival");
            btnTables("festivalDisplay");
            dgvDonnees.Columns[0].Width = 150;
            dgvDonnees.Visible = true;
        }

        private void btnManifestation_Click_1(object sender, EventArgs e)
        {
            refreshBtnColor("btnManifestation");
            btnTables("manifestation");
            dgvDonnees.Columns[0].Width = 100;
            dgvDonnees.Columns[1].Width = 100;
            dgvDonnees.Columns[2].Width = 75;
            dgvDonnees.Visible = true;
        }

        private void btnReservation_Click_1(object sender, EventArgs e)
        {
            refreshBtnColor("btnReservation");
            btnTables("reservation");
            dgvDonnees.Columns[0].Width = 250;
            dgvDonnees.Visible = true;
        }

        private void btnLieux_Click_1(object sender, EventArgs e)
        {
            refreshBtnColor("btnLieux");
            btnTables("lieu");
            dgvDonnees.Columns[0].Width = 150;
            dgvDonnees.Visible = true;
        }

        private void btnAvis_Click_1(object sender, EventArgs e)
        {
            refreshBtnColor("btnAvis");
            btnTables("avis");
            dgvDonnees.Columns[0].Width = 150;
            dgvDonnees.Visible = true;
        }

        private void btnPublic_Click_1(object sender, EventArgs e)
        {
            refreshBtnColor("btnPublic");
            btnTables("public");
            dgvDonnees.Columns[0].Width = 250;
            dgvDonnees.Visible = true;
        }

        private void dgvDonnees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clickOnMenuItem(object sender, EventArgs e)
        {
            if (sender == ajouterToolStripMenuItem)
            {
                // appel de la méthode du controleur en mode create
                if (tableG == "festivalDisplay") Controleur.crud_festival('c', -1);
                if (tableG == "utilisateur") Controleur.crud_utilisateur('c', -1);
                if (tableG == "manifestation") Controleur.crud_manifestation('c', -1);
                if (tableG == "reservation") Controleur.crud_reservation('c', -1);
                if (tableG == "avis") MessageBox.Show("Erreur : Vous n'avez pas la possibilité d'ajouter un avis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (tableG == "public") Controleur.crud_public('c', -1);
                if (tableG == "lieu") Controleur.crud_lieu('c', -1);
                if (tableG == "participer") Controleur.crud_participation('c', -1);
            }
            else
            {
                // vérifier qu’une ligne est bien sélectionnée dans le dataGridView
                if (dgvDonnees.SelectedRows.Count == 1)
                {
                    if (sender == modifierToolStripMenuItem)
                    {
                        if (tableG == "festivalDisplay") Controleur.crud_festival('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "utilisateur") Controleur.crud_utilisateur('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "manifestation") Controleur.crud_manifestation('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "reservation") Controleur.crud_reservation('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "avis") Controleur.crud_avis('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "public") Controleur.crud_public('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "lieu") Controleur.crud_lieu('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "participer") Controleur.crud_participation('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                    }
                    if (sender == supprimerToolStripMenuItem)
                    {
                        if (tableG == "festivalDisplay") Controleur.crud_festival('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "utilisateur") Controleur.crud_utilisateur('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "manifestation") Controleur.crud_manifestation('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "reservation") Controleur.crud_reservation('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "avis") Controleur.crud_avis('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "public") Controleur.crud_public('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "lieu") Controleur.crud_lieu('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "participer") Controleur.crud_participation('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                    }
                }
                else
                {
                    MessageBox.Show("Sélectionner une ligne à modifier/supprimer");
                }
            }
            // mise à jour du dataGridView en affichage
            // appel de la méthode pour recharger toutes les données dans le DataGridView en cas d'ajout
            bindingSource1.MoveLast();
            bindingSource1.MoveFirst();
            dgvDonnees.Refresh();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clickOnMenuItem(sender, e);
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clickOnMenuItem(sender, e);
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clickOnMenuItem(sender, e);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cbTrier_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTables("utilisateur");
        }

        private void btnFestival_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnFestival_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnFestival_MouseEnter(object sender, EventArgs e)
        {
            btnFestival.Image = CarantecAdminPanel.Properties.Resources.FestivalInverseRed;
        }

        private void btnFestival_MouseLeave(object sender, EventArgs e)
        {
            if (select != "btnFestival")
            {
                btnFestival.Image = CarantecAdminPanel.Properties.Resources.FestivalInverse;
            }
            
        }

        private void btnUsers_Click_1(object sender, EventArgs e)
        {
            refreshBtnColor("btnUsers");
            btnTables("utilisateur");
            dgvDonnees.Columns[0].Width = 150;
            dgvDonnees.Columns[1].Width = 250;
            dgvDonnees.Columns[2].Width = 250;
            dgvDonnees.Visible = true;
        }

        private void btnParticiper_Click(object sender, EventArgs e)
        {
            refreshBtnColor("btnParticiper");
            btnTables("participer");
            dgvDonnees.Columns[0].Width = 150;
            dgvDonnees.Visible = true;
        }

        private void btnManifestation_MouseEnter(object sender, EventArgs e)
        {
            btnManifestation.Image = CarantecAdminPanel.Properties.Resources.ManifestationsInverseRed;
        }

        private void btnManifestation_MouseLeave(object sender, EventArgs e)
        {
            if (select != "btnManifestation")
            {
                btnManifestation.Image = CarantecAdminPanel.Properties.Resources.ManifestationsInverse;
            }
        }

        private void btnParticiper_MouseEnter(object sender, EventArgs e)
        {
            btnParticiper.Image = CarantecAdminPanel.Properties.Resources.ParticipationInverseRed;
        }

        private void btnParticiper_MouseLeave(object sender, EventArgs e)
        {
            if (select != "btnParticiper")
            {
                btnParticiper.Image = CarantecAdminPanel.Properties.Resources.ParticipationInverse;
            }
        }

        private void btnUsers_MouseEnter(object sender, EventArgs e)
        {
            btnUsers.Image = CarantecAdminPanel.Properties.Resources.UserInverseRed;
        }

        private void btnUsers_MouseLeave(object sender, EventArgs e)
        {
            if (select != "btnUsers")
            {
                btnUsers.Image = CarantecAdminPanel.Properties.Resources.UserInverse;
            }
        }

        private void btnPublic_MouseEnter(object sender, EventArgs e)
        {
            btnPublic.Image = CarantecAdminPanel.Properties.Resources.PublicInverseRed;
        }

        private void btnPublic_MouseLeave(object sender, EventArgs e)
        {
            if (select != "btnPublic")
            {
                btnPublic.Image = CarantecAdminPanel.Properties.Resources.PublicInverse;
            }
        }

        private void btnLieux_MouseEnter(object sender, EventArgs e)
        {
            btnLieux.Image = CarantecAdminPanel.Properties.Resources.LieuxInverseRed;
        }

        private void btnLieux_MouseLeave(object sender, EventArgs e)
        {
            if (select != "btnLieux")
            {
                btnLieux.Image = CarantecAdminPanel.Properties.Resources.LieuxInverse;
            }
        }

        private void btnReservation_MouseEnter(object sender, EventArgs e)
        {
            btnReservation.Image = CarantecAdminPanel.Properties.Resources.ReservationInverseRed;
        }

        private void btnReservation_MouseLeave(object sender, EventArgs e)
        {
            if (select != "btnReservation")
            {
                btnReservation.Image = CarantecAdminPanel.Properties.Resources.ReservationInverse;
            }
        }

        private void btnAvis_MouseEnter(object sender, EventArgs e)
        {
            btnAvis.Image = CarantecAdminPanel.Properties.Resources.AvisInverseRedH;
        }

        private void btnAvis_MouseLeave(object sender, EventArgs e)
        {
            if (select != "btnAvis")
            {
                btnAvis.Image = CarantecAdminPanel.Properties.Resources.AvisInverse;
            }
        }
    }
}
