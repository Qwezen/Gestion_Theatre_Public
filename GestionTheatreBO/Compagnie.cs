namespace GestionTheatreBO
{
    public class Compagnie
    {
        private int _id;
        private string _name;
        private string _provCompagnie;
        private string _directorArt;

        public Compagnie(int id, string name, string provCompagnie, string directorArt)
        {
            _id = id;
            _name = name;
            _provCompagnie = provCompagnie;
            _directorArt = directorArt;
        }

        public int ID => _id;
        public string Name => _name;
        public string ProvCompagnie=> _provCompagnie;
        public string DirectorArt=> _directorArt;

        public override string ToString()
        {
            return _name;
        }
    }
}
