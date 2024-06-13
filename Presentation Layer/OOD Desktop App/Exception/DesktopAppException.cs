using System;

namespace DesktopApp.Exception
{
    public class DesktopAppException : System.Exception
    {
        public DesktopAppException() : base() { }

        public DesktopAppException(string message) : base(message) { }

        public DesktopAppException(string message, System.Exception innerException) : base(message, innerException) { }
    }

    public class MovieNotFoundException : DesktopAppException
    {
        public MovieNotFoundException() : base() { }

        public MovieNotFoundException(string message) : base(message) { }

        public MovieNotFoundException(string message, System.Exception innerException) : base(message, innerException) { }
    }

    public class InvalidMovieException : DesktopAppException
    {
        public InvalidMovieException() : base() { }

        public InvalidMovieException(string message) : base(message) { }

        public InvalidMovieException(string message, System.Exception innerException) : base(message, innerException) { }
    }

    public class InvalidUserException : DesktopAppException
    {
        public InvalidUserException() : base() { }

        public InvalidUserException(string message) : base(message) { }

        public InvalidUserException(string message, System.Exception innerException) : base(message, innerException) { }
    }

    public class UserNotFoundException : DesktopAppException
    {
        public UserNotFoundException() : base() { }

        public UserNotFoundException(string message) : base(message) { }

        public UserNotFoundException(string message, System.Exception innerException) : base(message, innerException) { }
    }

    public class InvalidReviewException : DesktopAppException
    {
        public InvalidReviewException() : base() { }

        public InvalidReviewException(string message) : base(message) { }

        public InvalidReviewException(string message, System.Exception innerException) : base(message, innerException) { }
    }

}
