using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using GestionTheatreBO;

namespace GestionTheatreDAL
{
    public class PublicDAO : Singleton<PublicDAO>
    {
        private List<Public> _publics;
        public List<Public> Publics => _publics;

        public PublicDAO()
        {
            _publics = GetPublics();
        }

        private List<Public> GetPublics()
        {
            List<Public> publics = new List<Public>();
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM tpublic";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id_tpublic"].ToString());
                        string type = reader["type_tpublic"] == DBNull.Value ? string.Empty :
                            reader["type_tpublic"].ToString();

                        publics.Add(new Public(id, type));
                    }
                }
            }

            return publics;
        }
    }
}
