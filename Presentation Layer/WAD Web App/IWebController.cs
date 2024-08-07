﻿using DTOs;
using LogicClassLibrary.Interface.Service;

namespace StreamSageWAD
{
    public interface IWebController
    {
        IMovieService MovieService { get; }
        IUserService UserService { get; }
        IReviewService ReviewService { get; }
        IInterpretationService InterpretationService { get; }
        IRecommendationService RecommendationService { get; }

        UserDTO loginUser(string username, string password);
        UserDTO registerUser(string username, string email, string password, string firstName, string lastName);
        void changePassword(string username, string newPassword);
        List<MovieDTO> GetMoviesByIds(List<int> movieIds);
        string GetDefaultUser();
    }
}
