using DataAccessLibrary;
using DataAccessLibrary.Exception;
using DTOs;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Exceptions;
using LogicClassLibrary.Helpers;
using LogicClassLibrary.Interface.Helpers;
using LogicClassLibrary.Interface.Manager;

namespace LogicClassLibrary.Managers
{
    public class UserManager : GeneralManager<UserDTO, User>, IUserManager
    {
        private readonly IPasswordHelper _passwordHelper;
        public IUserDAL? userDAL { get; private set; }
        public IMovieManager movieManager { get; private set; }
        public List<User> users { get; private set; } = new List<User>();

        public UserManager(IUserDAL userDAL, IMovieManager movieManager, IPasswordHelper passwordHelper)
        {
            _passwordHelper = passwordHelper;
            this.userDAL = userDAL;
            this.movieManager = movieManager;
            this.users = userDAL.ReadAllUsers().Select(u => TransformDTOToEntity(u)).ToList();
        }

        public override void Create(UserDTO userDTO)
        {
            try
            {
                string passwordSalt = _passwordHelper.GenerateSalt();
                string passwordHash = _passwordHelper.HashPassword(userDTO.PasswordHash, passwordSalt);
                userDTO.PasswordHash = passwordHash;
                userDTO.PasswordSalt = passwordSalt;
                var user = TransformDTOToEntity(userDTO);
                users.Add(user);
                if (userDAL != null)
                {
                    userDAL.CreateUser(userDTO);
                }
            }
            catch (DataAccessException e)
            {
                throw new CreateEntityError(e.Message);
            }
        }

        public List<UserDTO> SearchUsers(string searchQuery, string searchBy)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchBy))
                {
                    return userDAL?.SearchUsersAcrossAllFields(searchQuery);
                }
                else
                {
                return userDAL?.SearchUsers(searchQuery, searchBy) ?? new List<UserDTO>();
                }
            }
            catch (DataAccessException ex)
            {
                throw new SearchCriteriaError("Failed to search users.", ex);
            }
            catch (ArgumentException ex)
            {
                throw new SearchCriteriaError("Invalid search criteria.", ex);
            }
        }

        public override void Delete(int id)
        {
            try
            {
                var user = users.Find(x => x.Id == id);
                if (user != null)
                {
                    users.Remove(user);
                    userDAL.DeleteUser(id);
                }
            }
            catch (DataAccessException)
            {
                throw new DeleteEntityError();
            }
        }

        public override void Update(UserDTO dto)
        {
            try
            {
                var user = users.Find(x => x.Id == dto.Id);
                if (user != null)
                {
                    user.Update(dto.Username, dto.Email, dto.FirstName, dto.LastName, dto.ProfilePictureURL, TransformDTOToEntity(dto.Settings));
                    userDAL.UpdateUserWithoutPassword(TransformEntityToDTO(user));
                }
            }
            catch (DataAccessException e)
            {
                throw new UpdateEntityError(e.Message);
            }
        }

        public int GetTotalUsers()
        {
            try
            {
                return userDAL.GetTotalUsers();
            }
            catch (DataAccessException e)
            {
                throw new GetTotalEntitiesError(e.Message);
            }
        }
        public List<UserDTO> GetAllUsers()
        {
            try
            {
                var userDTOs = userDAL.ReadAllUsers();
                return userDTOs;
            }
            catch (DataAccessException e)
            {
                throw new GetAllEntitiesError(e.Message);
            }
        }

        public override UserDTO Read(int id)
        {
            try
            {
                var user = users.Find(x => x.Id == id);
                return TransformEntityToDTO(user);
            }
            catch (System.Exception e)
            {
                throw new ReadEntityError(e.Message);
            }
        }

        public UserDTO Read(string username)
        {
            try
            {
                var user = users.Find(x => x.Username == username);
                return TransformEntityToDTO(user);
            }
            catch (System.Exception e)
            {
                throw new ReadEntityError(e.Message);
            }
        }
        public void AuthenticateUser(string username, string password)
        {
            try
            {
                UserDTO userDto = userDAL.GetUserByUsername(username);
                if (userDto == null)
                {
                    throw new System.Exception("User not found.");
                }

                if (!_passwordHelper.VerifyPassword(password, userDto.PasswordHash, userDto.PasswordSalt))
                {
                    throw new System.Exception("Invalid password.");
                }
            }
            catch (DataAccessException e)
            {
                throw new AuthException(e.Message);
            }
        }

        public void RegisterUser(string username, string email, string password, string firstName, string lastName, UserSettingsDTO settingsDTO)
        {
            try
            {
                if (users.Any(u => u.Username == username))
                {
                    throw new SystemException("Username already exists");
                }
                var passwordSalt = _passwordHelper.GenerateSalt();
                var passwordHash = _passwordHelper.HashPassword(password, passwordSalt);
                var settings = TransformDTOToEntity(settingsDTO);
                var user = new User(0, username, passwordHash, passwordSalt, email, firstName, lastName, new byte[0], settings, new List<Movie>(), new List<Movie>(), new List<int>());
                users.Add(user);
                var userDTO = TransformEntityToDTO(user);
                var userId = userDAL.CreateUser(userDTO);
                user.UpdateId(userId);
            }
            catch (DataAccessException e)
            {
                throw new RegistrationException(e.Message);
            }
        }


        public void ChangePassword(string username, string newPasswordHash, string newPasswordSalt)
        {
            try
            {
                var userDTO = userDAL?.GetUserByUsername(username);
                userDAL?.ChangePassword(userDTO.Id, newPasswordHash, newPasswordSalt);
            }
            catch (DataAccessException e)
            {
                throw new AuthException(e.Message);
            }
        }

        public List<UserDTO> GetUsersPage(int pageNumber, int pageSize)
        {
            try
            {
                var userDTOs = userDAL?.GetUsersPage(pageNumber, pageSize);
                return userDTOs;
            }
            catch (DataAccessException e)
            {
                throw new PaginatorException(e.Message);
            }
        }

        public void AddToRecentlyWatched(int userId, int movieId)
        {
            try
            {
                userDAL?.AddMovieToRecentlyWatched(userId, movieId);
            }
            catch (DataAccessException e)
            {
                throw new CreateEntityError(e.Message);
            }
        }

        public void AddToWatchlist(int userId, int movieId)
        {
            try
            {
                var userDTO = userDAL.GetUserById(userId);
                if (userDTO != null && userDTO.WatchList != null && userDTO.WatchList.Count >= 20)
                {
                    throw new CreateEntityError("Watchlist cannot exceed 20 movies.");
                }
                userDAL?.AddMovieToWatchlist(userId, movieId);
            }
            catch (DataAccessException e)
            {
                throw new CreateEntityError(e.Message);
            }
        }

        public void AddToFavorites(int userId, int movieId)
        {
            try
            {
                var userDTO = userDAL.GetUserById(userId);
                if (userDTO != null && userDTO.FavoriteMovies != null && userDTO.FavoriteMovies.Count >= 20)
                {
                    throw new CreateEntityError("Favorites list cannot exceed 20 movies.");
                }
                userDAL?.AddMovieToFavorites(userId, movieId);
            }
            catch (DataAccessException e)
            {
                throw new CreateEntityError(e.Message);
            }
        }

        public void RemoveFromWatchlist(int userId, int movieId)
        {
            try
            {
                userDAL?.RemoveMovieFromWatchlist(userId, movieId);
            }
            catch (DataAccessException)
            {
                throw new DeleteEntityError();
            }
        }
        public void RemoveFromFavorites(int userId, int movieId)
        {
            try
            {
                userDAL?.RemoveMovieFromFavorites(userId, movieId);
            }
            catch (DataAccessException)
            {
                throw new DeleteEntityError();
            }
        }

        public void UpdateProfilePicture(int userId, byte[] profilePicture)
        {
            try
            {
                var user = users.Find(x => x.Id == userId);
                if (user != null)
                {
                    user.UpdateProfilePicture(profilePicture);
                    userDAL?.UpdateUserWithoutPassword(TransformEntityToDTO(user));
                }
            } catch (DataAccessException e)
            {
                   throw new UpdateEntityError(e.Message);
            }
        }
        public override User? TransformDTOToEntity(UserDTO dto)
        {
            try
            {
                if (dto == null) return null;

                var favoriteMovies = dto.FavoriteMovies?.Select(m => new Movie(m.Id, m.Title ?? string.Empty, m.ReleaseDate, m.Description ?? string.Empty, m.PosterImageURL ?? string.Empty, m.TrailerURL ?? string.Empty, m.RuntimeMinutes, m.AverageRating, m.Genres ?? new List<string>(), m.Directors ?? new List<string>(), m.Actors ?? new List<string>())).ToList();
                var watchList = dto.WatchList?.Select(m => new Movie(m.Id, m.Title ?? string.Empty, m.ReleaseDate, m.Description ?? string.Empty, m.PosterImageURL ?? string.Empty, m.TrailerURL ?? string.Empty, m.RuntimeMinutes, m.AverageRating, m.Genres ?? new List<string>(), m.Directors ?? new List<string>(), m.Actors ?? new List<string>())).ToList();

                var user = new User(
                    dto.Id,
                    dto.Username,
                    dto.PasswordHash ?? string.Empty,
                    dto.PasswordSalt ?? string.Empty,
                    dto.Email,
                    dto.FirstName,
                    dto.LastName,
                    dto.ProfilePictureURL,
                    settings: TransformDTOToEntity(dto.Settings),
                    favoriteMovies ?? new List<Movie>(),
                    watchList ?? new List<Movie>(),
                    recentlyWatchedMovieIds: dto.RecentlyWatchedMovieIds ?? new List<int>()
                );

                return user;
            }
            catch (System.Exception e)
            {
                throw new InvalidException(e.Message);
            }
        }


        public override UserDTO? TransformEntityToDTO(User entity)
        {
            try
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
            catch (System.Exception e)
            {
                throw new InvalidException(e.Message);
            }
        }

        public UserSettings? TransformDTOToEntity(UserSettingsDTO? dto)
        {
            try
            {
                if (dto == null) return null;
                return new UserSettings(dto.Role);
            }
            catch (System.Exception e)
            {
                throw new InvalidException(e.Message);
            }
        }

        public UserSettingsDTO? TransformEntityToDTO(UserSettings? entity)
        {
            try
            {
                if (entity == null) return null;
                return new UserSettingsDTO
                {
                    Role = entity.Role
                };
            }
            catch (System.Exception e)
            {
                throw new InvalidException(e.Message);
            }
        }
    }
}
