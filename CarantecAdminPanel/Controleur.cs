using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarantecAdminPanel
{
    /// <summary>
    /// Controleur du projet CARANTEC
    /// </summary>
    class Controleur
    {
        #region propriétés
        public static Modele vmodele;
        #endregion

        #region accesseurs
        /// <summary>
        /// propriété Vmodele
        /// </summary>
        public static Modele Vmodele
        {
            get { return vmodele; }
            set { vmodele = value; }
        }
        #endregion

        #region methodes modele
        /// <summary>
        /// instanciation du modele
        /// </summary>
        public static void init()
        {
            Vmodele = new Modele();
        }
        #endregion

        #region MD5
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
        #endregion

        #region CRUDs

            #region crudFestival
            public static void crud_festival(Char c, int indice)
            {
                Controleur.Vmodele.charger_donnees("festival", -1, "","");
                Controleur.Vmodele.charger_donnees("respToPers", -1, "", "");
                Controleur.Vmodele.charger_donnees("thematique", -1, "", "");
                Controleur.Vmodele.charger_donnees("responsable", -1, "", "");
                if (c == 'd') // cas de la suppression
                {
                    //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer le festival " + vmodele.DT[2].Rows[indice][3].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rep == DialogResult.Yes)
                    {
                        vmodele.DT[2].Rows[indice].Delete();		// suppression dans le DataTable
                        vmodele.DA[2].Update(vmodele.DT[2]);        // on supprime l’élément du DataTable
                    }
                }
                else
                {
                    // cas de l'ajout et modification
                    FormCRUDFestival formCRUD = new FormCRUDFestival();  // création de la nouvelle forme
                    if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                    {
                        formCRUD.DateTimeAnnee.Value = DateTime.Now;
                        for (int i = 0; i < vmodele.DT[10].Rows.Count; i++)
                        {
                            formCRUD.CbThematique.Items.Add(vmodele.DT[10].Rows[i][1].ToString());
                        }
                        formCRUD.CbThematique.SelectedIndex = -1;
                        for (int i = 0; i < vmodele.DT[11].Rows.Count; i++)
                        {
                            formCRUD.CbResponsable.Items.Add(vmodele.DT[11].Rows[i][0].ToString());
                        }
                        formCRUD.CbResponsable.SelectedIndex = -1;
                        formCRUD.TbNomFestival.Text = "";
                    }
                    if (c == 'u')   // mode update donc on récupère les champs
                    {
                        formCRUD.DateTimeAnnee.Value = new DateTime(Convert.ToInt32(vmodele.DT[9].Rows[indice][0].ToString()), 1, 1);
                        for (int i = 0; i < vmodele.DT[10].Rows.Count; i++)
                        {
                            formCRUD.CbThematique.Items.Add(vmodele.DT[10].Rows[i][1].ToString());
                        }
                        formCRUD.CbThematique.SelectedItem = vmodele.DT[9].Rows[indice][2].ToString();
                        for (int i = 0; i < vmodele.DT[11].Rows.Count; i++)
                        {
                            formCRUD.CbResponsable.Items.Add(vmodele.DT[11].Rows[i][0].ToString());
                        }
                        formCRUD.CbResponsable.SelectedItem = vmodele.DT[9].Rows[indice][3].ToString();
                        formCRUD.TbNomFestival.Text = vmodele.DT[9].Rows[indice][1].ToString();
                    }
                eti:
                    // on affiche la nouvelle form
                    formCRUD.ShowDialog();

                    // si l’utilisateur clique sur OK
                    if (formCRUD.DialogResult == DialogResult.OK)
                    {
                        if (c == 'c') // ajout
                        {
                            // on crée une nouvelle ligne dans le dataView
                            if (formCRUD.TbNomFestival.Text != "" && formCRUD.CbThematique.SelectedIndex != -1 && formCRUD.CbResponsable.SelectedIndex != -1)
                            {
                                DataRow NouvLigne = vmodele.DT[2].NewRow();
                                NouvLigne["ANNEEFESTIVAL"] = Convert.ToInt32(formCRUD.DateTimeAnnee.Value.Year);
                                string libelleTheme = formCRUD.CbThematique.SelectedItem.ToString();
                                Controleur.Vmodele.charger_donnees("nomThemeToIdTheme", -1, libelleTheme, "");
                                NouvLigne["IDTHEMATIQUE"] = Convert.ToInt32(vmodele.DT[14].Rows[0][0].ToString());
                                string nomPrenom = formCRUD.CbResponsable.SelectedItem.ToString();
                                string[] nomPrenomSplit = nomPrenom.Split(' ');
                                string nom = nomPrenomSplit[0];
                                Controleur.Vmodele.charger_donnees("persToResp", -1, nom, "");
                                NouvLigne["IDPERSONNE"] = Convert.ToInt32(vmodele.DT[13].Rows[0][0].ToString());
                                NouvLigne["NOMFESTIVAL"] = formCRUD.TbNomFestival.Text;
                                vmodele.DT[2].Rows.Add(NouvLigne);
                                try
                                {
                                    vmodele.DA[2].Update(vmodele.DT[2]);
                                }
                                catch
                                {
                                    MessageBox.Show("Erreur : Le Festival édition " + formCRUD.DateTimeAnnee.Value.Year.ToString() + " existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    goto eti;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Erreur : il faut remplir tout les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                goto eti;
                            }
                        }

                        if (c == 'u')  // modif
                        {
                            if (formCRUD.TbNomFestival.Text != "" && formCRUD.CbThematique.SelectedIndex != -1 && formCRUD.CbResponsable.SelectedIndex != -1)
                            {
                                vmodele.DT[2].Rows[indice]["ANNEEFESTIVAL"] = Convert.ToInt32(formCRUD.DateTimeAnnee.Value.Year);
                                string libelleTheme = formCRUD.CbThematique.SelectedItem.ToString();
                                Controleur.Vmodele.charger_donnees("nomThemeToIdTheme", -1, libelleTheme, "");
                                vmodele.DT[2].Rows[indice]["IDTHEMATIQUE"] = Convert.ToInt32(vmodele.DT[14].Rows[0][0].ToString());
                                string nomPrenom = formCRUD.CbResponsable.SelectedItem.ToString();
                                string[] nomPrenomSplit = nomPrenom.Split(' ');
                                string nom = nomPrenomSplit[0];
                                Controleur.Vmodele.charger_donnees("persToResp", -1, nom, "");
                                vmodele.DT[2].Rows[indice]["IDPERSONNE"] = Convert.ToInt32(vmodele.DT[13].Rows[0][0].ToString());
                                vmodele.DT[2].Rows[indice]["NOMFESTIVAL"] = formCRUD.TbNomFestival.Text;
                                try
                                {
                                    vmodele.DA[2].Update(vmodele.DT[2]);
                                }
                                catch
                                {
                                    MessageBox.Show("Erreur : Le Festival édition " + formCRUD.DateTimeAnnee.Value.Year.ToString() + " existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    goto eti;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Erreur : il faut remplir tout les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                goto eti;
                            }
                        }

                        MessageBox.Show("OK : données enregistrées festival");
                        formCRUD.Dispose();  // on ferme la form
                    }
                    else
                    {
                        MessageBox.Show("Annulation : aucune donnée enregistrée festival");
                        formCRUD.Dispose();
                    }
                }
            }
            #endregion

            #region crudUtilisateur
            public static void crud_utilisateur(Char c, int indice)
            {
                Controleur.Vmodele.charger_donnees("utilisateur", -1, "", "");
                Controleur.Vmodele.charger_donnees("personnesimplifie", -1, "", "");
                if (c == 'd') // cas de la suppression
                {
                    //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer cet utilisateur " + vmodele.DT[1].Rows[indice][1].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rep == DialogResult.Yes)
                    {
                        vmodele.DT[1].Rows[indice].Delete();		// suppression dans le DataTable
                        vmodele.DA[1].Update(vmodele.DT[1]);        // on supprime l’élément du DataTable
                    }
                }
                else
                {
                    // cas de l'ajout et modification
                    FormCRUDUtilisateur formCRUD = new FormCRUDUtilisateur(c);  // création de la nouvelle forme
                    FormUpdateUtilisateur formUpdate = new FormUpdateUtilisateur(c);
                    if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                    {
                        formCRUD.TbNom.Clear();
                        formCRUD.TbPrenom.Clear();
                    }
                    if (c == 'u')   // mode update donc on récupère les champs
                    {
                        // on remplit les zones par les valeurs du dataGridView correspondantes
                        formUpdate.TbNom.Text = vmodele.DT[1].Rows[indice][1].ToString();
                        formUpdate.TbPrenom.Text = vmodele.DT[1].Rows[indice][2].ToString();
                    }
                eti:
                    // on affiche la nouvelle form
                    if(c == 'c')
                    {
                        formCRUD.ShowDialog();
                        // si l’utilisateur clique sur OK
                        if (formCRUD.DialogResult == DialogResult.OK)
                        {
                            DataRow NouvLigne = vmodele.DT[1].NewRow();
                            // on crée une nouvelle ligne dans le dataView
                            if (formCRUD.TbNom.Text != "" && formCRUD.TbPrenom.Text != "")
                            {
                                NouvLigne["IDPERSONNE"] = Convert.ToInt32(vmodele.DT[1].Rows[vmodele.DT[1].Rows.Count - 1][0]);
                                NouvLigne["PRENOMPERSONNE"] = formCRUD.TbPrenom.Text;
                                NouvLigne["NOMPERSONNE"] = formCRUD.TbNom.Text;
                                NouvLigne["EMAILPERSONNE"] = formCRUD.TbEmailUser.Text;
                                vmodele.DT[1].Rows.Add(NouvLigne);
                                vmodele.DA[1].Update(vmodele.DT[1]);
                                if (formCRUD.RbArtisteUser.Checked == true)
                                {
                                    if (formCRUD.TbRoleArtisteUser.Text != "")
                                    {
                                        Controleur.Vmodele.charger_donnees("artiste", -1, "", "");
                                        Controleur.Vmodele.charger_donnees("personne", -1, "", "");
                                        DataRow NouvLigne2 = vmodele.DT[16].NewRow();
                                        NouvLigne2["IDPERSONNE"] = Convert.ToInt32(vmodele.DT[1].Rows[vmodele.DT[1].Rows.Count - 1][0]) + 1;
                                        NouvLigne2["ROLEARTISTE"] = formCRUD.TbRoleArtisteUser.Text;
                                        NouvLigne2["IMGARTISTE"] = formCRUD.TbURLArtisteUser.Text;
                                        if(formCRUD.TbLienFBArtisteUser.Text != "")
                                        {
                                            NouvLigne2["LIENFBSITEARTISTE"] = formCRUD.TbLienFBArtisteUser.Text;
                                        }
                                        vmodele.DT[16].Rows.Add(NouvLigne2);
                                        vmodele.DA[16].Update(vmodele.DT[16]);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Erreur : vous avez oubliez de remplir les champs correspondant à l'artiste", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        goto eti;
                                    }
                                }
                                if (formCRUD.RbAnimUser.Checked == true)
                                {
                                    Controleur.Vmodele.charger_donnees("animateur", -1, "", "");
                                    DataRow NouvLigne3 = vmodele.DT[17].NewRow();
                                    NouvLigne3["IDPERSONNE"] = Convert.ToInt32(vmodele.DT[1].Rows[vmodele.DT[1].Rows.Count - 1][0]) + 1;
                                    vmodele.DT[17].Rows.Add(NouvLigne3);
                                    vmodele.DA[17].Update(vmodele.DT[17]);
                                }
                                if (formCRUD.RbIntSpeUser.Checked == true)
                                {
                                    Controleur.Vmodele.charger_donnees("intSpe", -1, "", "");
                                    DataRow NouvLigne4 = vmodele.DT[18].NewRow();
                                    NouvLigne4["IDPERSONNE"] = Convert.ToInt32(vmodele.DT[1].Rows[vmodele.DT[1].Rows.Count - 1][0]) + 1;
                                    vmodele.DT[18].Rows.Add(NouvLigne4);
                                    vmodele.DA[18].Update(vmodele.DT[18]);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Erreur : il faut saisir au moins le nom, le prenom et l'url de la photo de profil", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                goto eti;
                            }
                        }
                    }
                    if(c == 'u')
                    {
                        formUpdate.ShowDialog();

                        // si l’utilisateur clique sur OK
                        if (formUpdate.DialogResult == DialogResult.OK)
                        {
                            if (formUpdate.TbNom.Text != "" && formUpdate.TbPrenom.Text != "")
                            {
                                // on met à jour le dataTable avec les nouvelles valeurs
                                vmodele.DT[1].Rows[indice]["NOMPERSONNE"] = formUpdate.TbNom.Text;
                                vmodele.DT[1].Rows[indice]["PRENOMPERSONNE"] = formUpdate.TbPrenom.Text;
                                vmodele.DA[1].Update(vmodele.DT[1]);
                            }
                            else
                            {
                                MessageBox.Show("Erreur : il faut saisir au moins la nom et le prenom", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                goto eti;
                            }
                        }
                    }
                }
            }
            #endregion

            #region crud_manifestation

            public static void crud_manifestation(Char c, int indice)
            {
                Controleur.Vmodele.charger_donnees("manifestation", -1, "", "");
                Controleur.Vmodele.charger_donnees("lieu", -1, "", "");
                Controleur.Vmodele.charger_donnees("festival", -1, "", "");
                Controleur.Vmodele.charger_donnees("nomspublic", -1, "", "");
                Controleur.Vmodele.charger_donnees("viser", -1, "", "");
                if (c == 'd') // cas de la suppression
                {
                    //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer la manifestation " + vmodele.DT[3].Rows[indice][3].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rep == DialogResult.Yes)
                    {
                        vmodele.DT[3].Rows[indice].Delete();		// suppression dans le DataTable
                        vmodele.DA[3].Update(vmodele.DT[3]);        // on supprime l’élément du DataTable
                    }
                }
                else
                {
                    // cas de l'ajout et modification
                    FormCRUDManifestation formCRUD = new FormCRUDManifestation();  // création de la nouvelle forme
                    if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                    {
                        formCRUD.GbTypeManif.Enabled = true;
                        for (int i = 0; i < vmodele.DT[5].Rows.Count; i++)
                        {
                            formCRUD.ComboBoxLieuManif.Items.Add(vmodele.DT[5].Rows[i][1].ToString());
                        }
                        formCRUD.ComboBoxLieuManif.SelectedIndex = -1;
                        for (int i = 0; i < vmodele.DT[2].Rows.Count; i++)
                        {
                            formCRUD.CbAnnee.Items.Add(vmodele.DT[2].Rows[i][0].ToString());
                        }
                        formCRUD.CbAnnee.SelectedIndex = -1;
                        for (int i = 0; i < vmodele.DT[38].Rows.Count; i++)
                        {
                            formCRUD.CbPublic.Items.Add(vmodele.DT[38].Rows[i][1].ToString());
                        }
                        formCRUD.CbPublic.SelectedIndex = -1;
                        formCRUD.TbLibelleManif.Text = "";
                        formCRUD.TbJaugeManif.Text = "";
                        formCRUD.TbPrixManif.Text = "";
                        formCRUD.TbURL.Text = "";
                        formCRUD.RtbDescManif.Text = "";
                    }
                    if (c == 'u')   // mode update donc on récupère les champs
                    {
                        Controleur.Vmodele.charger_donnees("nomsLieuxFromManifs", -1, "", "");
                        formCRUD.GbTypeManif.Enabled = false;
                        for (int i = 0; i < vmodele.DT[5].Rows.Count; i++)
                        {
                            formCRUD.ComboBoxLieuManif.Items.Add(vmodele.DT[5].Rows[i][1].ToString());
                        }
                        for (int i = 0; i < vmodele.DT[2].Rows.Count; i++)
                        {
                            formCRUD.CbAnnee.Items.Add(vmodele.DT[2].Rows[i][0].ToString());
                        }
                        formCRUD.ComboBoxLieuManif.SelectedItem = vmodele.DT[20].Rows[indice][2].ToString(); ;
                        formCRUD.CbAnnee.SelectedItem = vmodele.DT[3].Rows[indice][1].ToString();
                        for (int i = 0; i < vmodele.DT[38].Rows.Count; i++)
                        {
                            formCRUD.CbPublic.Items.Add(vmodele.DT[38].Rows[i][1].ToString());
                        }
                        formCRUD.CbPublic.SelectedItem = vmodele.DT[39].Rows[indice][12].ToString();
                        formCRUD.TbLibelleManif.Text = vmodele.DT[3].Rows[indice][3].ToString();
                        formCRUD.DateManif.Value = Convert.ToDateTime(vmodele.DT[3].Rows[indice][4]);
                        formCRUD.HeureManif1.Text = vmodele.DT[3].Rows[indice][5].ToString();
                        formCRUD.HeureManifFin1.Text = vmodele.DT[3].Rows[indice][6].ToString();
                        formCRUD.TbJaugeManif.Text = vmodele.DT[3].Rows[indice][8].ToString();
                        formCRUD.RtbDescManif.Text = vmodele.DT[3].Rows[indice][9].ToString();
                        formCRUD.TbPrixManif.Text = vmodele.DT[3].Rows[indice][10].ToString();
                        formCRUD.TbURL.Text = vmodele.DT[3].Rows[indice][11].ToString();
                    }
                eti:
                    // on affiche la nouvelle form
                    formCRUD.ShowDialog();

                    // si l’utilisateur clique sur OK
                    if (formCRUD.DialogResult == DialogResult.OK)
                    {
                        if (c == 'c') // ajout
                        {
                            // on crée une nouvelle ligne dans le dataView
                            if ((formCRUD.RbAtelierManif.Checked == true || formCRUD.RbConcertManif.Checked == true || formCRUD.RbConferenceManif.Checked == true || formCRUD.RbDebatManif.Checked == true) && formCRUD.ComboBoxLieuManif.SelectedIndex != -1 && formCRUD.CbAnnee.SelectedIndex != -1 && formCRUD.TbJaugeManif.Text != "" && formCRUD.RtbDescManif.Text != "" && formCRUD.TbLibelleManif.Text != "" && formCRUD.TbURL.Text != "" && formCRUD.CbPublic.SelectedIndex != -1)
                            {
                                if (formCRUD.TbPrixManif.Text != "")
                                {
                                    if (Convert.ToInt32(formCRUD.TbJaugeManif.Text) < 0 || Convert.ToInt32(formCRUD.TbPrixManif.Text) < 0)
                                    {
                                        MessageBox.Show("Erreur : Le prix ou la jauge de la manifestation ne doit être inférieur à 0", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        goto eti;
                                    }
                                }
                                if (Convert.ToInt32(formCRUD.TbJaugeManif.Text) < 0)
                                {
                                    MessageBox.Show("Erreur : Le prix ou la jauge de la manifestation ne doit être inférieur à 0", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    goto eti;
                                }
                                else
                                {
                                    DataRow NouvLigne = vmodele.DT[3].NewRow();
                                    NouvLigne["IDMANIF"] = Convert.ToInt32(vmodele.DT[3].Rows[vmodele.DT[3].Rows.Count - 1][0]);
                                    NouvLigne["ANNEEFESTIVAL"] = Convert.ToInt32(formCRUD.CbAnnee.SelectedItem);
                                    string libelleLieu = formCRUD.ComboBoxLieuManif.SelectedItem.ToString();
                                    Controleur.Vmodele.charger_donnees("totalCapaciteRestanteLieu ", -1, libelleLieu, "");
                                    try
                                    {
                                        if ((Convert.ToInt32(vmodele.DT[42].Rows[0][0].ToString()) - Convert.ToInt32(formCRUD.TbJaugeManif.Text)) >= 0)
                                        {
                                            Controleur.Vmodele.charger_donnees("nomLieuToIdLieu", -1, libelleLieu, "");
                                            NouvLigne["IDLIEU"] = Convert.ToInt32(vmodele.DT[19].Rows[0][0].ToString());
                                        }
                                        else
                                        {
                                            MessageBox.Show("Erreur : Le capacité du lieu sélectionné est dépassée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            goto eti;
                                        }
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Erreur : Le capacité du lieu sélectionné est dépassée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        goto eti;
                                    }
                                    NouvLigne["LIBELLEMANIF"] = formCRUD.TbLibelleManif.Text;
                                    NouvLigne["DATEMANIF"] = formCRUD.DateManif.Text + " " + formCRUD.CbAnnee.SelectedItem.ToString();
                                    if(formCRUD.HeureManif1.Value < formCRUD.HeureManifFin1.Value)
                                    {
                                        NouvLigne["HORAIREDEBUTMANIF"] = formCRUD.HeureManif1.Text;
                                        NouvLigne["HORAIREFINMANIF"] = formCRUD.HeureManifFin1.Text;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Erreur : L'heure de fin est inférieure à l'heure de début", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        goto eti;
                                    }
                                    NouvLigne["JAUGEPERSMANIF"] = Convert.ToInt32(formCRUD.TbJaugeManif.Text);
                                    NouvLigne["JAUGEDISPOPERSMANIF"] = Convert.ToInt32(formCRUD.TbJaugeManif.Text);
                                    NouvLigne["DESCRIPTIONMANIF"] = formCRUD.RtbDescManif.Text;
                                    if (formCRUD.TbPrixManif.Text != "") NouvLigne["PRIXMANIF"] = Convert.ToInt32(formCRUD.TbPrixManif.Text);
                                    NouvLigne["IMGMANIF"] = formCRUD.TbURL.Text;
                                    vmodele.DT[3].Rows.Add(NouvLigne);
                                    vmodele.DA[3].Update(vmodele.DT[3]);
                                    Controleur.Vmodele.charger_donnees("manifestation", -1, "", "");
                                    if (formCRUD.RbAtelierManif.Checked == true)
                                    {
                                        Controleur.Vmodele.charger_donnees("atelier", -1, "", "");
                                        DataRow NouvLigne1 = vmodele.DT[30].NewRow();
                                        NouvLigne1["IDMANIF"] = Convert.ToInt32(vmodele.DT[3].Rows[vmodele.DT[3].Rows.Count - 1][0]);
                                        vmodele.DT[30].Rows.Add(NouvLigne1);
                                        vmodele.DA[30].Update(vmodele.DT[30]);
                                    }
                                    if (formCRUD.RbConcertManif.Checked == true)
                                    {
                                        Controleur.Vmodele.charger_donnees("concert", -1, "", "");
                                        DataRow NouvLigne1 = vmodele.DT[31].NewRow();
                                        NouvLigne1["IDMANIF"] = Convert.ToInt32(vmodele.DT[3].Rows[vmodele.DT[3].Rows.Count - 1][0]);
                                        vmodele.DT[31].Rows.Add(NouvLigne1);
                                        vmodele.DA[31].Update(vmodele.DT[31]);
                                    }
                                    if (formCRUD.RbConferenceManif.Checked == true)
                                    {
                                        Controleur.Vmodele.charger_donnees("conference", -1, "", "");
                                        DataRow NouvLigne1 = vmodele.DT[32].NewRow();
                                        NouvLigne1["IDMANIF"] = Convert.ToInt32(vmodele.DT[3].Rows[vmodele.DT[3].Rows.Count - 1][0]);
                                        vmodele.DT[32].Rows.Add(NouvLigne1);
                                        vmodele.DA[32].Update(vmodele.DT[32]);
                                    }
                                    if (formCRUD.RbDebatManif.Checked == true)
                                    {
                                        Controleur.Vmodele.charger_donnees("debat", -1, "", "");
                                        DataRow NouvLigne1 = vmodele.DT[33].NewRow();
                                        NouvLigne1["IDMANIF"] = Convert.ToInt32(vmodele.DT[3].Rows[vmodele.DT[3].Rows.Count - 1][0]);
                                        vmodele.DT[33].Rows.Add(NouvLigne1);
                                        vmodele.DA[33].Update(vmodele.DT[33]);
                                    }
                                    DataRow NouvLigne2 = vmodele.DT[40].NewRow();
                                    Controleur.Vmodele.charger_donnees("nomsPublicToIdPublic", -1, formCRUD.CbPublic.SelectedItem.ToString(), "");
                                    NouvLigne2["IDPUBLIC"] = Convert.ToInt32(vmodele.DT[41].Rows[0][0].ToString());
                                    NouvLigne2["IDMANIF"] = Convert.ToInt32(vmodele.DT[3].Rows[vmodele.DT[3].Rows.Count - 1][0]);
                                    vmodele.DT[40].Rows.Add(NouvLigne2);
                                    vmodele.DA[40].Update(vmodele.DT[40]);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Erreur : il faut remplir tout les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                goto eti;
                            }
                        }

                        if (c == 'u')  // modif
                        {
                            if (formCRUD.ComboBoxLieuManif.SelectedIndex != -1 && formCRUD.CbAnnee.SelectedIndex != -1 && formCRUD.TbJaugeManif.Text != "" && formCRUD.RtbDescManif.Text != "" && formCRUD.TbLibelleManif.Text != "" && formCRUD.TbURL.Text != "" && formCRUD.CbPublic.SelectedIndex != -1)
                            {
                                if (formCRUD.TbPrixManif.Text != "")
                                {
                                    if (Convert.ToInt32(formCRUD.TbJaugeManif.Text) < 0 || Convert.ToInt32(formCRUD.TbPrixManif.Text) < 0)
                                    {
                                        MessageBox.Show("Erreur : Le prix ou la jauge de la manifestation ne doit être inférieur à 0", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        goto eti;
                                    }
                                }
                                if (Convert.ToInt32(formCRUD.TbJaugeManif.Text) < 0)
                                {
                                    MessageBox.Show("Erreur : Le prix ou la jauge de la manifestation ne doit être inférieur à 0", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    goto eti;
                                }
                                else
                                {
                                    vmodele.DT[3].Rows[indice]["ANNEEFESTIVAL"] = Convert.ToInt32(formCRUD.CbAnnee.SelectedItem);
                                    string libelleLieu = formCRUD.ComboBoxLieuManif.SelectedItem.ToString();
                                    Controleur.Vmodele.charger_donnees("nomLieuToIdLieu", -1, libelleLieu, "");
                                    Controleur.Vmodele.charger_donnees("totalCapaciteRestanteLieu", -1, libelleLieu, "");
                                    if ((Convert.ToInt32(vmodele.DT[42].Rows[0][0].ToString()) - Convert.ToInt32(formCRUD.TbJaugeManif.Text)) >= 0)
                                    {
                                        Controleur.Vmodele.charger_donnees("nomLieuToIdLieu", -1, libelleLieu, "");
                                        vmodele.DT[3].Rows[indice]["IDLIEU"] = Convert.ToInt32(vmodele.DT[19].Rows[0][0].ToString());
                                    }
                                    else
                                    {
                                        MessageBox.Show("Erreur : Le capacité du lieu sélectionné est dépassée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        goto eti;
                                    }
                                    vmodele.DT[3].Rows[indice]["LIBELLEMANIF"] = formCRUD.TbLibelleManif.Text;
                                    vmodele.DT[3].Rows[indice]["DATEMANIF"] = formCRUD.DateManif.Text + " " + formCRUD.CbAnnee.SelectedItem.ToString();
                                    if (formCRUD.HeureManif1.Value < formCRUD.HeureManifFin1.Value)
                                    {
                                        vmodele.DT[3].Rows[indice]["HORAIREDEBUTMANIF"] = formCRUD.HeureManif1.Text;
                                        vmodele.DT[3].Rows[indice]["HORAIREFINMANIF"] = formCRUD.HeureManifFin1.Text;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Erreur : L'heure de fin est inférieure à l'heure de début", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        goto eti;
                                    }
                                    int jaugeAfterUpdate = 0;
                                    jaugeAfterUpdate = Convert.ToInt32(formCRUD.TbJaugeManif.Text) - (Convert.ToInt32(vmodele.DT[3].Rows[indice]["JAUGEPERSMANIF"]) - Convert.ToInt32(vmodele.DT[3].Rows[indice]["JAUGEDISPOPERSMANIF"]));
                                    if (jaugeAfterUpdate >= 0)
                                    {
                                        vmodele.DT[3].Rows[indice]["JAUGEPERSMANIF"] = Convert.ToInt32(formCRUD.TbJaugeManif.Text);
                                        vmodele.DT[3].Rows[indice]["JAUGEDISPOPERSMANIF"] = jaugeAfterUpdate;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Erreur : La jauge de la manifestation que vous souhaitez modifier possède actuellement un surplus de réservations par rapport à la nouvelle jauge souhaitée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        goto eti;
                                    }
                                    vmodele.DT[3].Rows[indice]["DESCRIPTIONMANIF"] = formCRUD.RtbDescManif.Text;
                                    if (formCRUD.TbPrixManif.Text != "") vmodele.DT[3].Rows[indice]["PRIXMANIF"] = Convert.ToInt32(formCRUD.TbPrixManif.Text);
                                    else vmodele.DT[3].Rows[indice]["PRIXMANIF"] = 0;
                                    vmodele.DT[3].Rows[indice]["IMGMANIF"] = formCRUD.TbURL.Text;
                                    Controleur.Vmodele.charger_donnees("nomsPublicToIdPublic", -1, formCRUD.CbPublic.SelectedItem.ToString(), "");
                                    Controleur.Vmodele.updatePublic(Convert.ToInt32(vmodele.DT[41].Rows[0][0].ToString()), Convert.ToInt32(vmodele.DT[3].Rows[indice]["IDMANIF"]));
                                    vmodele.DA[3].Update(vmodele.DT[3]);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Erreur : il faut remplir tout les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                goto eti;
                            }
                        }
                    }
                }
            }

            #endregion

            #region crud_lieu

            public static void crud_lieu(Char c, int indice)
            {
                Controleur.Vmodele.charger_donnees("lieu", -1, "", "");
                if (c == 'd') // cas de la suppression
                {
                    //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer le lieu " + vmodele.DT[5].Rows[indice][1].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rep == DialogResult.Yes)
                    {
                        vmodele.DT[5].Rows[indice].Delete();		// suppression dans le DataTable
                        vmodele.DA[5].Update(vmodele.DT[5]);        // on supprime l’élément du DataTable
                    }
                }
                else
                {
                    // cas de l'ajout et modification
                    FormCRUDLieux formCRUD = new FormCRUDLieux();  // création de la nouvelle forme
                    if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                    {
                        formCRUD.RtbLibelleLieux.Text = "";
                        formCRUD.NudCapaciteLieu.Text = "";
                        formCRUD.RbExtLieux.Checked = true;
                        formCRUD.RbIntLieux.Checked = false;
                    }

                    if (c == 'u')   // mode update donc on récupère les champs
                    {
                        formCRUD.RtbLibelleLieux.Text = vmodele.DT[5].Rows[indice][1].ToString();
                        formCRUD.NudCapaciteLieu.Text = vmodele.DT[5].Rows[indice][2].ToString();
                        formCRUD.RbExtLieux.Checked = Convert.ToInt32(vmodele.DT[5].Rows[indice][3]) == 0;
                        formCRUD.RbIntLieux.Checked = (Convert.ToInt32(vmodele.DT[5].Rows[indice][3]) == 1);
                    }
                eti:
                    // on affiche la nouvelle form
                    formCRUD.ShowDialog();

                    // si l’utilisateur clique sur OK
                    if (formCRUD.DialogResult == DialogResult.OK)
                    {
                        if (c == 'c') // ajout
                        {
                            // on crée une nouvelle ligne dans le dataView
                            if (formCRUD.RtbLibelleLieux.Text != "" && formCRUD.NudCapaciteLieu.Text != "")
                            {
                                DataRow NouvLigne = vmodele.DT[5].NewRow();
                                NouvLigne["IDLIEU"] = Convert.ToInt32(vmodele.DT[5].Rows[vmodele.DT[5].Rows.Count - 1][0]);
                                NouvLigne["LIBELLELIEU"] = formCRUD.RtbLibelleLieux.Text;
                                NouvLigne["CAPACITELIEU"] = formCRUD.NudCapaciteLieu.Value;
                                if (formCRUD.RbExtLieux.Checked) NouvLigne["INTERIEURLIEU"] = 0;
                                else NouvLigne["INTERIEURLIEU"] = 1;
                                vmodele.DT[5].Rows.Add(NouvLigne);
                                vmodele.DA[5].Update(vmodele.DT[5]);
                            }
                            else
                            {
                                MessageBox.Show("Erreur : il faut remplir tout les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                goto eti;
                            }
                        }

                        if (c == 'u')  // modif
                        {
                            if (formCRUD.RtbLibelleLieux.Text != "" && formCRUD.NudCapaciteLieu.Text != "")
                            {
                                vmodele.DT[5].Rows[indice]["LIBELLELIEU"] = formCRUD.RtbLibelleLieux.Text;
                                vmodele.DT[5].Rows[indice]["CAPACITELIEU"] = formCRUD.NudCapaciteLieu.Value;
                                if (formCRUD.RbExtLieux.Checked) vmodele.DT[5].Rows[indice]["INTERIEURLIEU"] = 0;
                                else vmodele.DT[5].Rows[indice]["INTERIEURLIEU"] = 1;
                                vmodele.DA[5].Update(vmodele.DT[5]);
                            }
                            else
                            {
                                MessageBox.Show("Erreur : il faut remplir tout les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                goto eti;
                            }
                        }
                    }
                }
            }

            #endregion

            #region crud_public

            public static void crud_public(Char c, int indice)
            {
                Controleur.Vmodele.charger_donnees("public", -1, "", "");
                if (c == 'd') // cas de la suppression
                {
                    //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer le public " + vmodele.DT[7].Rows[indice][1].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rep == DialogResult.Yes)
                    {
                        vmodele.DT[7].Rows[indice].Delete();		// suppression dans le DataTable
                        vmodele.DA[7].Update(vmodele.DT[7]);        // on supprime l’élément du DataTable
                    }
                }
                else
                {
                    // cas de l'ajout et modification
                    FormCRUDPublic formCRUD = new FormCRUDPublic();  // création de la nouvelle forme
                    if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                    {
                        formCRUD.TbLibellePublic.Text = "";
                        formCRUD.RtbDescrPublic.Text = "";
                    }

                    if (c == 'u')   // mode update donc on récupère les champs
                    {
                        formCRUD.TbLibellePublic.Text = vmodele.DT[7].Rows[indice][1].ToString();
                        formCRUD.RtbDescrPublic.Text = vmodele.DT[7].Rows[indice][2].ToString();
                    }
                eti:
                    // on affiche la nouvelle form
                    formCRUD.ShowDialog();

                    // si l’utilisateur clique sur OK
                    if (formCRUD.DialogResult == DialogResult.OK)
                    {
                        if (c == 'c') // ajout
                        {
                            // on crée une nouvelle ligne dans le dataView
                            if (formCRUD.TbLibellePublic.Text != "" && formCRUD.RtbDescrPublic.Text != "")
                            {
                                DataRow NouvLigne = vmodele.DT[7].NewRow();
                                NouvLigne["IDPUBLIC"] = Convert.ToInt32(vmodele.DT[7].Rows[vmodele.DT[7].Rows.Count - 1][0]);
                                NouvLigne["LIBELLEPUBLIC"] = formCRUD.TbLibellePublic.Text;
                                NouvLigne["DESCRIPTIONPUBLIC"] = formCRUD.RtbDescrPublic.Text;
                                vmodele.DT[7].Rows.Add(NouvLigne);
                                vmodele.DA[7].Update(vmodele.DT[7]);
                            }
                            else
                            {
                                MessageBox.Show("Erreur : il faut remplir tout les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                goto eti;
                            }
                        }

                        if (c == 'u')  // modif
                        {
                            if (formCRUD.TbLibellePublic.Text != "" && formCRUD.RtbDescrPublic.Text != "")
                            {
                                vmodele.DT[7].Rows[indice]["LIBELLEPUBLIC"] = formCRUD.TbLibellePublic.Text;
                                vmodele.DT[7].Rows[indice]["DESCRIPTIONPUBLIC"] = formCRUD.RtbDescrPublic.Text;
                                vmodele.DA[7].Update(vmodele.DT[7]);
                            }
                            else
                            {
                                MessageBox.Show("Erreur : il faut remplir tout les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                goto eti;
                            }
                        }
                    }
                }
            }

            #endregion

            #region crud_reservation

            public static void crud_reservation(Char c, int indice)
            {
                Controleur.Vmodele.charger_donnees("reservation", -1, "", "");
                if (c == 'd') // cas de la suppression
                {
                    //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer la réservation ref : #" + vmodele.DT[4].Rows[indice][0].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rep == DialogResult.Yes)
                    {
                        vmodele.DT[4].Rows[indice].Delete();		// suppression dans le DataTable
                        vmodele.DA[4].Update(vmodele.DT[4]);        // on supprime l’élément du DataTable
                    }
                }
                else
                {
                    Controleur.Vmodele.charger_donnees("manifestation", -1, "", "");
                    Controleur.Vmodele.charger_donnees("users", -1, "", "");
                    // cas de l'ajout et modification
                    FormCRUDReservation formCRUD = new FormCRUDReservation();  // création de la nouvelle forme
                    if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                    {
                        for (int i = 0; i < vmodele.DT[3].Rows.Count; i++)
                        {
                            formCRUD.CbManifReservation.Items.Add(vmodele.DT[3].Rows[i][3].ToString());
                        }
                        for (int i = 0; i < vmodele.DT[15].Rows.Count; i++)
                        {
                            formCRUD.CbAdhReservation.Items.Add(vmodele.DT[15].Rows[i][1].ToString());
                        }
                        formCRUD.CbManifReservation.SelectedIndex = -1;
                        formCRUD.CbAdhReservation.SelectedIndex = -1;
                        formCRUD.NudPersReservation.Value = 0;
                    }

                    if (c == 'u')   // mode update donc on récupère les champs
                    {
                        Controleur.Vmodele.charger_donnees("nomsManifsFromReserv", -1, "", "");
                        Controleur.Vmodele.charger_donnees("nomsAdhFromReserv", -1, "", "");
                        //formCRUD.ComboBoxLieuManif.SelectedItem = vmodele.DT[20].Rows[indice][2].ToString();
                        for (int i = 0; i < vmodele.DT[3].Rows.Count; i++)
                        {
                            formCRUD.CbManifReservation.Items.Add(vmodele.DT[3].Rows[i][3].ToString());
                        }
                        for (int i = 0; i < vmodele.DT[15].Rows.Count; i++)
                        {
                            formCRUD.CbAdhReservation.Items.Add(vmodele.DT[15].Rows[i][1].ToString());
                        }
                        formCRUD.CbManifReservation.SelectedItem = vmodele.DT[21].Rows[indice][1].ToString();
                        formCRUD.CbAdhReservation.SelectedItem = vmodele.DT[22].Rows[indice][1].ToString();
                        formCRUD.NudPersReservation.Value = Convert.ToInt32(vmodele.DT[4].Rows[indice][3]);
                    }
                eti:
                    // on affiche la nouvelle form
                    formCRUD.ShowDialog();

                    // si l’utilisateur clique sur OK
                    if (formCRUD.DialogResult == DialogResult.OK)
                    {
                        if (c == 'c') // ajout
                        {
                            // on crée une nouvelle ligne dans le dataView
                            if (formCRUD.CbManifReservation.SelectedIndex != -1 && formCRUD.CbAdhReservation.SelectedIndex != -1 && formCRUD.NudPersReservation.Value > 0)
                            {
                                DataRow NouvLigne = vmodele.DT[4].NewRow();
                                NouvLigne["REFRESERVATION"] = Convert.ToInt32(vmodele.DT[4].Rows[vmodele.DT[4].Rows.Count - 1][0]) + 1;
                                string libelleManif = formCRUD.CbManifReservation.SelectedItem.ToString();
                                Controleur.Vmodele.charger_donnees("nomManifToIdManif", -1, libelleManif, "");
                                NouvLigne["IDMANIF"] = Convert.ToInt32(vmodele.DT[23].Rows[0][0].ToString());
                                string libellePersonne = formCRUD.CbAdhReservation.SelectedItem.ToString();
                                Controleur.Vmodele.charger_donnees("emailPersToIdPers", -1, libellePersonne, "");
                                NouvLigne["IDPERSONNE"] = Convert.ToInt32(vmodele.DT[24].Rows[0][0].ToString());
                                NouvLigne["QUANTITERESERVATION"] = formCRUD.NudPersReservation.Value;
                                vmodele.DT[4].Rows.Add(NouvLigne);
                                vmodele.DA[4].Update(vmodele.DT[4]);
                            }
                            else
                            {
                                MessageBox.Show("Erreur : il faut remplir tout les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                goto eti;
                            }
                        }

                        if (c == 'u')  // modif
                        {
                            if (formCRUD.CbManifReservation.SelectedIndex != -1 && formCRUD.CbAdhReservation.SelectedIndex != -1 && formCRUD.NudPersReservation.Value > 0)
                            {
                                string libelleManif = formCRUD.CbManifReservation.SelectedItem.ToString();
                                Controleur.Vmodele.charger_donnees("nomManifToIdManif", -1, libelleManif, "");
                                vmodele.DT[4].Rows[indice]["IDMANIF"] = Convert.ToInt32(vmodele.DT[23].Rows[0][0].ToString());
                                string libellePersonne = formCRUD.CbAdhReservation.SelectedItem.ToString();
                                Controleur.Vmodele.charger_donnees("nomPersToIdPers", -1, libellePersonne, "");
                                vmodele.DT[4].Rows[indice]["IDPERSONNE"] = Convert.ToInt32(vmodele.DT[24].Rows[0][0].ToString());
                                vmodele.DT[4].Rows[indice]["QUANTITERESERVATION"] = formCRUD.NudPersReservation.Value;
                                vmodele.DA[4].Update(vmodele.DT[4]);
                            }
                            else
                            {
                                MessageBox.Show("Erreur : il faut remplir tout les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                goto eti;
                            }
                        }

                    }
                }
            }

            #endregion

            #region crud_avis

            public static void crud_avis(Char c, int indice)
            {
                Controleur.Vmodele.charger_donnees("avis", -1, "", "");
                if (c == 'd') // cas de la suppression
                {
                    //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer l'avis " + vmodele.DT[6].Rows[indice][0].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rep == DialogResult.Yes)
                    {
                        vmodele.DT[6].Rows[indice].Delete();		// suppression dans le DataTable
                        vmodele.DA[6].Update(vmodele.DT[6]);        // on supprime l’élément du DataTable
                    }
                }
                else
                {
                    // cas de l'ajout et modification
                    FormUpdateAvis formCRUD = new FormUpdateAvis();  // création de la nouvelle forme
                    if (c == 'u')   // mode update donc on récupère les champs
                    {
                        if (Convert.ToInt32(vmodele.DT[6].Rows[indice][5]) == 0) formCRUD.RbRefuser.Checked = true;
                        else formCRUD.RbAccepter.Checked = true;
                    }
                eti:
                    // on affiche la nouvelle form
                    formCRUD.ShowDialog();
                    // si l’utilisateur clique sur OK
                    if (formCRUD.DialogResult == DialogResult.OK)
                    {
                        if (c == 'u')  // modif
                        {
                            if(formCRUD.RbAccepter.Checked == true) vmodele.DT[6].Rows[indice]["VALIDEAVIS"] = 1;
                            else vmodele.DT[6].Rows[indice]["VALIDEAVIS"] = 0;
                            vmodele.DA[6].Update(vmodele.DT[6]);
                        }
                    }
                }
            }

            #endregion

            #region crud_participation

            public static void crud_participation(Char c, int indice)
            {
                Controleur.Vmodele.charger_donnees("participer", -1, "", "");
                if (c == 'd') // cas de la suppression
                {
                    //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer la participation n° " + vmodele.DT[34].Rows[indice][0].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rep == DialogResult.Yes)
                    {
                        vmodele.DT[34].Rows[indice].Delete();		// suppression dans le DataTable
                        vmodele.DA[34].Update(vmodele.DT[34]);        // on supprime l’élément du DataTable
                    }
                }
                else
                {
                    // cas de l'ajout et modification
                    FormCRUDParticiper formCRUD = new FormCRUDParticiper();  // création de la nouvelle forme
                    if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                    {
                        formCRUD.CbManif.SelectedIndex = -1;
                        formCRUD.CbPersonne.SelectedIndex = -1;
                    }
                    if (c == 'u')   // mode update donc on récupère les champs
                    {
                        MessageBox.Show("La modification n'est pas possible", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                eti:
                    if (c != 'u')   // mode update donc on récupère les champs
                    {
                        // on affiche la nouvelle form
                        formCRUD.ShowDialog();
                        // si l’utilisateur clique sur OK
                        if (formCRUD.DialogResult == DialogResult.OK)
                        {
                            if (c == 'c') // ajout
                            {
                                // on crée une nouvelle ligne dans le dataView
                                if (formCRUD.CbManif.SelectedIndex != -1 && formCRUD.CbPersonne.SelectedIndex != -1)
                                {
                                    DataRow NouvLigne = vmodele.DT[34].NewRow();
                                    string libelleManif = formCRUD.CbManif.SelectedItem.ToString();
                                    Controleur.Vmodele.charger_donnees("nomManifToIdManif", -1, libelleManif, "");
                                    NouvLigne["IDMANIF"] = Convert.ToInt32(vmodele.DT[23].Rows[0][0].ToString());

                                    string nomPrenom = formCRUD.CbPersonne.SelectedItem.ToString();
                                    string[] nomPrenomSplit = nomPrenom.Split(' ');
                                    string nom = nomPrenomSplit[0];
                                    Controleur.Vmodele.charger_donnees("nomsPersToIdPers", -1, nom, "");
                                    NouvLigne["IDPERSONNE"] = Convert.ToInt32(vmodele.DT[36].Rows[0][0].ToString());
                                    string libellePersonne = formCRUD.CbPersonne.SelectedItem.ToString();
                                    vmodele.DT[34].Rows.Add(NouvLigne);
                                    vmodele.DA[34].Update(vmodele.DT[34]);
                                }
                                else
                                {
                                    MessageBox.Show("Erreur : il faut remplir tout les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    goto eti;
                                }
                            }
                        }
                    }
                }
            }
        #endregion

        #endregion
    }
}