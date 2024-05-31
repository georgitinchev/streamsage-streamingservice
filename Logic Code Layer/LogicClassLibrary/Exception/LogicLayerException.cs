namespace LogicClassLibrary.Exception
{
    // represents errors that occur in the logic layer of the application
    public class LogicLayerException : System.Exception
    {
        // constructor that takes a message as a parameter 
        public LogicLayerException(string message) : base(message) { }
        // constructor that takes a message and an inner exception as parameters
        public LogicLayerException(string message, System.Exception inner) : base(message, inner) { }
    }

    public class MovieNotFoundException : LogicLayerException
    {
        public MovieNotFoundException(int movieId)
            : base($"Movie with ID {movieId} not found.") { }
    }

    public class InvalidGenreException : LogicLayerException
    {
        public InvalidGenreException()
            : base("A movie must have 1 to 3 genres") { }
    }

    public class PopulatingMoviesError : LogicLayerException
    {
        public PopulatingMoviesError()
            : base("Error populating movies.") { }
    }

    public class SearchCriteriaError : LogicLayerException
    {
        public SearchCriteriaError()
            : base("Search criteria error, criteria must be atleast 5 characters.") { }
    }

    public class UpdateMovieError : LogicLayerException
    {
        public UpdateMovieError()
            : base("Error updating movie.") { }
    }

    public class DeleteMovieError : LogicLayerException
    {
        public DeleteMovieError(int id)
            : base($"Error deleting movie with ID {id}.") { }
    }
    public class CreateMovieError : LogicLayerException
    {
        public CreateMovieError()
            : base("Error creating movie.") { }
    }
    public class UserNotFoundException : LogicLayerException
    {
        public UserNotFoundException(int userId)
            : base($"User with ID {userId} not found.") { }
    }

    public class ReviewNotFoundException : LogicLayerException
    {
        public ReviewNotFoundException(int reviewId)
            : base($"Review with ID {reviewId} not found.") { }
    }

    public class InterpretationNotFoundException : LogicLayerException
    {
        public InterpretationNotFoundException(int interpretationId)
            : base($"Interpretation with ID {interpretationId} not found.") { }
    }
}
