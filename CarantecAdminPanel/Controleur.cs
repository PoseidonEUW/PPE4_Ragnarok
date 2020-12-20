using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarantecAdminPanel
{
    class Controleur
    {
        #region Propriétés
        private static Modele modele;
        #endregion
        #region Accesseurs
        public static Modele GetModele()
        {
            return modele;
        }
        public static void SetVModele(Modele value)
        {
            modele = value;
        }
        #endregion
        #region Méthodes
        public static void init()
        {
            modele = new Modele();
        }
        #endregion
    }
}
