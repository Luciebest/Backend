using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tudor_Vladimirescu_students__portal.Entities;
using TudorPortal.Business.Models;

namespace TudorPortal.Business.Services.IServices
{
    public interface ITopicLikeService
    {
        public IEnumerable<TopicLike> GetTopicLikes();
        public TopicLikeModel GetNumberofLikesByTopicId(int topicId);
        public int AddTopicLike(AddTopicLikeModel toplike);
        public void UpdateTopicLike(TopicLike topL);
        public void DeleteTopicLike(int id);
    }
}
