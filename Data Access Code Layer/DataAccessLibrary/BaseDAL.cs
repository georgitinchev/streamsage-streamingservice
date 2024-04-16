using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;


namespace DataAccessLibrary
{
    public class BaseDAL
    {
        internal string connectionString;
        public BaseDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void CreateConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                connection.ConnectionString = connectionString;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("An error occurred while connecting to the database: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

    }
}
