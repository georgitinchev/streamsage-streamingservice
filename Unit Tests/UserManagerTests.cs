using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using LogicClassLibrary.Managers;
using DataAccessLibrary;
using DTOs;
using System.Collections.Generic;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Helpers;
using LogicClassLibrary.Interface.Helpers;

namespace UnitTests
{
    [TestClass]
    public class UserManagerTests
    {
        private Mock<IUserDAL>? mockUserDAL;
        private UserManager? userManager;
        private Mock<IMovieManager>? mockMovieManager;
        private Mock<IPasswordHelper> mockPasswordHelper;

        [TestInitialize]
        public void TestInitialize()
        {
            mockUserDAL = new Mock<IUserDAL>();
            mockMovieManager = new Mock<IMovieManager>();
            mockPasswordHelper = new Mock<IPasswordHelper>(); 

            var users = new List<UserDTO>
    {
        new UserDTO(1, "georgi.tin", "georgi.tinchev.124@gmail.com")
    };

            mockUserDAL.Setup(m => m.ReadAllUsers()).Returns(users);

            userManager = new UserManager(mockUserDAL.Object, mockMovieManager.Object, mockPasswordHelper.Object); // Change this line
        }

        [TestMethod]
        public void GetAllUsers_ReturnsAllUsers()
        {
            var users = new List<UserDTO>
            {
                new UserDTO(1, "user1", "email1"),
                new UserDTO(2, "user2", "email2")
            };

            mockUserDAL.Setup(m => m.ReadAllUsers()).Returns(users);

            var result = userManager.GetAllUsers();

            Assert.IsNotNull(result);
            Assert.AreEqual(users.Count, result.Count);
        }

        [TestMethod]
        public void Read_ValidId_ReturnsUser()
        {
            var user = new UserDTO(1, "georgi.tin", "georgi.tinchev.124@gmail.com");

            mockUserDAL.Setup(m => m.GetUserById(1)).Returns(user);

            var result = userManager.Read(1);

            Assert.IsNotNull(result);
            Assert.AreEqual(user.Id, result.Id);
            Assert.AreEqual(user.Username, result.Username);
        }

        [TestMethod]
        public void Create_ValidUser_CallsCreateUser()
        {
            var user = new UserDTO(1, "user1", "email1");

            userManager.Create(user);

            mockUserDAL.Verify(m => m.CreateUser(user), Times.Once);
        }

        [TestMethod]
        public void Update_ValidUser_CallsUpdateUser()
        {
            var user = new UserDTO(1, "georgi.tin", "georgi.tinchev.124@gmail.com");
            userManager.Create(user); 
            userManager.Update(user);
            mockUserDAL.Verify(m => m.UpdateUserWithoutPassword(It.Is<UserDTO>(u => u.Id == user.Id)), Times.Once); 
        }


        [TestMethod]

        public void Delete_ValidId_CallsDeleteUser()
        {
            userManager.Delete(1);

            mockUserDAL.Verify(m => m.DeleteUser(1), Times.Once);
        }

        [TestMethod]

        public void GetTotalUsers_ReturnsTotalUsers()
        {
            mockUserDAL.Setup(m => m.GetTotalUsers()).Returns(2);

            var result = userManager.GetTotalUsers();

            Assert.AreEqual(2, result);
        }

        [TestMethod]

        public void GetUsersPage_ReturnsUsersPage()
        {
            var users = new List<UserDTO>
            {
                new UserDTO(1, "user1", "email1"),
                new UserDTO(2, "user2", "email2")
            };

            mockUserDAL.Setup(m => m.GetUsersPage(1, 2)).Returns(users);

            var result = userManager.GetUsersPage(1, 2);

            Assert.IsNotNull(result);
            Assert.AreEqual(users.Count, result.Count);
        }

        [TestMethod]

        public void TransformDTOToEntity_ReturnsEntity()
        {
            var user = new UserDTO(1, "user1", "email1");

            var result = userManager.TransformDTOToEntity(user);

            Assert.IsNotNull(result);
            Assert.AreEqual(user.Id, result.Id);
            Assert.AreEqual(user.Username, result.Username);
        }

        [TestMethod]
        public void TransformEntityToDTO_ReturnsDTO()
        {
            var user = new User(1, "user1", "passwordHash1", "passwordSalt1", "email1", null, null, null, null, new List<Movie>(), new List<int>(), mockPasswordHelper.Object); // Add mockPasswordHelper.Object as the last argument
            var result = userManager.TransformEntityToDTO(user);

            Assert.IsNotNull(result);
            Assert.AreEqual(user.Id, result.Id);
            Assert.AreEqual(user.Username, result.Username);
        }

        [TestMethod]
        public void RegisterUser_ValidUser_CreatesUser()
        {
            var userSettingsDTO = new UserSettingsDTO { Role = "User" };
            userManager.RegisterUser("newUser", "newUser@email.com", "password", "firstName", "lastName", userSettingsDTO);

            mockUserDAL.Verify(m => m.CreateUser(It.Is<UserDTO>(u => u.Username == "newUser")), Times.Once);
        }

        [TestMethod]
        public void ChangePassword_ValidUser_ChangesPassword()
        {

            var user = new UserDTO(1, "existingUser", "email1");
            mockUserDAL.Setup(m => m.GetUserByUsername("existingUser")).Returns(user);
            var newPasswordHash = "newPasswordHash";
            var newPasswordSalt = "newPasswordSalt";
            userManager.ChangePassword("existingUser", newPasswordHash, newPasswordSalt);
            mockUserDAL.Verify(m => m.ChangePassword(It.IsAny<int>(), newPasswordHash, newPasswordSalt), Times.Once);
        }

        [TestMethod]
        public void AuthenticateUser_ValidCredentials_AuthenticatesUser()
        {
            var user = new UserDTO(1, "user1", "email1");
            mockUserDAL.Setup(m => m.GetUserByUsername("user1")).Returns(user);
            mockPasswordHelper.Setup(m => m.VerifyPassword("password", user.PasswordHash, user.PasswordSalt)).Returns(true);

            userManager.AuthenticateUser("user1", "password");
            mockUserDAL.Verify(m => m.GetUserByUsername("user1"), Times.Once);
        }
    }
}
