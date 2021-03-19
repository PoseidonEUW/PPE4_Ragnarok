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
            if (c == 'd') // cas de la suppression
            {
                //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce festival " + vmodele.DT[1].Rows[indice][1].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    vmodele.DT[1].Rows[indice].Delete();		// suppression dans le DataTable
                    vmodele.DA[1].Update(vmodele.DT[1]);        // on supprime l’élément du DataTable
                }
            }
            else
            {
                // cas de l'ajout et modification
                FormCRUDFestival formCRUD = new FormCRUDFestival();  // création de la nouvelle forme
                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    formCRUD.DateTimeAnnee.Value = DateTime.Now;
                    formCRUD.CbThematique.SelectedIndex = -1;
                    Controleur.Vmodele.charger_donnees("respToPers", -1);
                    Controleur.Vmodele.charger_donnees("thematique", -1);
                    for (int i = 0; i < vmodele.DT[10].Rows.Count; i++)
                    {
                        formCRUD.CbThematique.Items.Add(vmodele.DT[10].Rows[i][1].ToString());
                    }
                    formCRUD.CbResponsable.SelectedIndex = -1;
                    for (int i = 0; i < vmodele.DT[11].Rows.Count; i++)
                    {
                        formCRUD.CbResponsable.Items.Add(vmodele.DT[11].Rows[i][0].ToString());
                    }
                    formCRUD.LabelActionTitle.Text = "AJOUT";
                }

                if (c == 'u')   // mode update donc on récupère les champs
                {
                    // on remplit les zones par les valeurs du dataGridView correspondantes
                    //formCRUD.TbNom.Text = vmodele.DT[1].Rows[indice][1].ToString();
                    //formCRUD.TbPrenom.Text = vmodele.DT[1].Rows[indice][2].ToString();
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
                        //// on crée une nouvelle ligne dans le dataView
                        //if (formCRUD.TbNom.Text != "" && formCRUD.TbPrenom.Text != "")
                        //{
                        //    DataRow NouvLigne = vmodele.DT[1].NewRow();
                        //    NouvLigne["NOMPERSONNE"] = formCRUD.TbNom.Text;
                        //    NouvLigne["PRENOMPERSONNE"] = formCRUD.TbPrenom.Text;
                        //    vmodele.DT[1].Rows.Add(NouvLigne);
                        //    vmodele.DA[1].Update(vmodele.DT[1]);
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Erreur : il faut saisir au moins la nom et le prenom", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    goto eti;
                        //}
                    }

                    if (c == 'u')  // modif
                    {
                        //if (formCRUD.TbNom.Text != "" && formCRUD.TbPrenom.Text != "")
                        //{
                        //    // on met à jour le dataTable avec les nouvelles valeurs
                        //    vmodele.DT[1].Rows[indice]["NOMPERSONNE"] = formCRUD.TbNom.Text;
                        //    vmodele.DT[1].Rows[indice]["PRENOMPERSONNE"] = formCRUD.TbPrenom.Text;
                        //    vmodele.DA[1].Update(vmodele.DT[1]);
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Erreur : il faut saisir au moins la nom et le prenom", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    goto eti;
                        //};

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
                FormCRUDUtilisateur formCRUD = new FormCRUDUtilisateur();  // création de la nouvelle forme
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