using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using GestionTheatreBO;

namespace GestionTheatreDAL
{
    public class ReservationsDAO : Singleton<ReservationsDAO>
    {
        public List <Reservation> GetReservations()
        {
            List<Client> clients = ClientsDAO.Instance.GetClients();
            List<Representation> representations = RepresentationsDAO.Instance.GetRepresentations();

            List<Reservation> reservations = new List<Reservation>();
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM reserve";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int idRepresentation = int.Parse(reader["id_representation"].ToString());
                        int idClient = int.Parse(reader["id_client"].ToString());
                        int nb_place_reserve = int.Parse(reader["nb_place_reserve"].ToString());
                        Reservation reservation = new Reservation(representations.Where(x => x.ID == idRepresentation).First(),
                            clients.Where(x => x.ID == idClient).First(), nb_place_reserve);
                        reservations.Add(reservation);
                    }
                }
            }
            return reservations;
        }

        public string AddReservation(Reservation reservation)
        {
            int idClient = ClientsDAO.Instance.AddClient(reservation.Client).ID;

            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = @"
                    INSERT INTO reserve (id_representation, id_client, nb_place_reserve) 
                    VALUES (@IdRepresentation, @IdClient, @NbPlaceReserve);";

                cmd.Parameters.Add(new SqlParameter("@IdRepresentation", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@IdClient", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@NbPlaceReserve", System.Data.SqlDbType.Int));

                cmd.Parameters["@IdRepresentation"].Value = reservation.Representation.ID;
                cmd.Parameters["@IdClient"].Value = idClient;
                cmd.Parameters["@NbPlaceReserve"].Value = reservation.NbPlaceReserve;

                try
                {
                    cmd.ExecuteNonQuery();

                    return "Succès de l'ajout.";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public string UpdateReservation(Reservation oldReservation, Reservation newReservation)
        {
            if (!oldReservation.Client.Equals(newReservation.Client))
                ClientsDAO.Instance.UpdateClient(newReservation.Client);

            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                
                cmd.CommandText = @"
                    UPDATE reserve 
                    SET id_representation = @NewIdRepresentation, 
                        nb_place_reserve = @NbPlaceReserve 
                    WHERE id_representation = @IdRepresentation 
                      AND id_client = @IdClient";
                      
                cmd.Parameters.Add(new SqlParameter("@NewIdRepresentation", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@NbPlaceReserve", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@IdRepresentation", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@IdClient", System.Data.SqlDbType.Int));

                cmd.Parameters["@IdRepresentation"].Value = oldReservation.Representation.ID;
                cmd.Parameters["@IdClient"].Value = oldReservation.Client.ID;
                cmd.Parameters["@NewIdRepresentation"].Value = newReservation.Representation.ID;
                cmd.Parameters["@NbPlaceReserve"].Value = newReservation.NbPlaceReserve;

                try
                {
                    cmd.ExecuteNonQuery();

                    return "Modification réussi";
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }
        }

        public int GetNbPlace(Representation representation)
        {
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = @"
                    SELECT (representation.nb_place_representation - ISNULL(SUM(reserve.nb_place_reserve), 0)) AS nb_place
                    FROM representation
                    LEFT JOIN reserve ON representation.id_representation = reserve.id_representation
                    WHERE representation.id_representation = @Representation
                    GROUP BY representation.nb_place_representation";

                cmd.Parameters.Add(new SqlParameter("@Representation", System.Data.SqlDbType.Int));
                cmd.Parameters["@Representation"].Value = representation.ID;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return int.Parse(reader["nb_place"].ToString());
                    }
                }
            }
            return 0;
        }

      public string DeleteReservation(Reservation reservation)
          {
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"DELETE FROM reserve 
                    WHERE id_representation = @ID_Representation
                    AND id_client = @ID_Client
                    AND nb_place_reserve = @Nb_Place";

                cmd.Parameters.Add(new SqlParameter("@ID_Representation", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@ID_Client", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@Nb_Place", System.Data.SqlDbType.Int));

                cmd.Parameters["@ID_Representation"].Value = reservation.Representation.ID;
                cmd.Parameters["@ID_Client"].Value = reservation.Client.ID;
                cmd.Parameters["@Nb_Place"].Value = reservation.NbPlaceReserve;
                
                try
                {
                    cmd.ExecuteNonQuery();

                    return "Succès de la suppression.";
                }
                catch (SqlException e)
                {
                    return e.Message;
                }
            }
        }
    }
}
