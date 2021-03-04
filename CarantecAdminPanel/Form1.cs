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
            Controleur.Vmodele.charger_donnees(table, -1);      // chargement des données de la table sélectionné dans le DT correspondant
            if (Controleur.Vmodele.Chargement)
            {
                // un DT par table
                bindingSource1 = new BindingSource();
                if (table == "utilisateur")
                {
                    bindingSource1.DataSource = Controleur.Vmodele.DT[1];
                    dgvDonnees.DataSource = bindingSource1;
                    //dgvDonnees.Columns["codeB"].HeaderText = "Code";
                    //dgvDonnees.Columns["nomB"].HeaderText = "Nom Borne";
                    //dgvDonnees.Columns["numRueB"].HeaderText = "Numéro Rue";
                    //dgvDonnees.Columns["nomRueB"].HeaderText = "Rue";
                    //dgvDonnees.Columns["latitudeB"].HeaderText = "Latitude";
                    //dgvDonnees.Columns["longitudeB"].HeaderText = "Longitude";

                }
                else if (table == "festival")
                {
                    bindingSource1.DataSource = Controleur.Vmodele.DT[2];
                    dgvDonnees.DataSource = bindingSource1;

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

        /// <summary>
        /// Gestion du menu contextuel pour AJOUTER/SUPPRIMER/MODIFIER des données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuStrip1_Click(object sender, EventArgs e)
        { 
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeco_Click(object sender, EventArgs e)
        {
            this.Close();
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
            btnTables("festival");
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
    }
}
