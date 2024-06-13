using System;

namespace DataAccessLibrary.Exception
{
    public class DataAccessException : System.Exception
    {
        public DataAccessException() : base() { }

        public DataAccessException(string message) : base(message) { }

        public DataAccessException(string message, System.Exception innerException) : base(message, innerException) { }

        public const string DatabaseErrorMessage = "A database error occurred.";
        public const string InvalidOperationErrorMessage = "The operation is not valid due to the current state of the object.";
        public const string UnexpectedErrorMessage = "An unexpected error occurred.";

        public static string GetDatabaseErrorMessage(string action)
        {
            return $"{DatabaseErrorMessage} {action}.";
        }

        public static string GetInvalidOperationErrorMessage(string action)
        {
            return $"{InvalidOperationErrorMessage} {action}.";
        }

        public static string GetUnexpectedErrorMessage(string action)
        {
            return $"{UnexpectedErrorMessage} {action}.";
        }
    }
}
    