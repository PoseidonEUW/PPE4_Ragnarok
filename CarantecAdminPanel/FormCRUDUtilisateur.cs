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
    public partial class FormCRUDUtilisateur : Form
    {
        public FormCRUDUtilisateur(char etat)
        {
            InitializeComponent();
            if (etat == 'u')
            {
                tbEmailAdherentUser.Enabled = false;
                tbLogAdherentUser.Enabled = false;
                tbMdpAdherentUser.Enabled = false;
                tbRoleArtisteUser.Enabled = false;
                tbLienFBArtisteUser.Enabled = false;
                groupBox1.Enabled = false;
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbAdherentUser_CheckedChanged(object sender, EventArgs e)
        {
            refreshRb("adherent");
        }

        private void rbAnimUser_CheckedChanged(object sender, EventArgs e)
        {
            refreshRb("animateur");
        }

        private void rbArtisteUser_CheckedChanged(object sender, EventArgs e)
        {
            refreshRb("artiste");
        }

        private void rbIntSpeUser_CheckedChanged(object sender, EventArgs e)
        {
            refreshRb("IntSpe");
        }

        private void refreshRb(string role)
        {
            tbEmailAdherentUser.Enabled = false;
            tbLogAdherentUser.Enabled = false;
            tbMdpAdherentUser.Enabled = false;
            tbRoleArtisteUser.Enabled = false;
            tbLienFBArtisteUser.Enabled = false;
            if (role == "adherent")
            {
                tbEmailAdherentUser.Enabled = true;
                tbLogAdherentUser.Enabled = true;
                tbMdpAdherentUser.Enabled = true;
            }
            if (role == "artiste")
            {
                tbRoleArtisteUser.Enabled = true;
                tbLienFBArtisteUser.Enabled = true;
            }
        }

        private void groupBox1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void labelActionTitle_Click(object sender, EventArgs e)
        {

        }

        private void FormCRUDUtilisateur_Load(object sender, EventArgs e)
        {

        }
    }
}
