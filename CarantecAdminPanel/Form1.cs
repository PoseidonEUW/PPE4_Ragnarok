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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controleur.init();
            Controleur.Vmodele.seconnecter();
            if (Controleur.Vmodele.Connopen == false)
            {
                MessageBox.Show("Erreur dans la connexion");
            }
            dgvDonnees.Visible = false;
            dgvDonnees.DefaultCellStyle.ForeColor = Color.White;
            dgvDonnees.DefaultCellStyle.BackColor = Color.FromArgb(37, 43, 61);
            dgvDonnees.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(22, 32, 51);
            dgvDonnees.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(22, 32, 51);
        }

        public void btnTables(string table)
        {
            tableG = table;
            Controleur.Vmodele.charger_donnees(table, -1, "");      // chargement des données de la table sélectionné dans le DT correspondant
            if (Controleur.Vmodele.Chargement)
            {
                // un DT par table
                bindingSource1 = new BindingSource();
                if (table == "utilisateur")
                {
                    bindingSource1.DataSource = Controleur.Vmodele.DT[1];
                    dgvDonnees.DataSource = bindingSource1;
                    dgvDonnees.Columns["IDPERSONNE"].HeaderText = "ID Utilisateur";
                    dgvDonnees.Columns["NOMPERSONNE"].HeaderText = "Nom";
                    dgvDonnees.Columns["PRENOMPERSONNE"].HeaderText = "Prénom";
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
                    bindingSource1.DataSource = Controleur.Vmodele.DT[4];
                    dgvDonnees.DataSource = bindingSource1;

                }
                else if (table == "avis")
                {
                    bindingSource1.DataSource = Controleur.Vmodele.DT[5];
                    dgvDonnees.DataSource = bindingSource1;
                }
                else if (table == "public")
                {
                    bindingSource1.DataSource = Controleur.Vmodele.DT[6];
                    dgvDonnees.DataSource = bindingSource1;
                }

                // mise à jour du dataGridView via le bindingSource rempli par le DataTable
                dgvDonnees.Refresh();
                dgvDonnees.Visible = true;
            }
            else
            {
                MessageBox.Show("Table non gérée encore", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvDonnees.Visible = false;
            }
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

        private void btnUsers_Click(object sender, EventArgs e)
        {
            btnTables("utilisateur");
        }

        private void btnFestival_Click(object sender, EventArgs e)
        {
            btnTables("festivalDisplay");
        }

        private void btnManifestation_Click(object sender, EventArgs e)
        {
            btnTables("manifestation");
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            btnTables("reservation");
        }

        private void btnLieux_Click(object sender, EventArgs e)
        {
            btnTables("lieu");
        }

        private void btnAvis_Click(object sender, EventArgs e)
        {
            btnTables("avis");
        }

        private void btnPublic_Click(object sender, EventArgs e)
        {
            btnTables("public");
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
                //if (tableG == "reservation") Controleur.crud_reservation('c', -1);
                //if (tableG == "avis") Controleur.crud_avis('c', -1);
                //if (tableG == "manifestation") Controleur.crud_manifestation('c', -1);
                //if (tableG == "public") Controleur.crud_public('c', -1);
                //if (tableG == "lieu") Controleur.crud_reparation('c', -1);
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
                        //if (tableG == "reservation") Controleur.crud_reservation('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        //if (tableG == "avis") Controleur.crud_avis('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        //if (tableG == "manifestation") Controleur.crud_manifestation('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        //if (tableG == "public") Controleur.crud_public('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        //if (tableG == "lieu") Controleur.crud_lieu('u', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                    }
                    if (sender == supprimerToolStripMenuItem)
                    {
                        if (tableG == "festivalDisplay") Controleur.crud_festival('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        if (tableG == "utilisateur") Controleur.crud_utilisateur('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        //if (tableG == "reservation") Controleur.crud_reservation('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        //if (tableG == "avis") Controleur.crud_avis('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        //if (tableG == "manifestation") Controleur.crud_manifestation('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        //if (tableG == "public") Controleur.crud_public('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
                        //if (tableG == "lieu") Controleur.crud_lieu('d', Convert.ToInt32(dgvDonnees.SelectedRows[0].Index));
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

        private void modifierToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            clickOnMenuItem(sender, e);
        }

        private void supprimerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            clickOnMenuItem(sender, e);
        }
    }
}
