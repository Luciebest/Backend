using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudor_Vladimirescu_students__portal.Entities
{
    public class TopicLike : BaseEntity
    {
        public int NumberOfLikes { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int TopicId { get; set; }
        public Topics Topic { get; set; }
    }
}
