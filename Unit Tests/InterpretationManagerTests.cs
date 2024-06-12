using DataAccessLibrary;
using DTOs;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Managers;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class InterpretationManagerTests
    {
        private InterpretationManager? interpretationManager;
        private Mock<IInterpretationDAL>? mockInterpretationDAL;
        private Mock<IUserDAL>? mockUserDAL;
        private Mock<IMovieDAL>? mockMovieDAL;

        [TestInitialize]
        public void Setup()
        {
            mockInterpretationDAL = new Mock<IInterpretationDAL>();
            mockUserDAL = new Mock<IUserDAL>();
            mockMovieDAL = new Mock<IMovieDAL>();
            interpretationManager = new InterpretationManager(mockInterpretationDAL.Object, mockUserDAL.Object, mockMovieDAL.Object);
        }

        [TestMethod]
        public void Create_ValidInterpretation_CallsCreateInterpretation()
        {
            var interpretation = new InterpretationDTO(1, 1, 1, "Test Interpretation", DateTime.Now);
            var user = new UserDTO(1, "georgi.tin", "georgi.tinchev.124@gmail.com");
            mockUserDAL.Setup(i => i.GetUserById(It.IsAny<int>())).Returns(user);
            mockMovieDAL.Setup(i => i.MovieExists(It.IsAny<int>())).Returns(true);
            interpretationManager.Create(interpretation);
            mockInterpretationDAL.Verify(i => i.CreateInterpretation(It.Is<InterpretationDTO>(i => i.Id == interpretation.Id)), Times.Once);
        }

        [TestMethod]
        public void Update_ValidInterpretation_CallsUpdateInterpretation()
        {
            var interpretation = new InterpretationDTO(1, 1, 1, "Test Interpretation", DateTime.Now);
            interpretationManager.Update(interpretation);
            mockInterpretationDAL.Verify(i => i.UpdateInterpretation(It.Is<InterpretationDTO>(i => i.Id == interpretation.Id)), Times.Once);
        }

        [TestMethod]
        public void Delete_ValidInterpretationId_CallsDeleteInterpretation()
        {
            int interpretationId = 1;
            interpretationManager.Delete(interpretationId);
            mockInterpretationDAL.Verify(i => i.DeleteInterpretation(interpretationId), Times.Once);
        }

        [TestMethod]
        public void Read_ValidInterpretationId_CallsReadInterpretation()
        {
            int interpretationId = 1;
            interpretationManager.Read(interpretationId);
            mockInterpretationDAL.Verify(i => i.ReadInterpretation(interpretationId), Times.Once);
        }

        [TestMethod]
        public void GetAllInterpretations_CallsReadAllInterpretations()
        {
            interpretationManager.GetAllInterpretations();
            mockInterpretationDAL.Verify(i => i.ReadAllInterpretations(), Times.Once);
        }

        [TestMethod]
        public void GetTotalInterpretationsCount_CallsGetTotalInterpretationsCount()
        {
            interpretationManager.GetTotalInterpretationsCount();
            mockInterpretationDAL.Verify(i => i.GetTotalInterpretationsCount(), Times.Once);
        }

        [TestMethod]
        public void GetInterpretationsByMovieId_ValidMovieId_CallsGetInterpretationsByMovieId()
        {
            int movieId = 1;
            interpretationManager.GetInterpretationsByMovieId(movieId);
            mockInterpretationDAL.Verify(i => i.GetInterpretationsByMovieId(movieId), Times.Once);
        }

    }
}
