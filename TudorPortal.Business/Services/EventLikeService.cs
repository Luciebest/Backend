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
    public class EventLikeService : IEventLikeService
    {
        private readonly IEventLikeRepository _eventLikeRepository;
        private readonly IMapper _mapper;

        public EventLikeService(
            IEventLikeRepository eventLikeRepository, 
            IMapper mapper)
        {
            _eventLikeRepository = eventLikeRepository;
            _mapper = mapper;
        }
        public IEnumerable<EventLike> GetEventLikes()
        {
            return _eventLikeRepository.ListAll();
        }

        public EventLikeModel GetNumberofLikesByEventId(int eventId)
        {
            var eventLikes = _eventLikeRepository.ListAll();
            var evenLikesforEventId = eventLikes.Where(eventLikes => eventLikes.EventId == eventId)
                .Sum(eventLikes => eventLikes.NumberOfLikes);
            return new EventLikeModel { NumberOfLikes = evenLikesforEventId };
        }

        public int AddEventLike(AddEventLikeModel evenLike)
        {
            var newevenLike = _eventLikeRepository.Add(_mapper.Map<EventLike>(evenLike));
            return newevenLike.Id;
        }

        public void UpdateEventLike(EventLike eventLike)
        {
            _eventLikeRepository.Update(eventLike);
        }

        public void DeleteEventLike(int id)
        {
            var evel = _eventLikeRepository.GetById(id);
            if (evel != null)
            {
                _eventLikeRepository.Delete(evel);
            }
        }
    }
}
