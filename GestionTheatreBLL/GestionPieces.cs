using System.Collections.Generic;
using GestionTheatreBO;
using GestionTheatreDAL;

namespace GestionTheatreBLL
{
    public class GestionPieces : Singleton<GestionPieces>
    {
        public List<Piece> GetPieces()
        {
            return PiecesDAO.Instance.GetPieces();
        }

        public Piece GetPieceByID(int id)
        {
            return PiecesDAO.Instance.GetPieceByID(id);
        }

        public string AddPiece(Piece piece)
        {
            return PiecesDAO.Instance.AddPiece(piece);
        }

        public string DeletePiece(Piece piece)
        {
            return PiecesDAO.Instance.DeletePiece(piece);
        }

        public string UpdatePiece(Piece piece)
        {
            return PiecesDAO.Instance.UpdatePiece(piece);
        }

        public bool ConstraintRepresentation(Piece piece)
        {
            return PiecesDAO.Instance.ConstraintRepresentation(piece);
        }

        public bool ConstraintReservation(Piece piece)
        {
            return PiecesDAO.Instance.ConstraintReservation(piece);
        }
        public List<Piece> Pieces => PiecesDAO.Instance.GetPieces();
    }
}
