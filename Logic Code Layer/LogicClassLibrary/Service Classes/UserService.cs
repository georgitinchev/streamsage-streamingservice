using DTOs;
using LogicClassLibrary.Helpers;
using LogicClassLibrary.Interface.Helpers;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Interface.Service;
using LogicClassLibrary.Managers;
using LogicClassLibrary.Exceptions;
using System;

namespace LogicClassLibrary.Service_Classes
{
    public class UserService : IUserService
    {
        private IUserManager userManager;
        private IPasswordHelper passwordHelper;

        public UserService(IUserManager userManager, IPasswordHelper passwordHelper)
        {
            this.userManager = userManager;
            this.passwordHelper = passwordHelper;
        }

        public void AuthenticateUser(string username, string password)
        {
            try
            {
                userManager.AuthenticateUser(username, password);
            }
            catch (AuthException ex)
            {
                throw new UserAuthenticationException("Failed to authenticate user.", ex);
            }
        }
        public List<UserDTO> SearchUsers(string searchQuery, string searchBy)
        {
            try
            {
                return userManager.SearchUsers(searchQuery, searchBy);
            }
            catch(SearchCriteriaError ex)
            {
                throw new UserServiceException("Failed to search users.", ex);
            }
        }

        public void ChangePassword(string username, string newPassword)
        {
            try
            {
                string newPasswordSalt = passwordHelper.GenerateSalt();
                string newPasswordHash = passwordHelper.HashPassword(newPassword, newPasswordSalt);
                userManager.ChangePassword(username, newPasswordHash, newPasswordSalt);
            }
            catch (Exception ex)
            {
                throw new UserServiceException("Failed to change password.", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                userManager.Delete(id);
            }
            catch (DeleteEntityError ex)
            {
                throw new UserServiceException("Failed to delete user.", ex);
            }
        }

        public List<UserDTO> GetAllUsers()
        {
            try
            {
                return userManager.GetAllUsers();
            }
            catch (GetAllEntitiesError ex)
            {
                throw new UserServiceException("Failed to get all users.", ex);
            }
        }

        public UserDTO Read(int id)
        {
            try
            {
                return userManager.Read(id);
            }
            catch (ReadEntityError ex)
            {
                throw new UserServiceException("Failed to read user.", ex);
            }
        }

        public UserDTO Read(string username)
        {
            try
            {
                return userManager.Read(username);
            }
            catch (ReadEntityError ex)
            {
                throw new UserServiceException("Failed to read user.", ex);
            }
        }

        public void UpdateProfilePicture(int userId, byte[] profilePicture)
        {
            try
            {
                userManager.UpdateProfilePicture(userId, profilePicture);
            }
            catch (UpdateEntityError ex)
            {
                throw new UserServiceException("Failed to update profile picture.", ex);
            }
        }

        public void Update(int id, string username, string email, string firstName, string lastName, UserSettingsDTO settings)
        {
            try
            {
                UserDTO userDto = new UserDTO(id, username, email, firstName, lastName, settings);
                userManager.Update(userDto);
            }
            catch (UpdateEntityError ex)
            {
                throw new UserServiceException("Failed to update user.", ex);
            }
        }

        public void Create(string username, string email, string password, string firstName, string lastName, UserSettingsDTO settings)
        {
            try
            {
                userManager.RegisterUser(username, email, password, firstName, lastName, settings);
            }
            catch (RegistrationException ex)
            {
                throw new UserServiceException("Failed to create user.", ex);
            }
        }

        public void AddToRecentlyWatched(int userId, int movieId)
        {
            try
            {
                userManager.AddToRecentlyWatched(userId, movieId);
            }
            catch (Exception ex)
            {
                throw new UserServiceException("Failed to add to recently watched.", ex);
            }
        }

        public void AddToWatchlist(int userId, int movieId)
        {
            try
            {
                userManager.AddToWatchlist(userId, movieId);
            }
            catch (Exception ex)
            {
                throw new UserServiceException("Failed to add to watchlist.", ex);
            }
        }

        public void AddToFavorites(int userId, int movieId)
        {
            try
            {
                userManager.AddToFavorites(userId, movieId);
            }
            catch (Exception ex)
            {
                throw new UserServiceException("Failed to add to favorites.", ex);
            }
        }
        public void RemoveFromWatchlist(int userId, int movieId)
        {
            try
            {
                userManager.RemoveFromWatchlist(userId, movieId);
            }
            catch (Exception ex)
            {
                throw new UserServiceException("Failed to remove from watchlist.", ex);
            }
        }
        public void RemoveFromFavorites(int userId, int movieId)
        {
            try
            {
                userManager.RemoveFromFavorites(userId, movieId);
            }
            catch (Exception ex)
            {
                throw new UserServiceException("Failed to remove from favorites.", ex);
            }
        }

        public int GetTotalUsers()
        {
            try
            {
                return userManager.GetTotalUsers();
            }
            catch (GetTotalEntitiesError ex)
            {
                throw new UserServiceException("Failed to get total users.", ex);
            }
        }

        public List<UserDTO> GetUsersPage(int pageNumber, int pageSize)
        {
            try
            {
                return userManager.GetUsersPage(pageNumber, pageSize);
            }
            catch (PaginatorException ex)
            {
                throw new UserServiceException("Failed to get users page.", ex);
            }
        }
    }
}
