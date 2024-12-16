using System;

namespace GestionTheatreBO
{
    public class Representation
    {
        private int _idRepresentation;
        private DateTime _dateRepresentation;
        private int _nbPlace;
        private Tarif _tarif;
        private Piece _piece;
        public Representation(int idRepresentation, DateTime dateRepresentation, int nbPlace, Tarif tarif, Piece piece)
        {
            _idRepresentation = idRepresentation;
            _dateRepresentation = dateRepresentation;
            _nbPlace = nbPlace;
            _tarif = tarif;
            _piece = piece;
        }

        public int ID => _idRepresentation;
        public DateTime DateRepresentation => _dateRepresentation;  
        public int NBPlace => _nbPlace;
        public Tarif Tarif => _tarif;
        public Piece Piece => _piece;

        public override string ToString()
        {
            return $"{_piece} - {_dateRepresentation.Date.Day}/{_dateRepresentation.Date.Month}/{_dateRepresentation.Date.Year} " +
                $"{_dateRepresentation.TimeOfDay.Hours}:{_dateRepresentation.TimeOfDay.Minutes}";
        }
    }
}
