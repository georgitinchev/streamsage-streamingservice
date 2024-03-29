using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;


namespace DataAccessLibrary
{
	public class DatabaseOperations
	{
		private string connectionString = "Server=mssqlstud.fhict.local;Database=dbi524441_streamsage;User Id=dbi524441_streamsage;Password=e9999619;TrustServerCertificate=true;";

		public DataTable GetMovies()
		{
			var dataTable = new DataTable();
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using(var command = new SqlCommand("SELECT * FROM Movie", connection))
				{
					using(var reader = command.ExecuteReader())
					{
						dataTable.Load(reader);
					}
				}
			}
			return dataTable;
		}

        public object GetUsers()
        {
			var dataTable = new DataTable();
            using (var connection = new SqlConnection(connectionString))
			{
                connection.Open();
                using (var command = new SqlCommand("SELECT * FROM [User]", connection))
				{
                    using (var reader = command.ExecuteReader())
					{
                        dataTable.Load(reader);
                    }
                }
            }
            return dataTable;
        }
    }
}
