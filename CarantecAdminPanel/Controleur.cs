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
        private static Modele vmodele;
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

        #region crudFestival
        public static void crud_festival(Char c, int indice)
        {
            Controleur.Vmodele.charger_donnees("festival", -1, "");
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
                    Controleur.Vmodele.charger_donnees("respToPers", -1, "");
                    Controleur.Vmodele.charger_donnees("thematique", -1, "");
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
                    formCRUD.LabelActionTitle.Text = "AJOUT";
                }

                if (c == 'u')   // mode update donc on récupère les champs
                {
                    formCRUD.DateTimeAnnee.Value = DateTime.Now;
                    Controleur.Vmodele.charger_donnees("respToPers", -1, "");
                    Controleur.Vmodele.charger_donnees("thematique", -1, "");
                    Controleur.Vmodele.charger_donnees("responsable", -1, "");
                    for (int i = 0; i < vmodele.DT[10].Rows.Count; i++)
                    {
                        formCRUD.CbThematique.Items.Add(vmodele.DT[10].Rows[i][1].ToString());
                    }
                    formCRUD.CbThematique.SelectedItem = vmodele.DT[9].Rows[(indice)][2].ToString();
                    for (int i = 0; i < vmodele.DT[11].Rows.Count; i++)
                    {
                        formCRUD.CbResponsable.Items.Add(vmodele.DT[11].Rows[i][0].ToString());
                    }
                    formCRUD.CbResponsable.SelectedIndex = Convert.ToInt32(vmodele.DT[12].Rows[indice][0]);
                    formCRUD.TbNomFestival.Text = vmodele.DT[9].Rows[(indice)][1].ToString();
                    formCRUD.LabelActionTitle.Text = "MODIFICATION";
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
                            Controleur.Vmodele.charger_donnees("nomThemeToIdTheme", -1, libelleTheme);
                            NouvLigne["IDTHEMATIQUE"] = Convert.ToInt32(vmodele.DT[14].Rows[0][0].ToString());
                            string nomPrenom = formCRUD.CbResponsable.SelectedItem.ToString();
                            string[] nomPrenomSplit = nomPrenom.Split(' ');
                            string nom = nomPrenomSplit[0];
                            Controleur.Vmodele.charger_donnees("persToResp", -1, nom);
                            NouvLigne["IDPERSONNE"] = Convert.ToInt32(vmodele.DT[13].Rows[0][0].ToString());
                            NouvLigne["NOMFESTIVAL"] = formCRUD.TbNomFestival.Text;
                            vmodele.DT[2].Rows.Add(NouvLigne);
                            vmodele.DA[2].Update(vmodele.DT[2]);
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
                            Controleur.Vmodele.charger_donnees("nomThemeToIdTheme", -1, libelleTheme);
                            vmodele.DT[2].Rows[indice]["IDTHEMATIQUE"] = Convert.ToInt32(vmodele.DT[14].Rows[0][0].ToString());
                            string nomPrenom = formCRUD.CbResponsable.SelectedItem.ToString();
                            string[] nomPrenomSplit = nomPrenom.Split(' ');
                            string nom = nomPrenomSplit[0];
                            Controleur.Vmodele.charger_donnees("persToResp", -1, nom);
                            vmodele.DT[2].Rows[indice]["IDPERSONNE"] = Convert.ToInt32(vmodele.DT[13].Rows[0][0].ToString());
                            vmodele.DT[2].Rows[indice]["NOMFESTIVAL"] = formCRUD.TbNomFestival.Text;
                            vmodele.DA[2].Update(vmodele.DT[2]);
                        }
                        else
                        {
                            MessageBox.Show("Erreur : il faut remplir tout les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto eti;
                        }
                    }

                    MessageBox.Show("OK : données enregistrées Utilisateur");
                    formCRUD.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée Utilisateur");
                    formCRUD.Dispose();
                }
            }
        }
        #endregion

        #region crudUtilisateur
        public static void crud_utilisateur(Char c, int indice)
        {
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
                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    formCRUD.TbNom.Clear();
                    formCRUD.TbPrenom.Clear();
                    formCRUD.LabelActionTitle.Text = "AJOUT";
                }

                if (c == 'u')   // mode update donc on récupère les champs
                {
                    // on remplit les zones par les valeurs du dataGridView correspondantes
                    formCRUD.TbNom.Text = vmodele.DT[1].Rows[indice][1].ToString();
                    formCRUD.TbPrenom.Text = vmodele.DT[1].Rows[indice][2].ToString();
                    formCRUD.LabelActionTitle.Text = "MODIFICATION";
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
                        if (formCRUD.TbNom.Text != "" && formCRUD.TbPrenom.Text != "")
                        {
                            DataRow NouvLigne = vmodele.DT[1].NewRow();
                            NouvLigne["NOMPERSONNE"] = formCRUD.TbNom.Text;
                            NouvLigne["PRENOMPERSONNE"] = formCRUD.TbPrenom.Text;
                            vmodele.DT[1].Rows.Add(NouvLigne);
                            vmodele.DA[1].Update(vmodele.DT[1]);
                        }
                        else
                        {
                            MessageBox.Show("Erreur : il faut saisir au moins la nom et le prenom", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto eti;
                        }
                    }

                    if (c == 'u')  // modif
                    {
                        if (formCRUD.TbNom.Text != "" && formCRUD.TbPrenom.Text != "")
                        {
                            // on met à jour le dataTable avec les nouvelles valeurs
                            vmodele.DT[1].Rows[indice]["NOMPERSONNE"] = formCRUD.TbNom.Text;
                            vmodele.DT[1].Rows[indice]["PRENOMPERSONNE"] = formCRUD.TbPrenom.Text;
                            vmodele.DA[1].Update(vmodele.DT[1]);
                        }
                        else
                        {
                            MessageBox.Show("Erreur : il faut saisir au moins la nom et le prenom", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto eti;
                        };

                    }

                    MessageBox.Show("OK : données enregistrées Utilisateur");
                    formCRUD.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée Utilisateur");
                    formCRUD.Dispose();
                }
            }
        }
        #endregion

        #endregion
    }
}