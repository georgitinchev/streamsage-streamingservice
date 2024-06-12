using DTOs;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Service_Classes;
using Moq;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class InterpretationServiceTests
    {
        private InterpretationService interpretationService;
        private Mock<IInterpretationManager> mockInterpretationManager;

        [TestInitialize]
        public void Setup()
        {
            mockInterpretationManager = new Mock<IInterpretationManager>();
            interpretationService = new InterpretationService(mockInterpretationManager.Object);
        }

        [TestMethod]
        public void AddInterpretation_ValidInterpretation_CallsCreate()
        {
            var interpretation = new InterpretationDTO(1, 1, 1, "Test Interpretation", DateTime.Now);
            interpretationService.AddInterpretation(interpretation);
            mockInterpretationManager.Verify(i => i.Create(It.Is<InterpretationDTO>(i => i.Id == interpretation.Id)), Times.Once);
        }

        [TestMethod]
        public void UpdateInterpretation_ValidInterpretation_CallsUpdate()
        {
            var interpretation = new InterpretationDTO(1, 1, 1, "Test Interpretation", DateTime.Now);
            interpretationService.UpdateInterpretation(interpretation);
            mockInterpretationManager.Verify(i => i.Update(It.Is<InterpretationDTO>(i => i.Id == interpretation.Id)), Times.Once);
        }

        [TestMethod]
        public void DeleteInterpretation_ValidInterpretationId_CallsDelete()
        {
            int interpretationId = 1;
            interpretationService.DeleteInterpretation(interpretationId);
            mockInterpretationManager.Verify(i => i.Delete(interpretationId), Times.Once);
        }

        [TestMethod]
        public void GetInterpretationById_ValidInterpretationId_CallsRead()
        {
            int interpretationId = 1;
            interpretationService.GetInterpretationById(interpretationId);
            mockInterpretationManager.Verify(i => i.Read(interpretationId), Times.Once);
        }

        [TestMethod]
        public void GetTotalInterpretationsCount_CallsGetTotalInterpretationsCount()
        {
            interpretationService.GetTotalInterpretationsCount();
            mockInterpretationManager.Verify(i => i.GetTotalInterpretationsCount(), Times.Once);
        }

        [TestMethod]
        public void GetInterpretationsByMovieId_ValidMovieId_CallsGetInterpretationsByMovieId()
        {
            int movieId = 1;
            interpretationService.GetInterpretationsByMovieId(movieId);
            mockInterpretationManager.Verify(i => i.GetInterpretationsByMovieId(movieId), Times.Once);
        }

        [TestMethod]
        public void GetAllInterpretations_CallsGetAllInterpretations()
        {
            interpretationService.GetAllInterpretations();
            mockInterpretationManager.Verify(i => i.GetAllInterpretations(), Times.Once);
        }

        [TestMethod]
        public void GetInterpretationsPage_ValidPageNumberAndSize_CallsGetPaginatedInterpretations()
        {
            int pageNumber = 1;
            int pageSize = 10;
            interpretationService.GetInterpretationsPage(pageNumber, pageSize);
            mockInterpretationManager.Verify(i => i.GetPaginatedInterpretations(pageNumber, pageSize), Times.Once);
        }
    }
}
