using GestionTheatreBO;
using GestionTheatreDAL;
using System;
using System.Collections.Generic;

namespace GestionTheatreBLL
{
    public class GestionRepresentations : Singleton<GestionRepresentations> 
    {
        public List<Representation> Representations => RepresentationsDAO.Instance.Representations;
        public List<Representation> GetRepresentations()
        {
            return RepresentationsDAO.Instance.GetRepresentations();
        }

        public Representation GetRepresentationById(int id)
        {
            return RepresentationsDAO.Instance.GetRepresentationById(id);  
        }
        public List<Representation> GetFilterRepresentations(Piece piece, bool filterDate = false, DateTime firstDate = default, DateTime secondDate = default)
        {
            return RepresentationsDAO.Instance.GetFilterRepresentations(piece, filterDate, firstDate, secondDate);
        }
        public string AddRepresentation(Representation representation)
        {
            return RepresentationsDAO.Instance.AddRepresentation(representation);
        }

        public string DeleteRepresentation(Representation representation)
        {
            return RepresentationsDAO.Instance.DeleteRepresentation(representation);
        }

        public bool ConstraintReservation(Representation representation)
        {
            return RepresentationsDAO.Instance.ConstraintReservation(representation);
        }

        public string UpdateRepresentation(Representation representation)
        {
            return RepresentationsDAO.Instance.UpdateRepresentation(representation);
        }

        //public Piece GetPieceById(int pieceId)
        //{
        //    return PiecesDAO.Instance.GetPieceById(pieceId);
        //}

        public Tarif GetTarifByLibelle(int Idlibel)
        {
            return TarifsDAO.Instance.GetTarifByLibelle(Idlibel); 
        }
    }
}
