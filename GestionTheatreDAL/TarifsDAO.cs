using GestionTheatreBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestionTheatreDAL
{
    public class TarifsDAO : Singleton<TarifsDAO>
    {
        private List<Tarif> _tarifs;
        public List<Tarif> Tarifs => _tarifs;

        public TarifsDAO()
        {
            _tarifs = GetTarifs();
        }

        public List<Tarif> GetTarifs()
        {
            List<Tarif> tarifs = new List<Tarif>();
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM tarif";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id_tarif"].ToString());
                        string libelle = reader["libel_tarif"] == DBNull.Value ? string.Empty :
                            reader["libel_tarif"].ToString();
                        float variation = float.Parse(reader["variation_tarif"].ToString());

                        tarifs.Add(new Tarif(id, libelle, variation));
                    }
                }
            }

            return tarifs;
        }

        public Tarif GetTarifByLibelle(string libelle)
        {
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM tarif WHERE id_tarif = @Libel;";
                cmd.Parameters.Add(new SqlParameter("@Libel", System.Data.SqlDbType.VarChar, 255));
                cmd.Parameters["@Libel"].Value = libelle;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id_tarif"].ToString());
                        float variation = float.Parse(reader["variation_tarif"].ToString());

                        return new Tarif(id, libelle, variation);
                    }
                }
            }

            return null;
        }

        public Tarif GetTarifByLibelle(int libel)
        {
            int id;
            string libelle;
            float variation;

            SqlConnection co = ConnexionBD.Instance.GetSqlConnection();
            List<Tarif> tarifs = new List<Tarif>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = co;
            cmd.CommandText = "SELECT * FROM tarif WHERE id_tarif = @Libel; ";
            cmd.Parameters.Add(new SqlParameter("@Libel", System.Data.SqlDbType.VarChar, 255));
            cmd.Parameters["@Libel"].Value = libel;
            SqlDataReader reader = cmd.ExecuteReader();
            Tarif tarif = null; 
            while (reader.Read())
            {
                id = int.Parse(reader["id_tarif"].ToString());
                if (reader["libelle_tarif"] == DBNull.Value)
                {
                    libelle = default(string);
                }
                else
                {
                    libelle = reader["libelle_tarif"].ToString();
                }
                if (reader["variation_tarif"] == DBNull.Value)
                {
                    variation = default(float);
                }
                else
                {
                    variation = float.Parse(reader["variation_tarif"].ToString());
                }
                tarif = new Tarif(id, libelle, variation);
            }
            co.Close();
            return tarif; 
        }
    }
}
