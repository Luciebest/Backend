using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tudor_Vladimirescu_students__portal.Data;
using Tudor_Vladimirescu_students__portal.Entities;
using Tudor_Vladimirescu_students__portal.IRepositories;

namespace TudorPortal.Persistance.Repositories
{
    public class TopicsRepository : BaseRepository<Topics>,ITopicsRepository
    {
        public TopicsRepository(TudorPortalDbContext tudorPortalDbContext) : base(tudorPortalDbContext)
        {

        }

        public IEnumerable<Topics> GetTopicsTime(DateTime Topiccreated)
        {
            var topicscreated = _dbContext.Topics.Where(t => t.Topiccreated == Topiccreated)
                .Where(t => t.Topiccreated >= Topiccreated)
                .ToList();
            return _dbContext.Topics
                .ToList();
        }
    }
}
