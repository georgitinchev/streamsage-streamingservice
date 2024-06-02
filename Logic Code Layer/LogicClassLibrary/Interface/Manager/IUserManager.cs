using DTOs;
using LogicClassLibrary.Entities;

namespace LogicClassLibrary.Interface.Manager
{
    public interface IUserManager
    {
        void AuthenticateUser(string username, string password);
        void RegisterUser(string username, string email, string password, string firstName, string lastName);
        void ChangePassword(string username, string newPasswordHash, string newPasswordSalt);
        void Create(UserDTO userDTO);
        UserDTO Read(int id);
        UserDTO Read(string username);
        void Update(UserDTO dto);
        void Delete(int id);
        UserDTO TransformEntityToDTO(User user);
        List<User> users { get; }
    }
}
