using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tudor_Vladimirescu_students__portal.Entities;
using TudorPortal.Business.Models;

namespace TudorPortal.Business.Services.IServices
{
    public interface IEventLikeService
    {
        public IEnumerable<EventLike> GetEventLikes();
        public EventLikeModel GetNumberofLikesByEventId(int eventId);
        public int AddEventLike(AddEventLikeModel evenLike);
        public void UpdateEventLike(EventLike eventLike);
        public void DeleteEventLike(int id);
    }
}
