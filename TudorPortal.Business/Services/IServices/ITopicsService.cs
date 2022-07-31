using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tudor_Vladimirescu_students__portal.Entities;
using TudorPortal.Business.Models;

namespace TudorPortal.Business.Services.IServices
{
    public interface ITopicsService
    {
        public IEnumerable<Topics> GetTopics();
        public Topics GetTopics(int id);
        public int AddTopic(AddTopicsModel top);
        public void UpdateTopics(Topics top);
        public void DeleteTopics(int id);
    }
}
