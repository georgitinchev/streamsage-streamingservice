using DTOs;

namespace DataAccessLibrary
{
    public interface IUserDAL
    {
        List<UserDTO> ReadAllUsers();
        void CreateUser(UserDTO user);
        UserDTO GetUserByUsername(string username);
        void UpdateUser(UserDTO user);
        void DeleteUser(int userId);
        void ChangePassword(string username, string newPassword);
    }
}
