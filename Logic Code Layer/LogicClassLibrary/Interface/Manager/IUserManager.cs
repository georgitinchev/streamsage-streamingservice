using DTOs;
using LogicClassLibrary.Entities;

namespace LogicClassLibrary.Interface.Manager
{
    public interface IUserManager
    {
        List<User> users { get; }
        void AuthenticateUser(string username, string password);
        void RegisterUser(string username, string email, string password, string firstName, string lastName, UserSettingsDTO userSettings);
        void ChangePassword(string username, string newPasswordHash, string newPasswordSalt);
        void Create(UserDTO userDTO);
        UserDTO Read(int id);
        UserDTO Read(string username);
        void Update(UserDTO dto);
        void Delete(int id);
        int GetTotalUsers();
        List<UserDTO> SearchUsers(string searchQuery, string searchParameter);
        List<UserDTO> GetAllUsers();
        List<UserDTO> GetUsersPage(int pageNumber, int pageSize);
        void AddToRecentlyWatched(int userId, int movieId);
        void AddToWatchlist(int userId, int movieId);
        void AddToFavorites(int userId, int movieId);
        void RemoveFromWatchlist(int userId, int movieId);
        void RemoveFromFavorites(int userId, int movieId);
		void UpdateProfilePicture(int userId, byte[] profilePicture);
		UserSettings? TransformDTOToEntity(UserSettingsDTO? dto);
        UserSettingsDTO? TransformEntityToDTO(UserSettings? entity);
    }
}
