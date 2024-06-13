using System;

namespace LogicClassLibrary.Exceptions
{
    [Serializable]
    public class InvalidGenreException : Exception
    {
        public InvalidGenreException() : base() { }
        public InvalidGenreException(string message) : base(message) { }
        public InvalidGenreException(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"InvalidGenreException: {Message}";
        }
    }

    [Serializable]
    public class UpdateEntityError : Exception
    {
        public UpdateEntityError() : base() { }
        public UpdateEntityError(string message) : base(message) { }
        public UpdateEntityError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"UpdateMovieError: {Message}";
        }
    }

    [Serializable]
    public class SearchCriteriaError : Exception
    {
        public SearchCriteriaError() : base() { }
        public SearchCriteriaError(string message) : base(message) { }
        public SearchCriteriaError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"SearchCriteriaError: {Message}";
        }
    }

    [Serializable]
    public class PopulatingEntityError : Exception
    {
        public PopulatingEntityError() : base() { }
        public PopulatingEntityError(string message) : base(message) { }
        public PopulatingEntityError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"PopulatingMoviesError: {Message}";
        }
    }

    [Serializable]
    public class DeleteEntityError : Exception
    {
        public DeleteEntityError() : base() { }
        public DeleteEntityError(int movieId) : base($"Error deleting movie with ID: {movieId}") { }
        public DeleteEntityError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"DeleteMovieError: {Message}";
        }
    }

    [Serializable]
    public class NotFoundException : Exception
    {
        public NotFoundException() : base() { }
        public NotFoundException(int movieId) : base($"Movie with ID: {movieId} not found") { }
        public NotFoundException(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"MovieNotFoundException: {Message}";
        }
    }

    [Serializable]
    public class CreateEntityError : Exception
    {
        public CreateEntityError() : base() { }
        public CreateEntityError(string message) : base(message) { }
        public CreateEntityError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"CreateMovieError: {Message}";
        }
    }

    [Serializable]
    public class PaginatorException : Exception
    {
        public PaginatorException() : base() { }
        public PaginatorException(string message) : base(message) { }
        public PaginatorException(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"PaginatorException: {Message}";
        }
    }

    [Serializable]
    public class InvalidException : Exception
    {
        public InvalidException() : base() { }
        public InvalidException(string message) : base(message) { }
        public InvalidException(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"InvalidInterpretationException: {Message}";
        }
    }

    [Serializable]
    public class TransformationException : Exception
    {
        public TransformationException() : base() { }
        public TransformationException(string message) : base(message) { }
        public TransformationException(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"TransformationException: {Message}";
        }
    }

    [Serializable]
    public class ReadEntityError : Exception
    {
        public ReadEntityError() : base() { }
        public ReadEntityError(string message) : base(message) { }
        public ReadEntityError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"ReadMovieError: {Message}";
        }
    }

    [Serializable]
    public class GetTotalEntitiesError : Exception
    {
        public GetTotalEntitiesError() : base() { }
        public GetTotalEntitiesError(string message) : base(message) { }
        public GetTotalEntitiesError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"GetTotalMoviesError: {Message}";
        }
    }

    [Serializable]
    public class GetAllEntitiesError : Exception
    {
        public GetAllEntitiesError() : base() { }
        public GetAllEntitiesError(string message) : base(message) { }
        public GetAllEntitiesError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"GetAllMoviesError: {Message}";
        }
    }

    [Serializable]
    public class AuthException : Exception
    {
        public AuthException() : base() { }
        public AuthException(string message) : base(message) { }
        public AuthException(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"AuthException: {Message}";
        }
    }

    [Serializable]
    public class RegistrationException : Exception
    {
        public RegistrationException() : base() { }
        public RegistrationException(string message) : base(message) { }
        public RegistrationException(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"RegistrationException: {Message}";
        }
    }
    [Serializable]
    public class UserServiceException : Exception
    {
        public UserServiceException() : base() { }
        public UserServiceException(string message) : base(message) { }
        public UserServiceException(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"UserServiceException: {Message}";
        }
    }

    [Serializable]
    public class UserAuthenticationException : UserServiceException
    {
        public UserAuthenticationException() : base() { }
        public UserAuthenticationException(string message) : base(message) { }
        public UserAuthenticationException(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"UserAuthenticationException: {Message}";
        }
    }

    [Serializable]
    public class ReadReviewError : Exception
    {
        public ReadReviewError() : base() { }
        public ReadReviewError(string message) : base(message) { }
        public ReadReviewError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"ReadReviewError: {Message}";
        }
    }

    [Serializable]
    public class GetAllReviewsError : Exception
    {
        public GetAllReviewsError() : base() { }
        public GetAllReviewsError(string message) : base(message) { }
        public GetAllReviewsError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"GetAllReviewsError: {Message}";
        }
    }

    [Serializable]
    public class GetReviewsPageError : Exception
    {
        public GetReviewsPageError() : base() { }
        public GetReviewsPageError(string message) : base(message) { }
        public GetReviewsPageError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"GetReviewsPageError: {Message}";
        }
    }

    [Serializable]
    public class GetReviewsByMovieIdError : Exception
    {
        public GetReviewsByMovieIdError() : base() { }
        public GetReviewsByMovieIdError(string message) : base(message) { }
        public GetReviewsByMovieIdError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"GetReviewsByMovieIdError: {Message}";
        }
    }

    [Serializable]
    public class CreateReviewError : Exception
    {
        public CreateReviewError() : base() { }
        public CreateReviewError(string message) : base(message) { }
        public CreateReviewError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"CreateReviewError: {Message}";
        }
    }

    [Serializable]
    public class UpdateReviewError : Exception
    {
        public UpdateReviewError() : base() { }
        public UpdateReviewError(string message) : base(message) { }
        public UpdateReviewError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"UpdateReviewError: {Message}";
        }
    }

    [Serializable]
    public class DeleteReviewError : Exception
    {
        public DeleteReviewError() : base() { }
        public DeleteReviewError(string message) : base(message) { }
        public DeleteReviewError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"DeleteReviewError: {Message}";
        }
    }

    [Serializable]
    public class GetTotalReviewsError : Exception
    {
        public GetTotalReviewsError() : base() { }
        public GetTotalReviewsError(string message) : base(message) { }
        public GetTotalReviewsError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"GetTotalReviewsError: {Message}";
        }
    }

    [Serializable]
    public class ReadInterpretationError : Exception
    {
        public ReadInterpretationError() : base() { }
        public ReadInterpretationError(string message) : base(message) { }
        public ReadInterpretationError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"ReadInterpretationError: {Message}";
        }
    }

    [Serializable]
    public class GetAllInterpretationsError : Exception
    {
        public GetAllInterpretationsError() : base() { }
        public GetAllInterpretationsError(string message) : base(message) { }
        public GetAllInterpretationsError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"GetAllInterpretationsError: {Message}";
        }
    }

    [Serializable]
    public class GetInterpretationsPageError : Exception
    {
        public GetInterpretationsPageError() : base() { }
        public GetInterpretationsPageError(string message) : base(message) { }
        public GetInterpretationsPageError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"GetInterpretationsPageError: {Message}";
        }
    }

    [Serializable]
    public class GetInterpretationsByMovieIdError : Exception
    {
        public GetInterpretationsByMovieIdError() : base() { }
        public GetInterpretationsByMovieIdError(string message) : base(message) { }
        public GetInterpretationsByMovieIdError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"GetInterpretationsByMovieIdError: {Message}";
        }
    }

    [Serializable]
    public class CreateInterpretationError : Exception
    {
        public CreateInterpretationError() : base() { }
        public CreateInterpretationError(string message) : base(message) { }
        public CreateInterpretationError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"CreateInterpretationError: {Message}";
        }
    }

    [Serializable]
    public class UpdateInterpretationError : Exception
    {
        public UpdateInterpretationError() : base() { }
        public UpdateInterpretationError(string message) : base(message) { }
        public UpdateInterpretationError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"UpdateInterpretationError: {Message}";
        }
    }

    [Serializable]
    public class DeleteInterpretationError : Exception
    {
        public DeleteInterpretationError() : base() { }
        public DeleteInterpretationError(string message) : base(message) { }
        public DeleteInterpretationError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"DeleteInterpretationError: {Message}";
        }
    }

    [Serializable]
    public class GetTotalInterpretationsError : Exception
    {
        public GetTotalInterpretationsError() : base() { }
        public GetTotalInterpretationsError(string message) : base(message) { }
        public GetTotalInterpretationsError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"GetTotalInterpretationsError: {Message}";
        }
    }

    [Serializable]
    public class CreateMovieError : Exception
    {
        public CreateMovieError() : base() { }
        public CreateMovieError(string message) : base(message) { }
        public CreateMovieError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"CreateMovieError: {Message}";
        }
    }

    [Serializable]
    public class UpdateMovieError : Exception
    {
        public UpdateMovieError() : base() { }
        public UpdateMovieError(string message) : base(message) { }
        public UpdateMovieError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"UpdateMovieError: {Message}";
        }
    }

    [Serializable]
    public class DeleteMovieError : Exception
    {
        public DeleteMovieError() : base() { }
        public DeleteMovieError(string message) : base(message) { }
        public DeleteMovieError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"DeleteMovieError: {Message}";
        }
    }

    [Serializable]
    public class GetMovieError : Exception
    {
        public GetMovieError() : base() { }
        public GetMovieError(string message) : base(message) { }
        public GetMovieError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"GetMovieError: {Message}";
        }
    }

    [Serializable]
    public class GetAllMoviesError : Exception
    {
        public GetAllMoviesError() : base() { }
        public GetAllMoviesError(string message) : base(message) { }
        public GetAllMoviesError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"GetAllMoviesError: {Message}";
        }
    }

    [Serializable]
    public class GetTotalMoviesError : Exception
    {
        public GetTotalMoviesError() : base() { }
        public GetTotalMoviesError(string message) : base(message) { }
        public GetTotalMoviesError(string message, Exception innerException) : base(message, innerException) { }

        public override string ToString()
        {
            return $"GetTotalMoviesError: {Message}";
        }
    }
}
