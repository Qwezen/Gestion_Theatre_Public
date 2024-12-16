using GestionTheatreBO;
using GestionTheatreDAL;
using System.Collections.Generic;

namespace GestionTheatreBLL
{
    public class GestionTarifs : Singleton<GestionTarifs>
    {
        public List<Tarif> Tarifs => TarifsDAO.Instance.Tarifs;
    }
}
