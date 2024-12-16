namespace GestionTheatreBO
{
    public class Utilisateur
    {
        private int _id;
        private string _name;
        private string _password;

        public Utilisateur(int id, string name, string password)
        {
            _id = id;
            _name = name;
            _password = password;
        }

        public int ID => _id;
        public string Name => _name;
        public string Password => _password;
    }
}