using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tudor_Vladimirescu_students__portal.Entities;
using TudorPortal.Business.Models;

namespace TudorPortal.Business.Services.IServices
{
    public interface IEventService
    {
        public IEnumerable<Event> GetEvents();
        public Event GetEvent(int id);
        public int AddEvent(AddEventModel even);
        public void UpdateEvent(Event ev);
        public void DeleteEvent(int id);
    }
}
