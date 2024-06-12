using DataAccessLibrary.Exception;
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
                return new SqlConnection(ConnectionString);
            }
            catch (SqlException ex)
            {
                throw new DataAccessException(DataAccessException.GetDatabaseErrorMessage("extracting connection string from base dal"), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException(DataAccessException.GetInvalidOperationErrorMessage("extracting connection string from base dal"), ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException(DataAccessException.GetUnexpectedErrorMessage("extracting connection string from base dal"), ex);
            }
        }
    }
}

