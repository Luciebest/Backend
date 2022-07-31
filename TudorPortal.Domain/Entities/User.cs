using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudor_Vladimirescu_students__portal.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public string Hashedpassword { get; set; }
        public bool IsAdministrator { get; set; }
        public ICollection<Topics> Topics { get; set; } = new List<Topics>();
        public ICollection<Event> Event { get; set; } = new List<Event>();
        public ICollection<Comment> Comment { get; set; } = new List<Comment>();
        public ICollection<TopicLike> TopicLikes { get; set; } = new List<TopicLike>();
        public ICollection<EventLike> EventLikes { get; set; } = new List<EventLike>();

    }
}
