using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudor_Vladimirescu_students__portal.Entities
{
    public class  Comment : BaseEntity
    {
        public string Commentitself { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int TopicsId { get; set; }
        public Topics Topics { get; set; }
    }
}
