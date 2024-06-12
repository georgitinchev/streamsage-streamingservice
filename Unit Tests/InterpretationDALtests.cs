using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using DTOs;
using DataAccessLibrary;
using System;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class InterpretationDALtests
    {
        [TestMethod]
        public void ReadAllInterpretations_ReturnsAllInterpretations()
        {
            var mockInterpretationDAL = new Mock<IInterpretationDAL>();
            var interpretations = new List<InterpretationDTO>
            {
                new InterpretationDTO(1, 1, 1, "interpretation1", DateTime.Now),
                new InterpretationDTO(2, 2, 2, "interpretation2", DateTime.Now)
            };

            mockInterpretationDAL.Setup(m => m.ReadAllInterpretations()).Returns(interpretations);

            var interpretationDAL = mockInterpretationDAL.Object;

            var result = interpretationDAL.ReadAllInterpretations();

            Assert.IsNotNull(result);
            Assert.AreEqual(interpretations, result);
        }

        [TestMethod]
        public void GetInterpretationsByMovieId_ValidMovieId_ReturnsInterpretations()
        {
            var mockInterpretationDAL = new Mock<IInterpretationDAL>();
            var interpretations = new List<InterpretationDTO>
            {
                new InterpretationDTO(1, 1, 1, "interpretation1", DateTime.Now),
                new InterpretationDTO(2, 2, 1, "interpretation2", DateTime.Now)
            };

            mockInterpretationDAL.Setup(m => m.GetInterpretationsByMovieId(1)).Returns(interpretations);

            var interpretationDAL = mockInterpretationDAL.Object;

            var result = interpretationDAL.GetInterpretationsByMovieId(1);

            Assert.IsNotNull(result);
            Assert.AreEqual(interpretations, result);
        }

        [TestMethod]
        public void GetPaginatedInterpretations_ValidPageNumberAndSize_ReturnsInterpretations()
        {
            var mockInterpretationDAL = new Mock<IInterpretationDAL>();
            var interpretations = new List<InterpretationDTO>
            {
                new InterpretationDTO(1, 1, 1, "interpretation1", DateTime.Now),
                new InterpretationDTO(2, 2, 2, "interpretation2", DateTime.Now)
            };

            mockInterpretationDAL.Setup(m => m.GetPaginatedInterpretations(1, 2)).Returns(interpretations);

            var interpretationDAL = mockInterpretationDAL.Object;
            var result = interpretationDAL.GetPaginatedInterpretations(1, 2);

            Assert.IsNotNull(result);
            Assert.AreEqual(interpretations, result);
        }

        [TestMethod]
        public void GetTotalInterpretationsCount_ReturnsTotalInterpretationsCount()
        {
            var mockInterpretationDAL = new Mock<IInterpretationDAL>();

            mockInterpretationDAL.Setup(m => m.GetTotalInterpretationsCount()).Returns(10);

            var interpretationDAL = mockInterpretationDAL.Object;

            var result = interpretationDAL.GetTotalInterpretationsCount();

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void CreateInterpretation_ValidInterpretation_CreatesInterpretation()
        {
            var mockInterpretationDAL = new Mock<IInterpretationDAL>();
            var interpretation = new InterpretationDTO(1, 1, 1, "interpretation1", DateTime.Now);

            mockInterpretationDAL.Setup(m => m.CreateInterpretation(It.IsAny<InterpretationDTO>()));

            var interpretationDAL = mockInterpretationDAL.Object;

            interpretationDAL.CreateInterpretation(interpretation);

            mockInterpretationDAL.Verify(m => m.CreateInterpretation(It.IsAny<InterpretationDTO>()), Times.Once);
        }

        [TestMethod]
        public void UpdateInterpretation_ValidInterpretation_UpdatesInterpretation()
        {
            var mockInterpretationDAL = new Mock<IInterpretationDAL>();
            var interpretation = new InterpretationDTO(1, 1, 1, "interpretation1", DateTime.Now);

            mockInterpretationDAL.Setup(m => m.UpdateInterpretation(It.IsAny<InterpretationDTO>()));

            var interpretationDAL = mockInterpretationDAL.Object;

            interpretationDAL.UpdateInterpretation(interpretation);

            mockInterpretationDAL.Verify(m => m.UpdateInterpretation(It.IsAny<InterpretationDTO>()), Times.Once);
        }

        [TestMethod]
        public void DeleteInterpretation_ValidInterpretationId_DeletesInterpretation()
        {
            var mockInterpretationDAL = new Mock<IInterpretationDAL>();

            mockInterpretationDAL.Setup(m => m.DeleteInterpretation(It.IsAny<int>()));

            var interpretationDAL = mockInterpretationDAL.Object;

            interpretationDAL.DeleteInterpretation(1);

            mockInterpretationDAL.Verify(m => m.DeleteInterpretation(It.IsAny<int>()), Times.Once);
        }

        [TestMethod]
        public void GetInterpretationById_ValidInterpretationId_ReturnsInterpretation()
        {
            var mockInterpretationDAL = new Mock<IInterpretationDAL>();
            var interpretation = new InterpretationDTO(1, 1, 1, "interpretation1", DateTime.Now);

            mockInterpretationDAL.Setup(m => m.GetInterpretationById(1)).Returns(interpretation);

            var interpretationDAL = mockInterpretationDAL.Object;

            var result = interpretationDAL.GetInterpretationById(1);

            Assert.IsNotNull(result);
            Assert.AreEqual(interpretation, result);
        }
    }
}
