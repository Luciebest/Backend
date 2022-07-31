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
    public class TopicsService : ITopicsService
    {
        private readonly ITopicsRepository _topicsRepository;
        private readonly IMapper _mapper;

        public TopicsService(
            ITopicsRepository topicsRepository, 
            IMapper mapper)
        {
            _topicsRepository = topicsRepository;
            _mapper = mapper;
        }
        public IEnumerable<Topics> GetTopics()
        {
            return _topicsRepository.ListAll();
        }

        public Topics GetTopics(int id)
        {
            return _topicsRepository.GetById(id);
        }

        public int AddTopic(AddTopicsModel top)
        {
            var newtop = _topicsRepository.Add(_mapper.Map<Topics>(top));
            return newtop.Id;
        }

        public void UpdateTopics(Topics top)
        {
            _topicsRepository.Update(top);
        }

        public void DeleteTopics(int id)
        {
            var top = _topicsRepository.GetById(id);
            if (top != null)
            {
                _topicsRepository.Delete(top);
            }
        }
    }
}
