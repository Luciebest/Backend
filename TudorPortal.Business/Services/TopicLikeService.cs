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
    public class TopicLikeService : ITopicLikeService
    {
        private readonly ITopicLikeRepository _topicLikerepository;
        private readonly IMapper _mapper;

        public TopicLikeService(
            ITopicLikeRepository topicLikerepository, 
            IMapper mapper)
        {
            _topicLikerepository = topicLikerepository;
            _mapper = mapper;
        }
        public IEnumerable<TopicLike> GetTopicLikes()
        {
            return _topicLikerepository.ListAll();
        }

        public TopicLikeModel GetNumberofLikesByTopicId(int topicId)
        {
            var topicLikes = _topicLikerepository.ListAll();
            var topicLikesforTopicId = topicLikes.Where(topicLikes => topicLikes.TopicId == topicId)
                .Sum(topicLikes => topicLikes.NumberOfLikes);
            return new TopicLikeModel { NumberOfLikes = topicLikesforTopicId };
        }

        public int AddTopicLike(AddTopicLikeModel toplike)
        {
            var newtopLike = _topicLikerepository.Add(_mapper.Map<TopicLike>(toplike));
            return newtopLike.Id;
        }

        public void UpdateTopicLike(TopicLike topL)
        {
            _topicLikerepository.Update(topL);
        }

        public void DeleteTopicLike(int id)
        {
            var topL = _topicLikerepository.GetById(id);
            if (topL != null)
            {
                _topicLikerepository.Delete(topL);
            }
        }
    }
}
