using GestionTheatreBO;
using GestionTheatreDAL;
using System.Collections.Generic;

namespace GestionTheatreBLL
{
    public class GestionClients : Singleton<GestionClients>
    {
        public List<Client> GetClients()
        {
            return ClientsDAO.Instance.GetClients();
        }

        public Client GetClientByName(string firstName, string name)
        {
            return ClientsDAO.Instance.GetClientByName(firstName, name);
        }
    }
}
