using GestionTheatreBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestionTheatreDAL
{
    public class ClientsDAO: Singleton<ClientsDAO>
    {
        public List<Client> GetClients()
        {
            List<Client> clients = new List<Client>();
            using(SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM client";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id_client"].ToString());
                        string name = reader["nom_client"] == DBNull.Value ? string.Empty :
                            reader["nom_client"].ToString();
                        string firstName = reader["prenom_client"] == DBNull.Value ? string.Empty :
                            reader["prenom_client"].ToString();
                        string mail = reader["mail_client"] == DBNull.Value ? string.Empty :
                            reader["mail_client"].ToString();
                        int tel = int.Parse(reader["tel_client"].ToString());

                        Client client = new Client(id, name, firstName, mail, tel);
                        clients.Add(client); 
                    }
                }
            }

            return clients; 
        }

        public Client GetClientByName(string firstName, string name)
        {
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM client WHERE prenom_client = @FirstName_Client AND nom_client = @Name_Client";
                cmd.Parameters.Add(new SqlParameter("@FirstName_Client", System.Data.SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@Name_Client", System.Data.SqlDbType.VarChar));
                cmd.Parameters["@FirstName_Client"].Value = firstName;
                cmd.Parameters["@Name_Client"].Value = name;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id_client"].ToString());
                        string mail = reader["mail_client"] == DBNull.Value ? string.Empty :
                            reader["mail_client"].ToString();
                        int tel = int.Parse(reader["tel_client"].ToString());

                        return new Client(id, name, firstName, mail, tel);
                    }
                }
            }

            return null;
        }

        public Client AddClient(Client client)
        {
            Client haveClient = GetClientByName(client.FirstName, client.Name);
            if (haveClient != null)
                return haveClient;

            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = @"
                    INSERT INTO client (prenom_client, nom_client, mail_client, tel_client)
                    VALUES (@FirstName_Client, @Name_Client, @Mail_Client, @Tel_Client);
                    SELECT SCOPE_IDENTITY();";

                cmd.Parameters.Add(new SqlParameter("@FirstName_Client", System.Data.SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@Name_Client", System.Data.SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@Mail_Client", System.Data.SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@Tel_Client", System.Data.SqlDbType.Int));

                cmd.Parameters["@FirstName_Client"].Value = client.FirstName;
                cmd.Parameters["@Name_Client"].Value = client.Name;
                cmd.Parameters["@Mail_Client"].Value = client.Mail;
                cmd.Parameters["@Tel_Client"].Value = client.Tel;

                object result = cmd.ExecuteScalar();
                int id = result != null && int.TryParse(result.ToString(), out int newId) ? newId : 0;

                return new Client(id, client.Name, client.FirstName, client.Mail, client.Tel);
            }
        }

        public void UpdateClient(Client client)
        {
            using (SqlConnection con = ConnexionBD.Instance.GetSqlConnection())
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = @"
                    UPDATE client 
                    SET prenom_client = @FirstName_Client, 
                        nom_client = @Name_Client, 
                        mail_client = @Mail_Client, 
                        tel_client = @Tel_Client
                    WHERE id_client = @Id_Client";

                cmd.Parameters.Add(new SqlParameter("@FirstName_Client", System.Data.SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@Name_Client", System.Data.SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@Mail_Client", System.Data.SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@Tel_Client", System.Data.SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@Id_Client", System.Data.SqlDbType.Int));

                cmd.Parameters["@FirstName_Client"].Value = client.FirstName;
                cmd.Parameters["@Name_Client"].Value = client.Name;
                cmd.Parameters["@Mail_Client"].Value = client.Mail;
                cmd.Parameters["@Tel_Client"].Value = client.Tel;
                cmd.Parameters["@Id_Client"].Value = client.ID;

                cmd.ExecuteNonQuery();
            }
        }
    }
}