using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using GestionTheatreBO;

namespace GestionTheatreDAL
{
    public class PiecesDAO : Singleton<PiecesDAO>
    {
        public List<Piece> GetPieces()
        {
            List<Theme> themes = ThemeDAO.Instance.Themes;
            List<Auteur> auteurs = AuteurDAO.Instance.Auteurs;
            List<Compagnie> compagnies = CompagniesDAO.Instance.Compagnies;
            List<Public> publics = PublicDAO.Instance.Publics;

            List<Piece> pieces = new List<Piece>();
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM piece";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id_piece"].ToString());
                        string name = reader["nom_piece"] == DBNull.Value ? string.Empty : 
                            reader["nom_piece"].ToString();
                        string description = reader["description_piece"] == DBNull.Value ? string.Empty :
                            reader["description_piece"].ToString();
                        float time = reader["duree_piece"] == DBNull.Value ? 0f :
                            float.Parse(reader["duree_piece"].ToString());
                        float tarif = reader["tarif_piece"] == DBNull.Value ? 0f :
                            float.Parse(reader["tarif_piece"].ToString());
                        int idTheme = int.Parse(reader["id_theme"].ToString());
                        int idAuteur = int.Parse(reader["id_auteur"].ToString());
                        int idPublic = int.Parse(reader["id_tpublic"].ToString());
                        int idCompagnie = int.Parse(reader["id_compagnie"].ToString());

                        pieces.Add(new Piece(id, name, description, time, tarif,
                            themes.Where(x => x.ID == idTheme).FirstOrDefault(),
                            publics.Where(x => x.ID == idPublic).FirstOrDefault(),
                            compagnies.Where(x => x.ID == idCompagnie).FirstOrDefault(),
                            auteurs.Where(x => x.ID == idAuteur).FirstOrDefault()));
                    }
                }
            }

            return pieces;
        }

        public Piece GetPieceByID(int id)
        {
            List<Theme> themes = ThemeDAO.Instance.Themes;
            List<Auteur> auteurs = AuteurDAO.Instance.Auteurs;
            List<Compagnie> compagnies = CompagniesDAO.Instance.Compagnies;
            List<Public> publics = PublicDAO.Instance.Publics;

            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM piece WHERE id_piece = @ID_Piece";
                cmd.Parameters.Add(new SqlParameter("@ID_Piece", System.Data.SqlDbType.Int));
                cmd.Parameters["@ID_Piece"].Value = id;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["nom_piece"] == DBNull.Value ? string.Empty :
                            reader["nom_piece"].ToString();
                        string description = reader["description_piece"] == DBNull.Value ? string.Empty :
                            reader["description_piece"].ToString();
                        float time = reader["duree_piece"] == DBNull.Value ? 0f :
                            float.Parse(reader["duree_piece"].ToString());
                        float tarif = reader["tarif_piece"] == DBNull.Value ? 0f :
                            float.Parse(reader["tarif_piece"].ToString());
                        int idTheme = int.Parse(reader["id_theme"].ToString());
                        int idAuteur = int.Parse(reader["id_auteur"].ToString());
                        int idPublic = int.Parse(reader["id_tpublic"].ToString());
                        int idCompagnie = int.Parse(reader["id_compagnie"].ToString());

                        return new Piece(id, name, description, time, tarif,
                            themes.Where(x => x.ID == idTheme).FirstOrDefault(),
                            publics.Where(x => x.ID == idPublic).FirstOrDefault(),
                            compagnies.Where(x => x.ID == idCompagnie).FirstOrDefault(),
                            auteurs.Where(x => x.ID == idAuteur).FirstOrDefault());
                    }
                }
            }

            return null;
        }

        public string AddPiece(Piece piece)
        {
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = @"
                    INSERT INTO piece 
                    (nom_piece, description_piece, duree_piece, tarif_piece, id_theme, id_auteur, id_tpublic, id_compagnie) 
                    VALUES 
                    (@Name, @Description, @Time, @Tarif, @ID_Theme, @ID_Auteur, @ID_Type_Public, @ID_Compagnie)";

                cmd.Parameters.Add(new SqlParameter("@Name", System.Data.SqlDbType.VarChar, 255));
                cmd.Parameters.Add(new SqlParameter("@Description", System.Data.SqlDbType.VarChar, 500));
                cmd.Parameters.Add(new SqlParameter("@Time", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@Tarif", System.Data.SqlDbType.Float));
                cmd.Parameters.Add(new SqlParameter("@ID_Theme", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@ID_Auteur", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@ID_Type_Public", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@ID_Compagnie", System.Data.SqlDbType.Int));

                cmd.Parameters["@Name"].Value = piece.Name;
                cmd.Parameters["@Description"].Value = piece.Description;
                cmd.Parameters["@Time"].Value = piece.Time;
                cmd.Parameters["@Tarif"].Value = piece.Tarif;
                cmd.Parameters["@ID_Theme"].Value = piece.Theme.ID;
                cmd.Parameters["@ID_Auteur"].Value = piece.Auteur.ID;
                cmd.Parameters["@ID_Type_Public"].Value = piece.Public.ID;
                cmd.Parameters["@ID_Compagnie"].Value = piece.Compagnie.ID;

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

        public string DeletePiece(Piece piece)
        {
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM representation WHERE id_piece = @ID_Piece; DELETE FROM piece WHERE id_piece = @ID_Piece";
                cmd.Parameters.Add(new SqlParameter("@ID_Piece", System.Data.SqlDbType.Int));
                cmd.Parameters["@ID_Piece"].Value = piece.ID;

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

        public string UpdatePiece(Piece piece)
        {
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "UPDATE piece SET nom_piece = @Name, description_piece = @Description, duree_piece = @Time, tarif_piece = @Tarif, id_theme = @ID_Theme, id_tpublic = @ID_Type_Public, id_auteur = @ID_Auteur, id_compagnie = @ID_Compagnie WHERE id_piece = @ID_Piece";

                cmd.Parameters.Add(new SqlParameter("@ID_Piece", System.Data.SqlDbType.Int, 255));
                cmd.Parameters.Add(new SqlParameter("@Name", System.Data.SqlDbType.VarChar, 255));
                cmd.Parameters.Add(new SqlParameter("@Description", System.Data.SqlDbType.VarChar, 500));
                cmd.Parameters.Add(new SqlParameter("@Time", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@Tarif", System.Data.SqlDbType.Float));
                cmd.Parameters.Add(new SqlParameter("@ID_Theme", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@ID_Auteur", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@ID_Type_Public", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@ID_Compagnie", System.Data.SqlDbType.Int));

                cmd.Parameters["@ID_Piece"].Value = piece.ID;
                cmd.Parameters["@Name"].Value = piece.Name;
                cmd.Parameters["@Description"].Value = piece.Description;
                cmd.Parameters["@Time"].Value = piece.Time;
                cmd.Parameters["@Tarif"].Value = piece.Tarif;
                cmd.Parameters["@ID_Theme"].Value = piece.Theme.ID;
                cmd.Parameters["@ID_Auteur"].Value = piece.Auteur.ID;
                cmd.Parameters["@ID_Type_Public"].Value = piece.Public.ID;
                cmd.Parameters["@ID_Compagnie"].Value = piece.Compagnie.ID;

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

        public bool ConstraintRepresentation(Piece piece)
        {
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM representation WHERE id_piece = @ID_piece";
                cmd.Parameters.Add(new SqlParameter("ID_piece", System.Data.SqlDbType.Int, 255));
                cmd.Parameters["ID_piece"].Value = piece.ID;
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

        public bool ConstraintReservation(Piece piece)
        {
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM reserve INNER JOIN representation ON reserve.id_representation = representation.id_representation INNER JOIN piece ON representation.id_piece = piece.id_piece WHERE representation.id_piece = @ID_Piece";
                cmd.Parameters.Add(new SqlParameter("ID_Piece", System.Data.SqlDbType.Int, 255));
                cmd.Parameters["ID_Piece"].Value = piece.ID;
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
    }
}
