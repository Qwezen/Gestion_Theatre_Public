using GestionTheatreBO;
using GestionTheatreDAL;
using System.Collections.Generic;

namespace GestionTheatreBLL
{
    public class GestionPublics : Singleton<GestionPublics>
    {
        public List<Public> Publics => PublicDAO.Instance.Publics;
    }
}
