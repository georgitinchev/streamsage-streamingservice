using Microsoft.Data.SqlClient;


namespace DataAccessLibrary
{
    public class BaseDAL
    {
        protected const string ConnectionString = "Server=mssqlstud.fhict.local;Database=dbi524441_streamsage;User Id=dbi524441_streamsage;Password=e9999619;TrustServerCertificate=true";

        public BaseDAL()
        {

        }

        protected SqlConnection CreateConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                return connection;
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occurred while connecting to the database: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred: " + ex.Message);
            }
        }
    }
}

