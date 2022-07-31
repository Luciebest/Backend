using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TudorPortal.Business.Services.IServices;
using Tudor_Vladimirescu_students__portal.IRepositories;
using TudorPortal.Business.Models;
using Tudor_Vladimirescu_students__portal.Entities;

namespace TudorPortal.Business.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventrepository;
        private readonly IMapper _mapper;

        public EventService( 
            IEventRepository eventRepository,
            IMapper mapper)
        {
           _eventrepository = eventRepository;
            _mapper = mapper;
        }
        public IEnumerable<Event> GetEvents()
        {
            return _eventrepository.ListAll();
        }

        public Event GetEvent(int id)
        {
            return _eventrepository.GetById(id);
        }

        public int AddEvent(AddEventModel even)
        {
            var neweven = _eventrepository.Add(_mapper.Map<Event>(even));
            return neweven.Id;
        }

        public void UpdateEvent(Event ev)
        {
            _eventrepository.Update(ev);
        }

        public void DeleteEvent(int id)
        {
            var eve = _eventrepository.GetById(id);
            if (eve != null)
            {
                _eventrepository.Delete(eve);
            }
        }
    }
}
