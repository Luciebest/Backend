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
    public class CommentServiceTest
    {
        private Mock<ICommentRepository> _commentRepositoryMock;
        private Mock<IMapper> _mapperMock;

        [TestInitialize]
        public void TestInitializer()
        {
            _commentRepositoryMock = new Mock<ICommentRepository>();
            _mapperMock = new Mock<IMapper>();
        }

        [TestMethod]
        public void DeleteComment_ShouldDeleteComment_WhenCommentExists()
        {
            // Arrange
            var comm = new Comment();
            _commentRepositoryMock.Setup(r => r.GetById(comm.Id)).Returns(comm);
            var commentRepository = _commentRepositoryMock.Object;
            var mapper = _mapperMock.Object;
            var sut = new CommentService(commentRepository, mapper);

            // Act
            sut.DeleteComment(comm.Id);

            // Assert 
            _commentRepositoryMock.Verify(r => r.Delete(comm), Times.Once);
        }

        //[TestMethod]
        //public void DeleteComment_ShouldNotDeleteComment_WhenCommentDoesNotExist()
        //{
        //    // Arrange
        //    // Could just not mock it, but it's better to be explicit
        //    Comment comm = null;
        //    _commentRepositoryMock.Setup(r => r.GetById(It.IsAny<int>())).Returns(comm);
        //    var commentRepository = _commentRepositoryMock.Object;
        //    var mapper = _mapperMock.Object;
        //    var sut = new CommentService(commentRepository, mapper);

        //    // Act
        //    sut.DeleteComment(1);

        //    // Assert
        //    _commentRepositoryMock.Verify(r => r.Delete(It.IsAny<Comment>()), Times.Never);
        //}
    }
}
