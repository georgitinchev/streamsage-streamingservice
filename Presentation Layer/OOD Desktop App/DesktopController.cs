using DTOs;
using LogicClassLibrary.Interface.Service;

namespace DesktopApp
{
    public class DesktopController
    {
        public IUserService userService { get; private set; }
        public IMovieService movieService { get; private set; }
        public IReviewService reviewService { get; private set; }
        public IInterpretationService interpretationService { get; private set; }

        public DesktopController(IUserService userService, IMovieService movieService, IReviewService reviewService, IInterpretationService interpretationService)
        {
            this.userService = userService;
            this.movieService = movieService;
            this.reviewService = reviewService;
            this.interpretationService = interpretationService;
        }
        public void displayHomePage()
        {

        }
        public List<MovieDTO> displayMoviePage()
        {
            if (movieService != null)
            {
                return movieService.GetAllMovies();
            }
            return new List<MovieDTO>();
        }

        public List<UserDTO> displayUserPage()
        {
            if (userService != null)
            {
                return userService.GetAllUsers();
            }
            return new List<UserDTO>();
        }
        public void loginUser(string username, string password)
        {
            try
            {
                userService.AuthenticateUser(username, password);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public void registerUser(string username, string email, string password, string firstName, string lastName)
        {
            userService?.Create(username, email, password, firstName, lastName, string.Empty);
        }
        public void changeUserPassword(string username, string newPassword)
        {
            userService?.ChangePassword(username, newPassword);
        }
    }
}