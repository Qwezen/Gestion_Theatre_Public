using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using GestionTheatreBO;

namespace GestionTheatreDAL
{
    public class AuteurDAO : Singleton<AuteurDAO>
    {
        private List<Auteur> _auteurs;
        public List<Auteur> Auteurs => _auteurs;

        public AuteurDAO()
        {
            _auteurs = GetAuteurs();
        }

        private List<Auteur> GetAuteurs()
        {
            List<Auteur> auteurs = new List<Auteur>();
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM auteur";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id_auteur"].ToString());
                        string name = reader["nom_auteur"] == DBNull.Value ? string.Empty :
                            reader["nom_auteur"].ToString();
                        string firstName = reader["prenom_auteur"] == DBNull.Value ? string.Empty :
                            reader["prenom_auteur"].ToString();

                        auteurs.Add(new Auteur(id, name, firstName));
                    }
                }
            }

            return auteurs;
        }
    }
}
