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
    public class CommentRepository : BaseRepository<Comment>,ICommentRepository
    {
        public CommentRepository(TudorPortalDbContext tudorPortalDbContext) : base(tudorPortalDbContext)
        {

        }
    }
}
