using Microsoft.Data.SqlClient;
using System.Data;


namespace DataAccessLibrary
{
    public abstract class BaseDAL
    {
        protected const string ConnectionString = "Server=mssqlstud.fhict.local;Database=dbi524441_streamsage;User Id=dbi524441_streamsage;Password=e9999619;TrustServerCertificate=true";
        protected SqlConnection CreateConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                return connection;
            }
            catch (SqlException ex)
            {
                throw new System.Exception("An error occurred while connecting to the database: " + ex.Message);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("An error occurred: " + ex.Message);
            }
        }
    }
}

