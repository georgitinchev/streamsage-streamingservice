using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;


namespace DataAccessLibrary
{
    public class BaseDAL
    {
        private string connectionString = "Server=mssqlstud.fhict.local;Database=dbi524441_streamsage;User Id=dbi524441_streamsage;Password=e9999619;TrustServerCertificate=true;";

        public BaseDAL() { }

        public void CreateConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            connection.ConnectionString = connectionString;
        }
    }
}
