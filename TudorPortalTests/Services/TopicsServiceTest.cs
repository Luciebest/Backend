using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tudor_Vladimirescu_students__portal.Entities;
using Tudor_Vladimirescu_students__portal.IRepositories;
using TudorPortal.Business.Services;

namespace TudorPortalTests.Services
{
    [TestClass]
    public class TopicsServiceTest
    {
        private Mock<ITopicsRepository> _topicsRepositoryMock;
        private Mock<IMapper> _mapperMock;

        [TestInitialize]
        public void TestInitializer()
        {
            _topicsRepositoryMock = new Mock<ITopicsRepository>();
            _mapperMock = new Mock<IMapper>();
        }

        [TestMethod]
        public void DeleteTopics_ShouldDeleteTopics_WhenTopicsExists()
        {
            // Arrange
            var top = new Topics();
            _topicsRepositoryMock.Setup(r => r.GetById(top.Id)).Returns(top);
            var topicsRepository = _topicsRepositoryMock.Object;
            var mapper = _mapperMock.Object;
            var sut = new TopicsService(topicsRepository, mapper);

            // Act
            sut.DeleteTopics(top.Id);

            // Assert 
            _topicsRepositoryMock.Verify(r => r.Delete(top), Times.Once);
        }

        //[TestMethod]
        //public void DeleteTopics_ShouldNotDeleteTopics_WhenTopicsDoesNotExist()
        //{
        //    // Arrange
        //    // Could just not mock it, but it's better to be explicit
        //    Topics top = null;
        //    _topicsRepositoryMock.Setup(r => r.GetById(It.IsAny<int>())).Returns(top);
        //    var topicsRepository = _topicsRepositoryMock.Object;
        //    var mapper = _mapperMock.Object;
        //    var sut = new TopicsService(topicsRepository, mapper);

        //    // Act
        //    sut.DeleteTopics(1);

        //    // Assert
        //    _topicsRepositoryMock.Verify(r => r.Delete(It.IsAny<Topics>()), Times.Never);
        //}
    }
}
