using System.Collections.Generic;
using GestionTheatreBO;
using GestionTheatreDAL;

namespace GestionTheatreBLL
{
    public class GestionComediens : Singleton<GestionComediens>
    {
        public List<Comedien> GetComediens()
        {
            return ComediensDAO.Instance.GetComediens();
        }
    }
}
