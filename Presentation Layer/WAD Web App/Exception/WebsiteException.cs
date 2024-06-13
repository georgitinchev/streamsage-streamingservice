namespace StreamSageWAD.Exception
{
    public class WebsiteException : System.Exception
    {
        public WebsiteException() { }

        public WebsiteException(string message) : base(message) { }

        public WebsiteException(string message, System.Exception inner) : base(message, inner) { }
    }

    public class UserNotFoundException : WebsiteException
    {
        public UserNotFoundException() { }

        public UserNotFoundException(string message) : base(message) { }

        public UserNotFoundException(string message, System.Exception inner) : base(message, inner) { }
    }

    public class InvalidCredentialsException : WebsiteException
    {
        public InvalidCredentialsException() { }

        public InvalidCredentialsException(string message) : base(message) { }

        public InvalidCredentialsException(string message, System.Exception inner) : base(message, inner) { }
    }

    public class RegistrationFailedException : WebsiteException
    {
        public RegistrationFailedException() { }

        public RegistrationFailedException(string message) : base(message) { }

        public RegistrationFailedException(string message, System.Exception inner) : base(message, inner) { }
    }

    public class LoginFailedException : WebsiteException
    {
        public LoginFailedException() { }

        public LoginFailedException(string message) : base(message) { }

        public LoginFailedException(string message, System.Exception inner) : base(message,inner) { }
    }
    public class MovieNotFoundException : WebsiteException
    {
        public MovieNotFoundException() { }

        public MovieNotFoundException(string message) : base(message) { }

        public MovieNotFoundException(string message, System.Exception inner) : base(message, inner) { }
    }
}
