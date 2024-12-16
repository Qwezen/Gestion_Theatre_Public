using System.Collections.Generic;
using GestionTheatreBO;
using GestionTheatreDAL;

namespace GestionTheatreBLL
{
    public class GestionReservations : Singleton<GestionReservations>
    {
        public List<Reservation> GetReservations()
        {
            return ReservationsDAO.Instance.GetReservations();
        }

        public int GetNbPlace(Representation representation)
        {
            return ReservationsDAO.Instance.GetNbPlace(representation);
        }

        public string AddReservation(Reservation reservation)
        {
            return ReservationsDAO.Instance.AddReservation(reservation);
        }
        public string UpdateReservation(Reservation oldReservation, Reservation newReservation) 
        {
            return ReservationsDAO.Instance.UpdateReservation(oldReservation, newReservation);
        }

        public string DeleteReservation(Reservation reservation)
        {
            return ReservationsDAO.Instance.DeleteReservation(reservation);
        }
    }
}
