using System;
using System.Collections.Generic;
using System.Configuration;
using GestionTheatreBO;
using GestionTheatreDAL;

namespace GestionTheatreBLL
{
    public class GestionUtilisateurs : Singleton<GestionUtilisateurs>
    {
        public void SetConnectionSettings(string sCo)
        {
            ConnexionBD.Instance.SConnection = sCo;
        }

        /* public List<Utilisateur> GetUtilisateurs()
        {
            return UtilisateursDAO.Instance.GetUtilisateurs();
        } */

        public bool Login(string name, string password)
        {
            return UtilisateursDAO.Instance.Login(name, password);
        }
    }
}