using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudor_Vladimirescu_students__portal.Entities
{
    public class Topics : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Topiccreated { get; set; }
        public int Status { get; set; }
        public string Picture { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Comment> Comment { get; set; } = new List<Comment>();
        public ICollection<TopicLike> TopicLikes { get; set; } = new List<TopicLike>();

    }
}
