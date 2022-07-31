using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TudorPortal.Business.Models
{
    public sealed class AddCommentModel
    {
        public string Commentitself { get; set; }
        public int UserId { get; set; }
        public int TopicsId { get; set; }
    }
}
