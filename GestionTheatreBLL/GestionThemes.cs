using GestionTheatreBO;
using GestionTheatreDAL;
using System.Collections.Generic;

namespace GestionTheatreBLL
{
    public class GestionThemes : Singleton<GestionThemes>
    {
        public List<Theme> Themes => ThemeDAO.Instance.Themes;
    }
}
