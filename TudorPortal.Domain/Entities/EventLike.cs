using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudor_Vladimirescu_students__portal.Entities
{
    public class EventLike : BaseEntity
    {
        public int NumberOfLikes { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
