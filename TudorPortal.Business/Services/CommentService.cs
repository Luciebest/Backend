using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tudor_Vladimirescu_students__portal.Entities;
using Tudor_Vladimirescu_students__portal.IRepositories;
using TudorPortal.Business.Models;
using TudorPortal.Business.Services.IServices;

namespace TudorPortal.Business.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;

        public CommentService(
            ICommentRepository commentRepository, 
            IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
        }

        public IEnumerable<Comment> GetComments()
        {
            return _commentRepository.ListAll();
        }
        public IEnumerable<Comment> GetCommentByTopictId(int topicId)
        {
            var comment = _commentRepository.ListAll();
            var comments = comment.Where(comments => comments.TopicsId == topicId);
            return comments;
        }

        public int AddComment(AddCommentModel comm)
        {
            var newcomm = _commentRepository.Add(_mapper.Map<Comment>(comm));
            return newcomm.Id;
        }

        public void UpdateComment(Comment comm)
        {
            _commentRepository.Update(comm);
        }

        public void DeleteComment(int id)
        {
            var comment = _commentRepository.GetById(id);
            if(comment != null)
            {
                _commentRepository.Delete(comment);
            }
        }
    }
}
