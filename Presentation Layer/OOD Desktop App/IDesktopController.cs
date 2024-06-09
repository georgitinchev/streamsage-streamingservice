using DTOs;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp
{
    public interface IDesktopController
    {
        // Interfaces instances
        IUserService UserService { get; }
        IMovieService MovieService { get; }
        IReviewService ReviewService { get; }
        IInterpretationService InterpretationService { get; }

        // User related methods
        List<UserDTO> GetUserPage(int pageNumber, int pageSize);
        List<UserDTO> GetAllUsers();
        void LoginUser(string username, string password);
        void RegisterUser(string username, string email, string password, string firstName, string lastName);
        UserDTO GetUserById(int id);
        void ChangeUserPassword(string username, string newPassword);
        void UpdateUser(UserDTO user);
        void DeleteUser(int id);

        // Movie related methods
        List<MovieDTO> GetMoviesPage(int pageNumber, int pageSize);
        List<MovieDTO> GetAllMovies();
        MovieDTO GetMovieById(int id);
        void UpdateMovie(MovieDTO movie);
        void DeleteMovie(int id);

        // Review related methods
        List<ReviewDTO> GetAllReviews();
        ReviewDTO GetReviewById(int id);
        void UpdateReview(ReviewDTO review);
        void DeleteReview(int id);
        int GetTotalReviews();

        // Interpretation related methods
        List<InterpretationDTO> GetAllInterpretations();
        InterpretationDTO GetInterpretationById(int id);
        void UpdateInterpretation(InterpretationDTO interpretation);
        void DeleteInterpretation(int id);

        // Other methods
        int GetTotalUsers();
        int GetTotalMovies();

        // Pagination methods
        int GetPageSize();
        void UpdatePageSize(int newPageSize);   
    }
}
