using Microsoft.Data.SqlClient;
using DataAccessLibrary.Exception;

namespace DataAccessLibrary
{
    public abstract class BaseDAL
    {
        protected readonly string ConnectionString;

        protected BaseDAL(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public SqlConnection CreateConnection()
        {
            try
            {
                return new SqlConnection(ConnectionString);
            }
            catch (SqlException ex)
            {
                throw new DataAccessException(DataAccessException.GetDatabaseErrorMessage("creating connection"), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException(DataAccessException.GetInvalidOperationErrorMessage("creating connection"), ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException(DataAccessException.GetUnexpectedErrorMessage("creating connection"), ex);
            }
        }
    }
}
