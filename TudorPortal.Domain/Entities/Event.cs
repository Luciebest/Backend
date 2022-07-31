using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudor_Vladimirescu_students__portal.Entities
{
    public class Event : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Eventcreated { get; set; }
        public string Picture { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<EventLike> EventLikes { get; set; } = new List<EventLike>();
    }
}
