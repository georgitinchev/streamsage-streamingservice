using Xunit;
using Moq;
using System.Data;
using System.Data.SqlClient;
using LogicClassLibrary.Helpers;
using DataAccessLibrary;
using DTOs;

namespace UnitTests
{
    public class UserDALtests
    {
        [Fact]
        public void CreateUser_ValidUser_CreatesUser()
        {
            // Arrange
            var mockDbConnection = new Mock<SqlConnection>();
            var mockDbCommand = new Mock<SqlCommand>();
            var mockDbParameterCollection = new Mock<SqlParameterCollection>();
            var username = "georgi.tin";
            var password = "e9999619";
            var email = "georgi.tinchev.124@gmail.com";
            var salt = PasswordHelper.GenerateSalt();
            var hashedPassword = PasswordHelper.HashPassword(password, salt);
            var user = new UserDTO
            {
                Username = username,
                Email = email,
                PasswordHash = hashedPassword,
                PasswordSalt = salt
            };

            mockDbCommand.Setup(m => m.Parameters).Returns(mockDbParameterCollection.Object);
            mockDbConnection.Setup(m => m.CreateCommand()).Returns(mockDbCommand.Object);
            mockDbCommand.Setup(m => m.ExecuteScalar()).Returns(1);

            var userDAL = new UserDAL(mockDbConnection.Object);

            // Act
            var result = userDAL.CreateUser(user);

            // Assert
            Assert.Equal(1, result);
            mockDbCommand.Verify(m => m.ExecuteNonQuery(), Times.Once);
        }

        [Fact]
        public void GetUserByUsername_ValidUsername_ReturnsUser()
        {
            // Arrange
            var mockDbConnection = new Mock<SqlConnection>();
            var mockDbCommand = new Mock<SqlCommand>();
            var mockDbParameterCollection = new Mock<SqlParameterCollection>();
            var mockDbDataReader = new Mock<SqlDataReader>();
            var username = "georgi.tin";
            var password = "e9999619";
            var email = "georgi.tinchev.124@gmail.com";
            var salt = PasswordHelper.GenerateSalt();
            var hashedPassword = PasswordHelper.HashPassword(password, salt);

            mockDbCommand.Setup(m => m.Parameters).Returns(mockDbParameterCollection.Object);
            mockDbConnection.Setup(m => m.CreateCommand()).Returns(mockDbCommand.Object);
            mockDbCommand.Setup(m => m.ExecuteReader()).Returns(mockDbDataReader.Object);
            mockDbDataReader.SetupSequence(m => m.Read()).Returns(true).Returns(false);
            mockDbDataReader.Setup(m => m["Username"]).Returns(username);
            mockDbDataReader.Setup(m => m["PasswordHash"]).Returns(hashedPassword);
            mockDbDataReader.Setup(m => m["PasswordSalt"]).Returns(salt);
            mockDbDataReader.Setup(m => m["Email"]).Returns(email);

            var userDAL = new UserDAL(mockDbConnection.Object);

            // Act
            var result = userDAL.GetUserByUsername(username);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(username, result.Username);
            Assert.Equal(hashedPassword, result.PasswordHash);
            Assert.Equal(salt, result.PasswordSalt);
            Assert.Equal(email, result.Email);
        }
    }
}
