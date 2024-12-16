using System.Collections.Generic;
using GestionTheatreDAL;
using GestionTheatreBO;

namespace GestionTheatreBLL
{
    public class GestionCompagnies : Singleton<GestionCompagnies>
    {
        public List<Compagnie> Compagnies => CompagniesDAO.Instance.Compagnies;
    }
}
