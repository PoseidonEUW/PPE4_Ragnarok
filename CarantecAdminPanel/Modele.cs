using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace CarantecAdminPanel
{
    class Modele
    {
        #region Propriétés
        private MySqlConnection myConnection; // objet de connexion
        private bool connopen = false; // test si la connexion est faite
        private bool chargement = false; // test si le chargement d'une requête est fait
        private DataTable dT1 = new DataTable();
        #endregion
        #region Accesseurs
        public bool GetConnopen()
        {
            return connopen;
        }
        public bool GetChargement()
        {
            return chargement;
        }
        public DataTable GetDT1()
        {
            return dT1;
        }
        public void SetDT1(DataTable value)
        {
            dT1 = value;
        }
        #endregion
        #region Méthodes
        public void seconnecter()
        {
            // paramètres de connexion à modifier selon sa BD et son serveur de BD
            string myConnectionString = "Database=PPE4_Ragnarok; Data Source=192.168.164.1; UserId=Elliot_Guittet; Password=Php#1MyAdmin;";
            myConnection = new MySqlConnection(myConnectionString);
            try // tentative
            {
                myConnection.Open();
                connopen = true;
            }
            catch (Exception err)// gestion des erreurs
            {
                MessageBox.Show("Erreur ouverture bdd : " + err, "PBS connection",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                connopen = false;
            }
        }
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
                MessageBox.Show("Erreur fermeture bdd : " + err, "PBS deconnection",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void charger(string requete, DataTable DT)
        {
            MySqlCommand command = myConnection.CreateCommand();
            MySqlDataReader reader;
            try
            {
                command.CommandText = requete;
                reader = command.ExecuteReader();
                DT.Load(reader);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "PBS table",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                chargement = false;
            }
        }
        public void charger_donnees(string table)
        {
            if (table == "ADMIN") charger("select * from ADMIN;", dT1);
        }
        #endregion
    }
}
