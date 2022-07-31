using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tudor_Vladimirescu_students__portal.Entities;

namespace Tudor_Vladimirescu_students__portal.IRepositories
{
    public interface ITopicsRepository : IBaseRepository<Topics>
    {
        IEnumerable<Topics> GetTopicsTime(DateTime Topiccreated);
    }
}
