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
    public class EventServiceTest
    {
        private Mock<IEventRepository> _eventRepositoryMock;
        private Mock<IMapper> _mapperMock;

        [TestInitialize]
        public void TestInitializer()
        {
            _eventRepositoryMock = new Mock<IEventRepository>();
            _mapperMock = new Mock<IMapper>();
        }

        [TestMethod]
        public void DeleteEvent_ShouldDeleteEvent_WhenEventExists()
        {
            // Arrange
            var eve = new Event();
            _eventRepositoryMock.Setup(r => r.GetById(eve.Id)).Returns(eve);
            var eventRepository = _eventRepositoryMock.Object;
            var mapper = _mapperMock.Object;
            var sut = new EventService(eventRepository, mapper);

            // Act
            sut.DeleteEvent(eve.Id);

            // Assert 
            _eventRepositoryMock.Verify(r => r.Delete(eve), Times.Once);
        }

        //[TestMethod]
        //public void DeleteEvent_ShouldNotDeleteEvent_WhenEventDoesNotExist()
        //{
        //    // Arrange
        //    // Could just not mock it, but it's better to be explicit
        //    Event eve = null;
        //    _eventRepositoryMock.Setup(r => r.GetById(It.IsAny<int>())).Returns(eve);
        //    var eventRepository = _eventRepositoryMock.Object;
        //    var mapper = _mapperMock.Object;
        //    var sut = new EventService(eventRepository, mapper);

        //    // Act
        //    sut.DeleteEvent(1);

        //    // Assert
        //    _eventRepositoryMock.Verify(r => r.Delete(It.IsAny<Event>()), Times.Never);
        //}
    }
}
