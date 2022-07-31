using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TudorPortal.Business.Models
{
    public sealed class AddTopicsModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Topiccreated { get; set; }
        public int Status { get; set; }
        public string Picture { get; set; }
        public int UserId { get; set; }
    }
}
