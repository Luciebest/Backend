using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tudor_Vladimirescu_students__portal.Entities;

namespace TudorPortal.Business.Models
{
    public class EventModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Eventcreated { get; set; }
        public string Picture { get; set; }
        public ICollection<EventLike> EventLikes { get; set; }
        public int UserId { get; set; }
    }
}
