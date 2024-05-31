using DTOs;
using LogicClassLibrary.Helpers;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Interface.Service;

namespace LogicClassLibrary.Service_Classes
{
    internal class UserService : IUserService
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
            userManager.ChangePassword(username, newPassword);
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

        public void Update(int id, string username, string email, string firstName, string lastName, string profilePictureURL, string settings)
        {
            UserDTO userDto = new UserDTO(id, username, email, firstName, lastName, profilePictureURL, settings);
            userManager.Update(userDto);
        }

        public void Create(string username, string email, string password, string firstName, string lastName, string profilePictureURL, string settings)
        {
            string passwordSalt = PasswordHelper.GenerateSalt();
            string passwordHash = PasswordHelper.HashPassword(password, passwordSalt);
            UserDTO userDto = new UserDTO(0, username, email, passwordHash, passwordSalt, firstName, lastName, profilePictureURL, settings, new List<MovieDTO>(), new List<MovieDTO>());
            userManager.Create(userDto);
        }

        public void RegisterUser(string username, string email, string password, string firstName, string lastName)
        {
            userManager.RegisterUser(username, email, password, firstName, lastName);
        }
    }
}

