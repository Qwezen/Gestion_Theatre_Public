namespace GestionTheatreBO
{
    public class Auteur
    {
        private int _id;
        private string _name;
        private string _firstName;

        public Auteur(int id, string name, string firstName)
        {
            _id = id;
            _name = name;
            _firstName = firstName;
        }

        public int ID => _id;
        public string Name => _name;
        public string FirstName => _firstName;

        public override string ToString()
        {
            return $"{_name} {_firstName}";
        }
    }
}