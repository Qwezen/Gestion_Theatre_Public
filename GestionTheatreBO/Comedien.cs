namespace GestionTheatreBO
{
    public class Comedien
    {
        private int _id;
        private string _name;
        private string _firstName;
        private int _age;
        private string _nation;

        public Comedien(int id, string name, string firstName, int age, string nation)
        {
            _id = id;
            _name = name;
            _firstName = firstName;
            _age = age;
            _nation = nation;
        }

        public int ID => _id;
        public string Name => _name;
        public string FirstName=> _firstName;
        public int Ag=> _age;
        public string Nation=> _nation;
    }
}
