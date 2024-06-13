using DTOs;
using LogicClassLibrary;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Interface.Service;
using LogicClassLibrary.Managers;

namespace StreamSageWAD
{
    public class WebController : IWebController
    {
        public IMovieService MovieService { get; private set; }
        public IUserService UserService { get; private set; }
        public IReviewService ReviewService { get; private set; }
        public IInterpretationService InterpretationService { get; private set; }
        public IRecommendationService RecommendationService { get; private set; }
        public WebController(IMovieService movieService, IUserService userService, IReviewService reviewService, IInterpretationService interpretationService, IRecommendationService recommendationService)
        {
            MovieService = movieService;
            UserService = userService;
            ReviewService = reviewService;
            InterpretationService = interpretationService;
            RecommendationService = recommendationService;
        }

        public UserDTO loginUser(string username, string password)
        {
            UserService.AuthenticateUser(username, password);
            var user = UserService.Read(username);
            if (user == null)
            {
                throw new StreamSageWAD.Exception.LoginFailedException("User could not be authenticated.");
            }
            return user;
        }

        public UserDTO registerUser(string username, string email, string password, string firstName, string lastName)
        {
            var userSettings = new UserSettingsDTO { Role = "User" };
            UserService.Create(username, email, password, firstName, lastName, userSettings);
            var user = UserService.Read(username);
            if (user == null)
            {
                throw new StreamSageWAD.Exception.RegistrationFailedException("User could not be created.");
            }
            return user;
        }

        public void changePassword(string username, string newPassword)
        {
            UserService.ChangePassword(username, newPassword);
        }

        public List<MovieDTO> GetMoviesByIds(List<int>? movieIds)
        {
            if (movieIds == null)
            {
                return null;
            }
            if (!movieIds.Any())
            {
                return new List<MovieDTO>();
            }
            return movieIds.Select(id => MovieService.GetMovie(id)).ToList();
        }

        (List<ReviewDTO>, List<InterpretationDTO>) GetReviewsAndInterpretationsByMovieId(int movieId)
        {
            var reviews = ReviewService.GetReviewsByMovieId(movieId);
            var interpretations = InterpretationService.GetInterpretationsByMovieId(movieId);
            return (reviews, interpretations);
        }

        public string GetDefaultUser()
        {
            return "georgi.tin";
        }

        public void logoutUser()
        {
            // Implement the method
            throw new NotImplementedException();
        }
    }
}
