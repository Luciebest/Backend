using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TudorPortal.Business.Models
{
    public class TopicLikeModel
    {
        public int NumberOfLikes { get; set; }
        public TopicsModel Topics { get; set; }
        public UserModel User { get; set; }
    }
}
