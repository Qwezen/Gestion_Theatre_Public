using GestionTheatreBO;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestionTheatreDAL
{
    public class UtilisateursDAO : Singleton<UtilisateursDAO>
    {
        public bool Login(string name, string password)
        {
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM utilisateur WHERE identifiant_utilisateur = @Name AND mdp_utilisateur = @Password";
                cmd.Parameters.Add(new SqlParameter("@Name", System.Data.SqlDbType.VarChar, 255));
                cmd.Parameters.Add(new SqlParameter("@Password", System.Data.SqlDbType.VarChar, 255));
                cmd.Parameters["@Name"].Value = name;
                cmd.Parameters["@Password"].Value = password;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }

        /* public List<Utilisateur> GetUtilisateurs()
        {
            List<Utilisateur> utilisateurs = new List<Utilisateur>();
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM utilisateur";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id_utilisateur"].ToString());
                        string name = reader["identifiant_utilisateur"] == DBNull.Value ? string.Empty :
                            reader["identifiant_utilisateur"].ToString();
                        string password = reader["mdp_utilisateur"] == DBNull.Value ? string.Empty :
                            reader["mdp_utilisateur"].ToString();

                        utilisateurs.Add(new Utilisateur(id, name, password));
                    }
                }
            }

            return utilisateurs;
        } */
    }
}