namespace GestionTheatreBO
{
    public class Public
    {
        private int _id;
        private string _type;

        public Public(int id, string type)
        {
            _id = id;
            _type = type;
        }

        public int ID => _id;
        public string Type => _type;

        private string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }

        public override string ToString()
        {
            return FirstLetterToUpper(_type);
        }
    }
}
