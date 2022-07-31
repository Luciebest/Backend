using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tudor_Vladimirescu_students__portal.Data;
using Tudor_Vladimirescu_students__portal.Entities;
using Tudor_Vladimirescu_students__portal.IRepositories;

namespace TudorPortal.Persistance.Repositories
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        public EventRepository(TudorPortalDbContext tudorPortalDbContext) :base(tudorPortalDbContext)
        {

        }

        public IEnumerable<Event> GetEventTime(DateTime Eventcreated)
        {
            var eventtime = _dbContext.Event.Where(e => e.Eventcreated == Eventcreated)
                .Where(e => e.Eventcreated >= Eventcreated)
                .ToList();
            return _dbContext.Event
                .ToList();
        }
    }
}
