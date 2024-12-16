namespace GestionTheatreBO
{
    public class Piece
    {
        private int _id; 
        private string _name;
        private string _description;
        private float _time; 
        private float _tarif;

        private Theme _theme;
        private Public _public;
        private Compagnie _compagnie;   
        private Auteur _auteur;

        public Piece(int id, string name, string description, float time, float tarif, Theme theme, Public typePublic, Compagnie compagnie, Auteur auteur)
        {
            _id = id;
            _name = name;
            _description = description;
            _time = time;
            _tarif = tarif;
            _theme = theme;
            _public = typePublic;
            _compagnie = compagnie;
            _auteur = auteur;
        }

        public int ID => _id;
        public string Name => _name;
        public string Description => _description;
        public float Time => _time;
        public float Tarif => _tarif;
        public Theme Theme => _theme;
        public Public Public => _public;
        public Compagnie Compagnie => _compagnie;
        public Auteur Auteur => _auteur;

        public override string ToString()
        {
            return $"{_name}";
        }
    }
}
