using DTOs;

namespace LogicClassLibrary.Interface.Service
{
    public interface IUserService
    {
        UserDTO Read(int id);
        UserDTO Read(string username);
        void Delete(int id);
        void Update(int id, string username, string email, string firstName, string lastName, UserSettingsDTO settings);
        void Create(string username, string email, string password, string firstName, string lastName, UserSettingsDTO settings);
        void ChangePassword(string username, string newPassword);
        void AuthenticateUser(string username, string password);
        List<UserDTO> GetAllUsers();
        List<UserDTO> GetUsersPage(int pageNumber, int pageSize);
        int GetTotalUsers();
        void AddToRecentlyWatched(int userId, int movieId);
        void AddToWatchlist(int userId, int movieId);
        void AddToFavorites(int userId, int movieId);
        void RemoveFromWatchlist(int userId, int movieId);
        void RemoveFromFavorites(int userId, int movieId);
        void UpdateProfilePicture(int userId, byte[] profilePicture);
    }
}
