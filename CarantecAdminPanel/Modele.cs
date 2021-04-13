﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarantecAdminPanel
{
    class Modele
    {
        #region propriétés

        private MySqlConnection myConnection;   // objet de connexion
        private bool connopen = false;          // test si la connexion est faite
        private bool errgrave = false;          // test si erreur lors de la connexion
        private bool chargement = false;        // test si le chargement d'une requête est fait

        // les DataAdapter et DataTable seront gérés dans des collections avec pour chaque un indice correspondant :
        // indice 0 : récupération des noms des tables
        // indice 1 : Table borne
        // indice 2 : Table adherent
        // indice 3 : Table ... à vous de créer la suite

        // collection de DataAdapter
        private List<MySqlDataAdapter> dA = new List<MySqlDataAdapter>();

        // collection de DataTable récupérant les données correspond au DA associé
        private List<DataTable> dT = new List<DataTable>();

        #endregion

        #region accesseurs
        /// <summary>
        /// test si la connexion à la BD est ouverte
        /// </summary>
        public bool Connopen
        {
            get { return connopen; }
            set { connopen = value; }
        }

        /// <summary>
        /// test si erreur lors de la connexion
        /// </summary>
        public bool Errgrave
        {
            get { return errgrave; }
            set { errgrave = value; }
        }

        /// <summary>
        /// test si le chargement d'une requête est fait
        /// </summary>
        public bool Chargement
        {
            get { return chargement; }
            set { chargement = value; }
        }

        /// <summary>
        /// Accesseur de la collection des DataAdapter
        /// </summary>
        public List<MySqlDataAdapter> DA
        {
            get { return dA; }
            set { dA = value; }
        }

        /// <summary>
        /// Accesseur de la collection des DataTable
        /// </summary>
        public List<DataTable> DT
        {
            get { return dT; }
            set { dT = value; }
        }

        public MySqlConnection MyConnection { get => myConnection; set => myConnection = value; }
        #endregion

        /// <summary>
        /// Modele() : constructeur permettant l'ajout des DataAdpater et DataTable nécessaires (4 nécessaires pour l'existant actuel)
        /// indice 0 : récupération des noms des tables
        /// indice 1 : Table borne
        /// indice 2 : Table adherent
        /// indice 3 : Table ...
        /// </summary>
        public Modele()
        {
            // instanciation des collections des Datatable et DataAdapter
            for (int i = 0; i <= 30; i++)
            {
                dA.Add(new MySqlDataAdapter());
                dT.Add(new DataTable());
            }
        }

        /// <summary>
        /// méthode seconnecter permettant la connexion à la BD : bd_ppe3_notagame
        /// </summary>
        public void seconnecter()
        {
            //string myConnectionString = "Database=PPE4_Ragnarok;Data Source=192.168.164.1;User Id=Titouan_Annaix;Password=JeSappelleTitouan;";
            string myConnectionString = "Database=PPE4_Ragnarok;Data Source=localhost;User Id=root;Password=;";
            //string myConnectionString = "Database=PPE3_VELIBERTE;Data Source=192.168.153.1;User Id=YoBrnq;Password=azerty;";
            //string myConnectionString = "Database=2021_slamBDD4;Data Source=192.168.10.70;User Id=2021_slamBDD4;Password=P@ssw0rd;";
            myConnection = new MySqlConnection(myConnectionString);
            try // tentative 
            {
                myConnection.Open();
                connopen = true;
            }
            catch (Exception err)// gestion des erreurs
            {
                MessageBox.Show("Erreur ouverture BD Carantec : " + err, "PBS connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connopen = false; errgrave = true;
            }
        }

        /// <summary>
        /// méthode sedeconnecter pour se déconnecter à la BD
        /// </summary>
        public void sedeconnecter()
        {
            if (!connopen)
                return;
            try
            {
                myConnection.Close();
                myConnection.Dispose();
                connopen = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur fermeture BD Carantec : " + err, "PBS deconnection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }

        /// <summary>
        /// méthode générique privée pour charger le résultat d'une requête dans un dataTable via un dataAdapter
        /// Méthode appelée par charger_donnees(string table)
        /// </summary>
        /// <param name="requete">requete à charger</param>
        /// <param name="DT">dataTable</param>
        /// <param name="DA">dataAdapter</param>
        private void charger(string requete, DataTable DT, MySqlDataAdapter DA)
        {
            DA.SelectCommand = new MySqlCommand(requete, myConnection);

            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(DA);
            try
            {
                DT.Clear();
                DA.Fill(DT);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable : " + err, "PBS table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }

        /// <summary>
        /// charge dans un DT les données de la table passée en paramètre
        /// </summary>
        /// <param name="table">nom de la table à requêter</param>
        public void charger_donnees(string table, int indice, string text)
        {
            chargement = false;
            if (!connopen) return;		// pour vérifier que la BD est bien ouverte

            if (table == "ADMIN")
            {
                charger("select * from ADMIN;", dT[0], dA[0]);
            }
            if (table == "utilisateur")
            {
                charger("select * from PERSONNE;", dT[1], dA[1]);
            }
            if (table == "festival")
            {
                charger("select * from FESTIVAL;", dT[2], dA[2]);
            }
            if (table == "manifestation")
            {
                charger("select * from MANIFESTATION;", dT[3], dA[3]);
            }
            if (table == "reservation")
            {
                charger("select * from RESERVATION;", dT[4], dA[4]);
            }
            if (table == "lieu")
            {
                charger("select * from LIEU;", dT[5], dA[5]);
            }
            if (table == "avis")
            {
                charger("select * from AVIS;", dT[6], dA[6]);
            }
            if (table == "public")
            {
                charger("select * from PUBLIC;", dT[7], dA[7]);
            }
            if (table == "toutes")
            {
                charger("show tables;", dT[8], dA[8]);
            }
            if (table == "festivalDisplay")
            {
                charger("select * from infosFestival;", dT[9], dA[9]);
            }
            if (table == "thematique")
            {
                charger("select * from THEMATIQUE;", dT[10], dA[10]);
            }
            if (table == "respToPers")
            {
                charger("select * from respToPers;", dT[11], dA[11]);
            }
            if (table == "responsable")
            {
                charger("select * from RESPONSABLE;", dT[12], dA[12]);
            }
            if (table == "persToResp")
            {
                charger("CALL persToResp('" + text + "')", dT[13], dA[13]);
            }
            if (table == "nomThemeToIdTheme")
            {
                charger("CALL nomThemeToIdTheme('" + text + "')", dT[14], dA[14]);
            }
            if (table == "adherent")
            {
                charger("select * from ADHERENT;", dT[15], dA[15]);
            }
            if (table == "artiste")
            {
                charger("select * from ARTISTES;", dT[16], dA[16]);
            }
            if (table == "animateur")
            {
                charger("select * from ANIMATEUR;", dT[17], dA[17]);
            }
            if (table == "intSpe")
            {
                charger("select * from INTERVENANTSPECIALISE;", dT[18], dA[18]);
            }
            if (table == "nomLieuToIdLieu")
            {
                charger("CALL nomLieuToIdLieu('" + text + "')", dT[19], dA[19]);
            }
            if (table == "nomsLieuxFromManifs")
            {
                charger("select * from nomsLieuxFromManifs;", dT[20], dA[20]);
            }
            if (table == "nomsManifsFromReserv")
            {
                charger("select * from nomsManifsFromReserv;", dT[21], dA[21]);
            }
            if (table == "nomsAdhFromReserv")
            {
                charger("select * from nomsUserFromReserv;", dT[22], dA[22]);
            }
            if (table == "nomManifToIdManif")
            {
                charger("CALL nomManifToIdManif('" + text + "')", dT[23], dA[23]);
            }
            if (table == "nomPersToIdPers")
            {
                charger("CALL nomPersToIdPers('" + text + "')", dT[24], dA[24]);
            }
            if (table == "adherentPersonne")
            {
                charger("select * from usersPersonne;", dT[25], dA[25]);
            }
            if (table == "artistePersonne")
            {
                charger("select * from artistePersonne;", dT[26], dA[26]);
            }
            if (table == "animateurPersonne")
            {
                charger("select * from animateurPersonne;", dT[27], dA[27]);
            }
            if (table == "intervenantSpecialisePersonne")
            {
                charger("select * from intervenantSpecialisePersonne;", dT[28], dA[28]);
            }
            //if (table == "PPE_REPARERUT")
            //{
            //    charger("select IdR, numV, T.LibelleT, dateR, tempsR, U.loginU from (PPE_REPARER P INNER JOIN PPE_TRAVAUX T ON P.IdT = T.IdT) INNER JOIN PPE_UTILISATEURS U ON P.IdU = U.numU;", dT[9], dA[9]);
            //}
            //if (table == "PPE_AREPARER")
            //{
            //    charger("select V.numV, etatV from vehicule V WHERE etatV='R' and numV not in (SELECT numV FROM PPE_REPARER); ", dT[10], dA[10]);
            //}
            //if (table == "SUMTEMPSR")
            //{
            //    charger("SELECT SEC_TO_TIME( SUM( TIME_TO_SEC( `tempsR` ) ) ) from PPE_REPARER WHERE `numV`= " + numV + ";", dT[11], dA[11]);
            //}
        }
    }
}
