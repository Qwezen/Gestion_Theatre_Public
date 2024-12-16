using System;

namespace GestionTheatreBO
{
    public class Reservation
    {
        private Representation _representation; 
        private Client _client;
        private int _nb_place_reserve;

        public Reservation(Representation representation, Client client, int nb_place_reserve)
        {
            _representation = representation;
            _client = client;
            _nb_place_reserve = nb_place_reserve;
        }

        public Representation Representation => _representation;
        public Client Client => _client;
        public int NbPlaceReserve => _nb_place_reserve;

        /* Getter public pour l'affichage de la grid view */
        public Tarif TarifView => _representation.Tarif;

        public float TotalTarifView => CalculateTotalTarif(_nb_place_reserve, _representation.Piece.Tarif, _representation.Tarif.Variation);

        public static float CalculateTotalTarif(int place, float tarif, float variation)
        {
            float basePrice = tarif * place;

            if (variation== 0)
            {
                return basePrice;
            }
            else
            {
                float variationFactor = 1 + (variation / 100);
                return basePrice * variationFactor;
            }
        }
    }
}
