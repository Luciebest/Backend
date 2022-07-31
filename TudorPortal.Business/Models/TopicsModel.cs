using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tudor_Vladimirescu_students__portal.Entities;

namespace TudorPortal.Business.Models
{
    public class TopicsModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Topiccreated { get; set; }
        public int Status { get; set; }
        public string Picture { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<TopicLike> TopicLikes { get; set; }
        public int UserId { get; set; }
    }
}
