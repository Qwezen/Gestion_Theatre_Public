using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using GestionTheatreBO;

namespace GestionTheatreDAL
{
    public class CompagniesDAO : Singleton<CompagniesDAO>
    {
        private List<Compagnie> _compagnies;
        public List<Compagnie> Compagnies => _compagnies;

        public CompagniesDAO()
        {
            _compagnies = GetCompagnies();
        }

        private List<Compagnie> GetCompagnies()
        {
            List<Compagnie> compagnies = new List<Compagnie>();
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM compagnie";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id_compagnie"].ToString());
                        string name = reader["nom_compagnie"] == DBNull.Value ? string.Empty :
                            reader["nom_compagnie"].ToString();
                        string provCompagnie = reader["provenance_compagnie"] == DBNull.Value ? string.Empty :
                            reader["provenance_compagnie"].ToString();
                        string directorArt = reader["directeur_artistique_compagnie"] == DBNull.Value ? string.Empty :
                            reader["directeur_artistique_compagnie"].ToString();

                        compagnies.Add(new Compagnie(id, name, provCompagnie, directorArt));
                    }
                }
            }

            return compagnies;
        }
    }
}
