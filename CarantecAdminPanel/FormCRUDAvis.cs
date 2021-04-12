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
    public partial class FormCRUDAvis : Form
    {
        int avisCache = 0;

        public FormCRUDAvis()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bNote1Avis_Click(object sender, EventArgs e)
        {
            refreshAvis(1);
        }

        private void bNote2Avis_Click(object sender, EventArgs e)
        {
            refreshAvis(2);
        }

        private void bNote3Avis_Click(object sender, EventArgs e)
        {
            refreshAvis(3);
        }

        private void bNote4Avis_Click(object sender, EventArgs e)
        {
            refreshAvis(4);
        }

        private void bNote5Avis_Click(object sender, EventArgs e)
        {
            refreshAvis(5);
        }

        private void refreshAvis(int note)
        {

            bNote1Avis.BackgroundImage = Properties.Resources.EtoileVide;
            bNote2Avis.BackgroundImage = Properties.Resources.EtoileVide;
            bNote3Avis.BackgroundImage = Properties.Resources.EtoileVide;
            bNote4Avis.BackgroundImage = Properties.Resources.EtoileVide;
            bNote5Avis.BackgroundImage = Properties.Resources.EtoileVide;
            if (avisCache == note) note = 0;
            switch (note)
            {
                case 1:
                    bNote1Avis.BackgroundImage = Properties.Resources.EtoileRempli;
                    break;
                case 2:
                    bNote1Avis.BackgroundImage = Properties.Resources.EtoileRempli;
                    bNote2Avis.BackgroundImage = Properties.Resources.EtoileRempli;
                    break;
                case 3:
                    bNote1Avis.BackgroundImage = Properties.Resources.EtoileRempli;
                    bNote2Avis.BackgroundImage = Properties.Resources.EtoileRempli;
                    bNote3Avis.BackgroundImage = Properties.Resources.EtoileRempli;
                    break;
                case 4:
                    bNote1Avis.BackgroundImage = Properties.Resources.EtoileRempli;
                    bNote2Avis.BackgroundImage = Properties.Resources.EtoileRempli;
                    bNote3Avis.BackgroundImage = Properties.Resources.EtoileRempli;
                    bNote4Avis.BackgroundImage = Properties.Resources.EtoileRempli;
                    break;
                case 5:
                    bNote1Avis.BackgroundImage = Properties.Resources.EtoileRempli;
                    bNote2Avis.BackgroundImage = Properties.Resources.EtoileRempli;
                    bNote3Avis.BackgroundImage = Properties.Resources.EtoileRempli;
                    bNote4Avis.BackgroundImage = Properties.Resources.EtoileRempli;
                    bNote5Avis.BackgroundImage = Properties.Resources.EtoileRempli;
                    break;
            }
            avisCache = note;
        }
    }
}
