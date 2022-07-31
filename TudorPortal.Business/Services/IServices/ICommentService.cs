using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tudor_Vladimirescu_students__portal.Entities;
using TudorPortal.Business.Models;

namespace TudorPortal.Business.Services.IServices
{
    public interface ICommentService
    {
        public IEnumerable<Comment> GetComments();
        public IEnumerable<Comment> GetCommentByTopictId(int topicId);
        public int AddComment(AddCommentModel comm);
        public void UpdateComment(Comment comm);
        public void DeleteComment(int id);
    }
}
