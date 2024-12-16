using GestionTheatreBO;
using GestionTheatreDAL;
using System.Collections.Generic;

namespace GestionTheatreBLL
{
    public class GestionAuteurs : Singleton<GestionAuteurs>
    {
        public List<Auteur> Auteurs => AuteurDAO.Instance.Auteurs;
    }
}
