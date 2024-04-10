using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;


namespace DataAccessLibrary
{
    public class BaseDAL
    {
        internal string connectionString = "Server=mssqlstud.fhict.local;Database=dbi524441_streamsage;User Id=dbi524441_streamsage;Password=REMOVED_PASSWORD;TrustServerCertificate=true;";

        public BaseDAL() { }

        public void CreateConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            connection.ConnectionString = connectionString;
        }
    }
}
