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
    public class EventLikeServiceTest
    {
        private Mock<IEventLikeRepository> _eventLikeRepositoryMock;
        private Mock<IMapper> _mapperMock;

        [TestInitialize]
        public void TestInitializer()
        {
            _eventLikeRepositoryMock = new Mock<IEventLikeRepository>();
            _mapperMock = new Mock<IMapper>();
        }

        [TestMethod]
        public void DeleteEventLike_ShouldDeleteEventLike_WhenEventLikeExists()
        {
            // Arrange
            var eveL = new EventLike();
            _eventLikeRepositoryMock.Setup(r => r.GetById(eveL.Id)).Returns(eveL);
            var eventLikeRepository = _eventLikeRepositoryMock.Object;
            var mapper = _mapperMock.Object;
            var sut = new EventLikeService(eventLikeRepository, mapper);

            // Act
            sut.DeleteEventLike(eveL.Id);

            // Assert 
            _eventLikeRepositoryMock.Verify(r => r.Delete(eveL), Times.Once);
        }

        //[TestMethod]
        //public void DeleteEventLike_ShouldNotDeleteEventLike_WhenEventLikeDoesNotExist()
        //{
        //    // Arrange
        //    // Could just not mock it, but it's better to be explicit
        //    EventLike eveL= null;
        //    _eventLikeRepositoryMock.Setup(r => r.GetById(It.IsAny<int>())).Returns(eveL);
        //    var eventLikeRepository = _eventLikeRepositoryMock.Object;
        //    var mapper = _mapperMock.Object;
        //    var sut = new EventLikeService(eventLikeRepository, mapper);

        //    // Act
        //    sut.DeleteEventLike(1);

        //    // Assert
        //    _eventLikeRepositoryMock.Verify(r => r.Delete(It.IsAny<EventLike>()), Times.Never);
        //}
    }
}
