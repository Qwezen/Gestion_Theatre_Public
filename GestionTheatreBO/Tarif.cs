namespace GestionTheatreBO
{
    public class Tarif
    {
        private int _id;
        private string _libelle;
        private float _variation;

        public Tarif(int id, string libelle, float variation)
        {
            _id = id;
            _libelle = libelle;
            _variation = variation;
        }

        public int ID => _id;
        public string Libelle => _libelle;
        public float Variation => _variation;

        public override string ToString()
        {
            return $"{_libelle} | {_variation}%";
        }
    }
}
