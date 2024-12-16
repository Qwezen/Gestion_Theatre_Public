using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using GestionTheatreBO;

namespace GestionTheatreDAL
{
    public class ComediensDAO : Singleton<ComediensDAO>
    {
        public List<Comedien> GetComediens()
        {
            List<Comedien> comediens = new List<Comedien>();
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM comedien";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id_comedien"].ToString());
                        string name = reader["nom_comedien"] == DBNull.Value ? string.Empty :
                            reader["nom_comedien"].ToString();
                        string firstName = reader["prenom_comedien"] == DBNull.Value ? string.Empty :
                            reader["prenom_comedien"].ToString();
                        int age = int.Parse(reader["age_comedien"].ToString());
                        string nation = reader["nationnalite_comedien"] == DBNull.Value ? string.Empty :
                            reader["nationnalite_comedien"].ToString();

                        comediens.Add(new Comedien(id, name, firstName, age, nation));
                    }
                }
            }

            return comediens;
        }
    }
}
