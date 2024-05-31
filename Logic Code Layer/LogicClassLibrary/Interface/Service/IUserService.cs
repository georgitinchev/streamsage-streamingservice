using DTOs;

namespace LogicClassLibrary.Interface.Service
{
    public interface IUserService
    {
        UserDTO Read(int id);
        UserDTO Read(string username);
        void Delete(int id);
        void Update(int id, string username, string email, string firstName, string lastName, string profilePictureURL, string settings);
        void Create(string username, string email, string password, string firstName, string lastName, string profilePictureURL, string settings);
        void ChangePassword(string username, string newPassword);
        void AuthenticateUser(string username, string password);
        void RegisterUser(string username, string email, string password, string firstName, string lastName);
        List<UserDTO> GetAllUsers();
    }
}
