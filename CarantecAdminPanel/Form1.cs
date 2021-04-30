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
            else if (table == "infosManif")
            {
                bindingSource1.DataSource = Controleur.Vmodele.DT[39];
                dgvDonnees.DataSource = bindingSource1;
                dgvDonnees.Columns["IDMANIF"].HeaderText = "ID Manif";
                dgvDonnees.Columns["ANNEEFESTIVAL"].HeaderText = "Année";
                dgvDonnees.Columns["LIBELLELIEU"].HeaderText = "Lieu";
                dgvDonnees.Columns["DATEMANIF"].HeaderText = "Date";
                dgvDonnees.Columns["LIBELLEMANIF"].HeaderText = "Libelle";
                dgvDonnees.Columns["HORAIREDEBUTMANIF"].HeaderText = "Horaire début";
                dgvDonnees.Columns["HORAIREFINMANIF"].HeaderText = "Horaire fin";
                dgvDonnees.Columns["JAUGEDISPOPERSMANIF"].HeaderText = "Places disponibles";
                dgvDonnees.Columns["JAUGEPERSMANIF"].HeaderText = "Places totales";
                dgvDonnees.Columns["DESCRIPTIONMANIF"].HeaderText = "Description";
                dgvDonnees.Columns["PRIXMANIF"].HeaderText = "Prix";
                dgvDonnees.Columns["IMGMANIF"].HeaderText = "Illustration";
                dgvDonnees.Columns["PUBLICVISE"].HeaderText = "Public visé";
            }
            else if (table == "infosReservation")
            {
                bindingSource1.DataSource = Controleur.Vmodele.DT[44];
                dgvDonnees.DataSource = bindingSource1;
                dgvDonnees.Columns["REFRESERVATION"].HeaderText = "Référence";
                dgvDonnees.Columns["LIBELLEMANIF"].HeaderText = "Manif";
                dgvDonnees.Columns["NOMPRENOM"].HeaderText = "Personne";
                dgvDonnees.Columns["QUANTITERESERVATION"].HeaderText = "Quantité";

            }
            else if (table == "lieu")
            {
                bindingSource1.DataSource = Controleur.Vmodele.DT[5];
                dgvDonnees.DataSource = bindingSource1;
                dgvDonnees.Columns["IDLIEU"].HeaderText = "ID Lieu";
                dgvDonnees.Columns["LIBELLELIEU"].HeaderText = "Libelle";
                dgvDonnees.Columns["CAPACITELIEU"].HeaderText = "Capacité max";
                dgvDonnees.Columns["INTERIEURLIEU"].HeaderText = "Intérieur";
            }
            else if (table == "infosAvis")
            {
                bindingSource1.DataSource = Controleur.Vmodele.DT[45];
                dgvDonnees.DataSource = bindingSource1;
                dgvDonnees.Columns["IDAVIS"].HeaderText = "ID Avis";
                dgvDonnees.Columns["LIBELLEMANIF"].HeaderText = "Manifestation";
                dgvDonnees.Columns["NOMPRENOM"].HeaderText = "Personne";
                dgvDonnees.Columns["LIBELLEAVIS"].HeaderText = "Libelle";
                dgvDonnees.Columns["NOTEAVIS"].HeaderText = "Note";
                dgvDonnees.Columns["VALIDEAVIS"].HeaderText = "Valide";
            }
            else if (table == "public")
            {
                bindingSource1.DataSource = Controleur.Vmodele.DT[7];
                dgvDonnees.DataSource = bindingSource1;
                dgvDonnees.Columns["IDPUBLIC"].HeaderText = "ID Public";
                dgvDonnees.Columns["LIBELLEPUBLIC"].HeaderText = "Libelle";
                dgvDonnees.Columns["DESCRIPTIONPUBLIC"].HeaderText = "Description";
            }
            else if (table == "infosParticiper")
            {
                bindingSource1.DataSource = Controleur.Vmodele.DT[43];
                dgvDonnees.DataSource = bindingSource1;
                dgvDonnees.Columns["LIBELLEMANIF"].HeaderText = "Manifestation";
                dgvDonnees.Columns["NOMPRENOM"].HeaderText = "Personne";
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
                    btnAvis.Image = CarantecAdminPanel.Properties.Resources.AvisInverseRed;
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
            btnTables("infosManif");
            dgvDonnees.Columns[0].Width = 100;
            dgvDonnees.Columns[1].Width = 100;
            dgvDonnees.Columns[2].Width = 75;
            dgvDonnees.Columns[3].Width = 150;
            dgvDonnees.Columns[10].Width = 90;
            dgvDonnees.Visible = true;
        }

        private void btnReservation_Click_1(object sender, EventArgs e)
        {
            refreshBtnColor("btnReservation");
            btnTables("infosReservation");
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
            btnTables("infosAvis");
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
                if (tableG == "infosManif") Controleur.crud_manifestation('c', -1);
                if (tableG == "infosReservation") MessageBox.Show("Erreur : Vous n'avez pas la possibilité d'ajouter une reservation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (tableG == "infosAvis") MessageBox.Show("Erreur : Vous n'avez pas la possibilité d'ajouter un avis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (tableG == "public") Controleur.crud_public('c', -1);
                if (tableG == "lieu") Controleur.crud_lieu('c', -1);
                if (tableG == "infosParticiper") Controleur.crud_participation('c', -1);
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
                        if (tableG == "infosManif") Controleur.crud_manifestation('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "infosReservation") MessageBox.Show("Erreur : Vous n'avez pas la possibilité de modifier une reservation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (tableG == "infosAvis") Controleur.crud_avis('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "public") Controleur.crud_public('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "lieu") Controleur.crud_lieu('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "infosParticiper") Controleur.crud_participation('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                    }
                    if (sender == supprimerToolStripMenuItem)
                    {
                        if (tableG == "festivalDisplay") Controleur.crud_festival('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "utilisateur") Controleur.crud_utilisateur('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "infosManif") Controleur.crud_manifestation('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "infosReservation") Controleur.crud_reservation('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "infosAvis") Controleur.crud_avis('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "public") Controleur.crud_public('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "lieu") Controleur.crud_lieu('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "infosParticiper") Controleur.crud_participation('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
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
            dgvDonnees.Visible = true;
        }

        private void btnParticiper_Click(object sender, EventArgs e)
        {
            refreshBtnColor("btnParticiper");
            btnTables("infosParticiper");
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
            btnAvis.Image = CarantecAdminPanel.Properties.Resources.AvisInverseRed;
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
