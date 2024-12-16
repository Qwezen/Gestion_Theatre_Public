using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using GestionTheatreBO;

namespace GestionTheatreDAL
{
    public class RepresentationsDAO : Singleton<RepresentationsDAO>
    {
        private List<Representation> _representation;
        public List<Representation> Representations => _representation;

        public RepresentationsDAO()
        {
            _representation = GetRepresentations();
        }
        public List<Representation> GetRepresentations()
        {
            List<Piece> pieces = PiecesDAO.Instance.GetPieces();
            List<Tarif> tarifs = TarifsDAO.Instance.GetTarifs();

            List<Representation> representations = new List<Representation>();
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM representation;";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id_representation"].ToString());
                        DateTime date = Convert.ToDateTime(reader["date_representation"]);
                        int nbPlace = int.Parse(reader["nb_place_representation"].ToString());
                        int idTarif = int.Parse(reader["id_tarif"].ToString());
                        int idPiece = int.Parse(reader["id_piece"].ToString());

                        Representation uneRepresentation = new Representation(id, date, nbPlace,
                            tarifs.Where(x => x.ID == idTarif).First(),
                            pieces.Where(x => x.ID == idPiece).First());

                        representations.Add(uneRepresentation);
                    }
                }
            }
            return representations;
        }

        public Representation GetRepresentationById(int id)
        {
            Representation uneRepresentation = null ; 

            List<Piece> pieces = PiecesDAO.Instance.GetPieces();
            List<Tarif> tarifs = TarifsDAO.Instance.GetTarifs();

            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM representation WHERE id_representation = @IdRepresentation;";
                cmd.Parameters.Add(new SqlParameter("@IdRepresentation", System.Data.SqlDbType.Int));
                cmd.Parameters["@IdRepresentation"].Value = id ;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DateTime date = Convert.ToDateTime(reader["date_representation"]);
                            int nbPlace = int.Parse(reader["nb_place_representation"].ToString());
                            int idTarif = int.Parse(reader["id_tarif"].ToString());
                            int idPiece = int.Parse(reader["id_piece"].ToString());

                            uneRepresentation = new Representation(id, date, nbPlace,
                                tarifs.Where(x => x.ID == idTarif).First(),
                                pieces.Where(x => x.ID == idPiece).First());
                        }
                    }
                }
            }
            return uneRepresentation;
        }

        public List<Representation> GetFilterRepresentations(Piece piece, bool filterDate = false, DateTime firstDate = default, DateTime secondDate = default)
        {
            List<Piece> pieces = PiecesDAO.Instance.GetPieces();
            List<Tarif> tarifs = TarifsDAO.Instance.GetTarifs();

            List<Representation> representations = new List<Representation>();
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;

                if (filterDate)
                {
                    cmd.CommandText = @"SELECT * FROM representation WHERE 
                    date_representation >= @FirstDate 
                    AND date_representation <= @SecondDate 
                    AND id_piece = @Piece;";

                    cmd.Parameters.Add(new SqlParameter("@FirstDate", System.Data.SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@SecondDate", System.Data.SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@Piece", System.Data.SqlDbType.Int));

                    cmd.Parameters["@FirstDate"].Value = firstDate;
                    cmd.Parameters["@SecondDate"].Value = secondDate;
                    cmd.Parameters["@Piece"].Value = piece.ID;
                }
                else
                {
                    cmd.CommandText = @"SELECT * FROM representation WHERE 
                    id_piece = @Piece;";

                    cmd.Parameters.Add(new SqlParameter("@Piece", System.Data.SqlDbType.Int));

                    cmd.Parameters["@Piece"].Value = piece.ID;
                }

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id_representation"].ToString());
                        DateTime date = Convert.ToDateTime(reader["date_representation"]);
                        int nbPlace = int.Parse(reader["nb_place_representation"].ToString());
                        int idTarif = int.Parse(reader["id_tarif"].ToString());

                        Representation uneRepresentation = new Representation(id, date, nbPlace,
                            tarifs.Where(x => x.ID == idTarif).First(),
                            piece);

                        representations.Add(uneRepresentation);
                    }
                }
            }
            return representations;
        }

        public string AddRepresentation(Representation representation)
        {
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = @"
                    INSERT INTO representation 
                    VALUES 
                    (@Date, @NbPlace, @IdPiece, @IdTarif)";

                cmd.Parameters.Add(new SqlParameter("@Date", System.Data.SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@NbPlace", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@IdPiece", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@IdTarif", System.Data.SqlDbType.Int));

                cmd.Parameters["@Date"].Value = representation.DateRepresentation;
                cmd.Parameters["@NbPlace"].Value = representation.NBPlace;
                cmd.Parameters["@IdPiece"].Value = representation.Piece.ID;
                cmd.Parameters["@IdTarif"].Value = representation.Tarif.ID;

                try
                {
                    cmd.ExecuteNonQuery();

                    return "Succès de l'ajout.";
                }
                catch (SqlException e)
                {
                    return e.Message;
                }
            }
        }

        public string DeleteRepresentation(Representation representation)
        {
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM representation WHERE id_representation = @ID_Representation";
                cmd.Parameters.Add(new SqlParameter("@ID_Representation", System.Data.SqlDbType.Int));
                cmd.Parameters["@ID_Representation"].Value = representation.ID;

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

        public bool ConstraintReservation(Representation representation)
        {
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM reserve WHERE id_representation = @ID_Representation";
                cmd.Parameters.Add(new SqlParameter("@ID_Representation", System.Data.SqlDbType.Int));
                cmd.Parameters["@ID_Representation"].Value = representation.ID;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public string UpdateRepresentation(Representation representation)
        {
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = @"
                                    UPDATE representation SET 
                                    date_representation = @Date, 
                                    nb_place_representation = @NbPlace, 
                                    id_tarif = @IDTarif, 
                                    id_piece = @IDPiece
                                    WHERE id_representation = @ID_Representation";

                cmd.Parameters.Add(new SqlParameter("@ID_Representation", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@Date", System.Data.SqlDbType.VarChar, 255));
                cmd.Parameters.Add(new SqlParameter("@NbPlace", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@IDTarif", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@IDPiece", System.Data.SqlDbType.Int));

                cmd.Parameters["@ID_Representation"].Value = representation.ID;
                cmd.Parameters["@Date"].Value = representation.DateRepresentation;
                cmd.Parameters["@NbPlace"].Value = representation.NBPlace;
                cmd.Parameters["@IDTarif"].Value = representation.Tarif.ID;
                cmd.Parameters["@IDPiece"].Value = representation.Piece.ID;

                try
                {
                    cmd.ExecuteNonQuery();

                    return "Modification réussie.";
                }
                catch (SqlException e)
                {
                    return e.Message;
                }
            }
        }
    }
}
