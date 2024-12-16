using System;
using System.Data.SqlClient;
using GestionTheatreBO;

namespace GestionTheatreDAL
{
    public class ConnexionBD : Singleton<ConnexionBD>
    {
        private SqlConnection _co;
        private string _sConnection;
        public string SConnection
        {
            get { return _sConnection; }
            set { _sConnection = value; }
        }

        public SqlConnection GetSqlConnection()
        {
            if (string.IsNullOrEmpty(_sConnection))
            {
                throw new InvalidOperationException("La chaîne de connexion n'a pas été définie.");
            }

            if (_co == null)
            {
                _co = new SqlConnection();
            }

            try
            {
                if (_co.State == System.Data.ConnectionState.Closed)
                {
                    _co.ConnectionString = _sConnection;
                    _co.Open();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erreur lors de l'ouverture de la connexion SQL : " + ex.Message);
            }

            return _co;
        }


        public void CloseConnection()
        {
            if (_co != null && _co.State != System.Data.ConnectionState.Closed)
            {
                _co.Close();
            }
        }
    }
}
