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
    public class TopicLikeServiceTest
    {
        private Mock<ITopicLikeRepository> _topicLikeRepositoryMock;
        private Mock<IMapper> _mapperMock;

        [TestInitialize]
        public void TestInitializer()
        {
            _topicLikeRepositoryMock = new Mock<ITopicLikeRepository>();
            _mapperMock = new Mock<IMapper>();
        }

        [TestMethod]
        public void DeleteTopicLike_ShouldDeleteTopicLike_WhenTopicLikeExists()
        {
            // Arrange
            var top = new TopicLike();
            _topicLikeRepositoryMock.Setup(r => r.GetById(top.Id)).Returns(top);
            var topicLikeRepository = _topicLikeRepositoryMock.Object;
            var mapper = _mapperMock.Object;
            var sut = new TopicLikeService(topicLikeRepository, mapper);

            // Act
            sut.DeleteTopicLike(top.Id);

            // Assert 
            _topicLikeRepositoryMock.Verify(r => r.Delete(top), Times.Once);
        }

        //[TestMethod]
        //public void DeleteTopicLike_ShouldNotDeleteTopicLike_WhenTopicLikeDoesNotExist()
        //{
        //    // Arrange
        //    // Could just not mock it, but it's better to be explicit
        //    TopicLike top = null;
        //    _topicLikeRepositoryMock.Setup(r => r.GetById(It.IsAny<int>())).Returns(top);
        //    var topicLikeRepository = _topicLikeRepositoryMock.Object;
        //    var mapper = _mapperMock.Object;
        //    var sut = new TopicLikeService(topicLikeRepository, mapper);

        //    // Act
        //    sut.DeleteTopicLike(1);

        //    // Assert
        //    _topicLikeRepositoryMock.Verify(r => r.Delete(It.IsAny<TopicLike>()), Times.Never);
        //}
    }
}
