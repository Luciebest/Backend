using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TudorPortal.Business.Models
{
    public sealed class AddEventLikeModel
    {
        public int NumberOfLikes { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
    }
}
