using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;


namespace DataAccessLibrary
{
	public class DatabaseOperations
	{
		private string connectionString = "Server=mssqlstud.fhict.local;Database=dbi524441;User Id=dbi524441;Password=0lxkTTubUL!;Encrypt=False";

		public DataTable GetMovies()
		{
			var dataTable = new DataTable();
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using(var command = new SqlCommand("SELECT * FROM Movies", connection))
				{
					using(var reader = command.ExecuteReader())
					{
						dataTable.Load(reader);
					}
				}
			}
			return dataTable;
		}
	}
}
