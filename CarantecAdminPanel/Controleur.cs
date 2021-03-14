using System;
using System.Collections.Generic;
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
                FormCRUDBorne formCRUD = new FormCRUDBorne();  // création de la nouvelle forme
                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    formCRUD.TbNomBorne.Clear();
                    formCRUD.TbNomAdresseRue.Clear();
                    formCRUD.TbnumAdresseRue.Clear();
                    formCRUD.TbLat.Clear();
                    formCRUD.TbLong.Clear();
                }

                if (c == 'u')   // mode update donc on récupère les champs
                {
                    // on remplit les zones par les valeurs du dataGridView correspondantes
                    formCRUD.TbNomBorne.Text = vmodele.DT[1].Rows[indice][1].ToString();
                    formCRUD.TbnumAdresseRue.Text = vmodele.DT[1].Rows[indice][2].ToString();
                    formCRUD.TbNomAdresseRue.Text = vmodele.DT[1].Rows[indice][3].ToString();
                    formCRUD.TbLat.Text = vmodele.DT[1].Rows[indice][4].ToString();
                    formCRUD.TbLong.Text = vmodele.DT[1].Rows[indice][5].ToString();
                }
            eti:
                // on affiche la nouvelle form
                formCRUD.ShowDialog();

                // si l’utilisateur clique sur OK
                if (formCRUD.DialogResult == DialogResult.OK)
                {
                    if (c == 'c') // ajout
                    {
                        bool valid = true;
                        // on crée une nouvelle ligne dans le dataView
                        if (formCRUD.TbNomBorne.Text != "" && formCRUD.TbNomAdresseRue.Text != "")
                        {
                            DataRow NouvLigne = vmodele.DT[1].NewRow();
                            NouvLigne["nomB"] = formCRUD.TbNomBorne.Text;
                            if (formCRUD.TbnumAdresseRue.Text != "") NouvLigne["numRueB"] = formCRUD.TbnumAdresseRue.Text;
                            NouvLigne["nomRueB"] = formCRUD.TbNomAdresseRue.Text;
                            if (Convert.ToInt32(formCRUD.TbLat.Text) <= 90 && Convert.ToInt32(formCRUD.TbLong.Text) <= 180 && Convert.ToInt32(formCRUD.TbLat.Text) >= -90 && Convert.ToInt32(formCRUD.TbLong.Text) >= -180)
                            {
                                if (formCRUD.TbLat.Text != "") NouvLigne["latitudeB"] = formCRUD.TbLat.Text;
                                else NouvLigne["latitudeB"] = "0";
                                if (formCRUD.TbLong.Text != "") NouvLigne["longitudeB"] = formCRUD.TbLong.Text;
                                else NouvLigne["longitudeB"] = "0";
                                valid = true;
                            }
                            else valid = false;
                            if (valid == true)
                            {
                                vmodele.DT[1].Rows.Add(NouvLigne);
                                vmodele.DA[1].Update(vmodele.DT[1]);
                            }
                            else
                            {
                                MessageBox.Show("Erreur dans la saisie", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                // ne pas fermer la form : revenir avant le bouton OK
                                goto eti;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erreur : il faut saisir au moins la nom et la rue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto eti;
                        }
                    }

                    if (c == 'u')  // modif
                    {
                        if (formCRUD.TbNomBorne.Text != "" && formCRUD.TbNomAdresseRue.Text != "")
                        {
                            bool valid = true;
                            // on met à jour le dataTable avec les nouvelles valeurs
                            vmodele.DT[1].Rows[indice]["nomB"] = formCRUD.TbNomBorne.Text;
                            if (formCRUD.TbnumAdresseRue.Text != "") vmodele.DT[1].Rows[indice]["numRueB"] = formCRUD.TbnumAdresseRue.Text;
                            vmodele.DT[1].Rows[indice]["nomRueB"] = formCRUD.TbNomAdresseRue.Text;
                            if (Convert.ToInt32(formCRUD.TbLat.Text) <= 90 && Convert.ToInt32(formCRUD.TbLong.Text) <= 180 && Convert.ToInt32(formCRUD.TbLat.Text) >= -90 && Convert.ToInt32(formCRUD.TbLong.Text) >= -180)
                            {
                                if (formCRUD.TbLat.Text != "") vmodele.DT[1].Rows[indice]["latitudeB"] = formCRUD.TbLat.Text;
                                else vmodele.DT[1].Rows[indice]["latitudeB"] = "0";
                                if (formCRUD.TbLong.Text != "") vmodele.DT[1].Rows[indice]["longitudeB"] = formCRUD.TbLong.Text;
                                else vmodele.DT[1].Rows[indice]["longitudeB"] = "0";
                                valid = true;
                            }
                            else valid = false;
                            if (valid == true)
                            {
                                vmodele.DA[1].Update(vmodele.DT[1]);
                            }
                            else
                            {
                                MessageBox.Show("Erreur dans la saisie", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                // ne pas fermer la form : revenir avant le bouton OK
                                goto eti;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erreur : il faut saisir au moins la nom et la rue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto eti;
                        };

                    }

                    MessageBox.Show("OK : données enregistrées Borne");
                    formCRUD.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée Borne");
                    formCRUD.Dispose();
                }
            }
        }
        #endregion

        #endregion
    }
}