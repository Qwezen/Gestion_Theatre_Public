using System;

namespace GestionTheatreBO
{
    public class Client
    {
        private int _id; 
        private string _name;
        private string _firstName;
        private string _mail;
        private int _tel;

        public Client(int id, string name, string firstName, string mail, int tel)
        {
            _id = id;
            _name = name;
            _firstName = firstName;
            _mail = mail;
            _tel = tel;
        }

        public int ID => _id;
        public string Name => _name; 
        public string FirstName => _firstName;   
        public string Mail => _mail;   
        public int Tel => _tel;

        public override string ToString()
        {
            return $"{_firstName} {_name}";
        }

        public override bool Equals(object obj)
        {
            Type t = obj.GetType();

            if (t.Equals(typeof(Client)))
            {
                Client client = obj as Client;

                return _name == client.Name && _firstName == client.FirstName && _mail == client.Mail && _tel == client.Tel;
            }

            return false;
        }
    }
}
