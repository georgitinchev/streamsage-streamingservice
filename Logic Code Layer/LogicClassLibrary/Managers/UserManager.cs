using DataAccessLibrary;
using DTOs;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Helpers;
using LogicClassLibrary.Interface.Manager;

namespace LogicClassLibrary.Managers
{
    public class UserManager : GeneralManager<UserDTO, User>, IUserManager
    {
        public IUserDAL? userDAL { get; private set; }
        public IMovieManager movieManager { get; private set; }
        public List<User> users { get; private set; } = new List<User>();

        public UserManager(IUserDAL userDAL, IMovieManager movieManager)
        {
            this.userDAL = userDAL;
            this.movieManager = movieManager;
            this.users = userDAL.ReadAllUsers().Select(u => TransformDTOToEntity(u)).ToList();
        }

        public override void Create(UserDTO userDTO)
        {
            string passwordSalt = PasswordHelper.GenerateSalt();
            string passwordHash = PasswordHelper.HashPassword(userDTO.PasswordHash, passwordSalt);
            userDTO.PasswordHash = passwordHash;
            userDTO.PasswordSalt = passwordSalt;
            var user = TransformDTOToEntity(userDTO);
            users.Add(user);
            if (userDAL != null)
            {
                userDAL.CreateUser(userDTO);
            }
        }

        public override void Delete(int id)
        {
            var user = users.Find(x => x.Id == id);
            if (user != null)
            {
                users.Remove(user);
                userDAL.DeleteUser(id);
            }
        }

        public override void Update(UserDTO dto)
        {
            var user = users.Find(x => x.Id == dto.Id);
            if (user != null)
            {
                var favoriteMovies = dto.FavoriteMovies?.Select(m => new Movie(m.Id, m.Title ?? string.Empty, m.ReleaseDate, m.Description ?? string.Empty, m.PosterImageURL ?? string.Empty, m.TrailerURL ?? string.Empty, m.RuntimeMinutes, m.AverageRating, m.Genres ?? new List<string>(), m.Directors ?? new List<string>(), m.Actors ?? new List<string>())).ToList();
                var watchList = dto.WatchList?.Select(m => new Movie(m.Id, m.Title ?? string.Empty, m.ReleaseDate, m.Description ?? string.Empty, m.PosterImageURL ?? string.Empty, m.TrailerURL ?? string.Empty, m.RuntimeMinutes, m.AverageRating, m.Genres ?? new List<string>(), m.Directors ?? new List<string>(), m.Actors ?? new List<string>())).ToList();
                var recentlyWatched = dto.RecentlyWatchedMovieIds ?? new List<int>();
                user.Update(dto.Username, dto.Email, dto.FirstName, dto.LastName, dto.ProfilePictureURL, TransformDTOToEntity(dto.Settings), favoriteMovies, watchList, recentlyWatched);
                user.SetPasswordHashAndSalt(dto.PasswordHash ?? string.Empty, dto.PasswordSalt ?? string.Empty);
                userDAL.UpdateUser(TransformEntityToDTO(user));
            }
        }
        public int GetTotalUsers()
        {
            return userDAL.GetTotalUsers();
        }
        public List<UserDTO> GetAllUsers()
        {
            var userDTOs = userDAL.ReadAllUsers();
            return userDTOs;
        }

        public override UserDTO Read(int id)
        {
            var user = users.Find(x => x.Id == id);
            return TransformEntityToDTO(user);
        }

        public UserDTO Read(string username)
        {
            var user = users.Find(x => x.Username == username);
            return TransformEntityToDTO(user);
        }
        public void AuthenticateUser(string username, string password)
        {
            UserDTO userDto = userDAL.GetUserByUsername(username);
            if (userDto == null)
            {
                throw new System.Exception("User not found.");
            }

            if (!PasswordHelper.VerifyPassword(password, userDto.PasswordHash, userDto.PasswordSalt))
            {
                throw new System.Exception("Invalid password.");
            }
        }

        public void RegisterUser(string username, string email, string password, string firstName, string lastName, UserSettings settings)
        {
            if (users.Any(u => u.Username == username))
            {
                throw new SystemException("Username already exists");
            }
            var passwordSalt = PasswordHelper.GenerateSalt();
            var passwordHash = PasswordHelper.HashPassword(password, passwordSalt);
            var user = new User(0, username, string.Empty, email, firstName, lastName, string.Empty, settings, new List<Movie>(), new List<Movie>(), new List<int>());
            user.SetPasswordHashAndSalt(passwordHash, passwordSalt);
            users.Add(user);
            userDAL.CreateUser(TransformEntityToDTO(user));
        }

        public void ChangePassword(string username, string newPasswordHash, string newPasswordSalt)
        {
            UserDTO userDto = Read(username);
            userDto.PasswordHash = newPasswordHash;
            userDto.PasswordSalt = newPasswordSalt;
            Update(userDto);
        }

        public List<User> GetUsersPage(int pageNumber, int pageSize)
        {
            var userDTOs = userDAL?.GetUsersPage(pageNumber, pageSize);
            return userDTOs.Select(TransformDTOToEntity).ToList();
        }

        public override User? TransformDTOToEntity(UserDTO dto)
        {
            if (dto == null) return null;

            var favoriteMovies = dto.FavoriteMovies?.Select(m => new Movie(m.Id, m.Title ?? string.Empty, m.ReleaseDate, m.Description ?? string.Empty, m.PosterImageURL ?? string.Empty, m.TrailerURL ?? string.Empty, m.RuntimeMinutes, m.AverageRating, m.Genres ?? new List<string>(), m.Directors ?? new List<string>(), m.Actors ?? new List<string>())).ToList();
            var watchList = dto.WatchList?.Select(m => new Movie(m.Id, m.Title ?? string.Empty, m.ReleaseDate, m.Description ?? string.Empty, m.PosterImageURL ?? string.Empty, m.TrailerURL ?? string.Empty, m.RuntimeMinutes, m.AverageRating, m.Genres ?? new List<string>(), m.Directors ?? new List<string>(), m.Actors ?? new List<string>())).ToList();

            var user = new User(
                dto.Id,
                dto.Username,
                string.Empty, 
                dto.Email,
                dto.FirstName,
                dto.LastName,
                dto.ProfilePictureURL,
                settings: TransformDTOToEntity(dto.Settings),
                favoriteMovies ?? new List<Movie>(),
                watchList ?? new List<Movie>(),
                recentlyWatchedMovieIds: dto.RecentlyWatchedMovieIds ?? new List<int>()

            );
            user.SetPasswordHashAndSalt(dto.PasswordHash ?? string.Empty, dto.PasswordSalt ?? string.Empty);
            return user;
        }

        public override UserDTO TransformEntityToDTO(User entity)
        {
            if (entity == null) return null;

            var favoriteMovies = entity.FavoriteMovies?.Select(m => new MovieDTO(m.Id, m.Title ?? string.Empty, m.Year, m.Description ?? string.Empty, m.PosterImageURL ?? string.Empty, m.TrailerURL ?? string.Empty, m.RuntimeMinutes, m.AverageRating, m.Genres ?? new List<string>(), m.Actors ?? new List<string>(), m.Directors ?? new List<string>())).ToList();
            var watchList = entity.WatchList?.Select(m => new MovieDTO(m.Id, m.Title ?? string.Empty, m.Year, m.Description ?? string.Empty, m.PosterImageURL ?? string.Empty, m.TrailerURL ?? string.Empty, m.RuntimeMinutes, m.AverageRating, m.Genres ?? new List<string>(), m.Actors ?? new List<string>(), m.Directors ?? new List<string>())).ToList();

            return new UserDTO(
                entity.Id,
                entity.Username,
                entity.Email,
                entity.GetPasswordHash(),
                entity.GetPasswordSalt(),
                entity.FirstName,
                entity.LastName,
                entity.ProfilePictureURL,
                settings: TransformEntityToDTO(entity.Settings),
                favoriteMovies ?? new List<MovieDTO>(),
                watchList ?? new List<MovieDTO>(),
                recentlyWatchedMovieIds: entity.RecentlyWatchedMovieIds
            );
        }

        public void AddToRecentlyWatched(int userId, int movieId)
        {
            userDAL?.AddMovieToRecentlyWatched(userId, movieId);
        }

        public void AddToWatchlist(int userId, int movieId)
        {
            userDAL?.AddMovieToWatchlist(userId, movieId);
        }

        public void AddToFavorites(int userId, int movieId)
        {
            userDAL?.AddMovieToFavorites(userId, movieId);
        }

        public UserSettings? TransformDTOToEntity(UserSettingsDTO? dto)
        {
            if (dto == null) return null;

            return new UserSettings(dto.Role);
        }

        public UserSettingsDTO? TransformEntityToDTO(UserSettings? entity)
        {
            if (entity == null) return null;

            return new UserSettingsDTO
            {
                Role = entity.Role
            };
        }
    }
}
