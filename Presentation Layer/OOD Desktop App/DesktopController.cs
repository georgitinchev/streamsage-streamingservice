using DesktopApp.Exception;
using DTOs;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Interface.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DesktopApp
{
    public class DesktopController : IDesktopController
    {
        // Service Layer Interface Inversion
        public IUserService UserService { get; private set; }
        public IMovieService MovieService { get; private set; }
        public IReviewService ReviewService { get; private set; }
        public IInterpretationService InterpretationService { get; private set; }


        // page size of the application
        private int pageSize = 25;

        // Dependency Injection of service interfaces
        public DesktopController(IUserService userService, IMovieService movieService, IReviewService reviewService, IInterpretationService interpretationService)
        {
            this.UserService = userService;
            this.MovieService = movieService;
            this.ReviewService = reviewService;
            this.InterpretationService = interpretationService;
        }

        // Page size methods
        public int GetPageSize()
        {
            return pageSize;
        }
        public void UpdatePageSize(int newPageSize)
        {
            pageSize = newPageSize;
        }

        // Get Total Entity Methods
        public int GetTotalUsers()
        {
            return UserService.GetTotalUsers();
        }

        public int GetTotalMovies()
        {
            return MovieService.GetTotalMovies();
        }

        // User Methods

        public void LoginUser(string username, string password)
        {
            try
            {
                UserService.AuthenticateUser(username, password);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void RegisterUser(string username, string email, string password, string firstName, string lastName)
        {
            var userSettings = new UserSettingsDTO();
            UserService?.Create(username, email, password, firstName, lastName, userSettings);
        }

        public List<UserDTO> GetUserPage(int pageNumber, int pageSize)
        {
            return UserService.GetUsersPage(pageNumber, pageSize);
        }

        public void ChangeUserPassword(string username, string newPassword)
        {
            UserService?.ChangePassword(username, newPassword);
        }

        public List<UserDTO> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public UserDTO GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        // Movies Methods 
        public List<MovieDTO> GetMoviesPage(int pageNumber, int pageSize)
        {
            return MovieService.GetMoviesPage(pageNumber, pageSize);
        }

        public List<MovieDTO> GetAllMovies()
        {
            return MovieService.GetAllMovies();
        }

        public MovieDTO GetMovieById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateMovie(MovieDTO movie)
        {
            throw new NotImplementedException();
        }

        public void DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

        // Review Methods

        public List<ReviewDTO> GetReviewPage(int pageNumber, int pageSize)
        {
            return ReviewService.GetReviewsPage(pageNumber, pageSize);
        }
        public List<ReviewDTO> GetAllReviews()
        {
            return ReviewService.GetAllReviews();
        }

        public ReviewDTO GetReviewById(int id)
        {
            return ReviewService.GetReview(id);
        }

        public void UpdateReview(ReviewDTO review)
        {
            ReviewService.UpdateReview(review);
        }

        public void DeleteReview(int id)
        {
            ReviewService.DeleteReview(id);
        }
        public int GetTotalReviews()
        {
            return ReviewService.GetTotalReviews();
        }

        // Interpretation Methods

        public int GetTotalInterpretations()
        {
            return InterpretationService.GetTotalInterpretationsCount();
        }

        public List<InterpretationDTO> GetAllInterpretations()
        {
            throw new NotImplementedException();
        }

        public InterpretationDTO GetInterpretationById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateInterpretation(InterpretationDTO interpretation)
        {
            throw new NotImplementedException();
        }

        public void DeleteInterpretation(int id)
        {
            throw new NotImplementedException();
        }
    }
}
