namespace GestionTheatreBO
{
    public class Theme
    {
        private int _id;
        private string _type;

        public Theme(int id, string type)
        {
            _id = id;
            _type = type;
        }

        public int ID => _id;
        public string Type => _type;

        public override string ToString()
        {
            return _type;
        }
    }
}
