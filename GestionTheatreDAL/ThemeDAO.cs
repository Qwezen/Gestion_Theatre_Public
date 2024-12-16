using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using GestionTheatreBO;

namespace GestionTheatreDAL
{
    public class ThemeDAO : Singleton<ThemeDAO>
    {
        private List<Theme> _themes;
        public List<Theme> Themes => _themes;

        public ThemeDAO()
        {
            _themes = GetThemes();
        }

        private List<Theme> GetThemes()
        {
            List<Theme> themes = new List<Theme>();
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM theme";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id_theme"].ToString());
                        string type = reader["type_theme"] == DBNull.Value ? string.Empty :
                            reader["type_theme"].ToString();

                        themes.Add(new Theme(id, type));
                    }
                }
            }

            return themes;
        }
    }
}
