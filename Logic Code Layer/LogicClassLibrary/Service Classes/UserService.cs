using DTOs;
using LogicClassLibrary.Helpers;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Interface.Service;
using LogicClassLibrary.Managers;

namespace LogicClassLibrary.Service_Classes
{
    public class UserService : IUserService
    {
        private IUserManager userManager;

        public UserService(IUserManager userManager)
        {
            this.userManager = userManager;
        }

        public void AuthenticateUser(string username, string password)
        {
            userManager.AuthenticateUser(username, password);
        }

        public void ChangePassword(string username, string newPassword)
        {
            string newPasswordSalt = PasswordHelper.GenerateSalt();
            string newPasswordHash = PasswordHelper.HashPassword(newPassword, newPasswordSalt);
            userManager.ChangePassword(username, newPasswordHash, newPasswordSalt);
        }

        public void Delete(int id)
        {
            userManager.Delete(id);
        }

        public List<UserDTO> GetAllUsers()
        {
            return userManager.users.Select(user => userManager.TransformEntityToDTO(user)).ToList();
        }

        public UserDTO Read(int id)
        {
            return userManager.Read(id);
        }

        public UserDTO Read(string username)
        {
            return userManager.Read(username);
        }

        public void Update(int id, string username, string email, string firstName, string lastName, UserSettingsDTO settings)
        {
            UserDTO userDto = new UserDTO(id, username, email, firstName, lastName, settings);
            userManager.Update(userDto);
        }
        public void Create(string username, string email, string password, string firstName, string lastName, UserSettingsDTO settings)
        {
            var userSettings = userManager.TransformDTOToEntity(settings);
            userManager.RegisterUser(username, email, password, firstName, lastName, userSettings);
        }

        public void AddToRecentlyWatched(int userId, int movieId)
        {
            userManager.AddToRecentlyWatched(userId, movieId);
        }

        public void AddToWatchlist(int userId, int movieId)
        {
            userManager.AddToWatchlist(userId, movieId);
        }

        public void AddToFavorites(int userId, int movieId)
        {
            userManager.AddToFavorites(userId, movieId);
        }

        public int GetTotalUsers()
        {
            return userManager.GetTotalUsers();
        }

        public List<UserDTO> GetUsersPage(int pageNumber, int pageSize)
        {
          var users = userManager.GetUsersPage(pageNumber, pageSize);
          return users.Select(userManager.TransformEntityToDTO).ToList();
        }
    }
}
