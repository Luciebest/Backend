using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TudorPortal.Business.Models
{
    public sealed class AddTopicLikeModel
    {
        public int NumberOfLikes { get; set; }
        public int UserId { get; set; }
        public int TopicId { get; set; }
    }
}
