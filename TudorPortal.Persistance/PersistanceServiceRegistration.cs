using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tudor_Vladimirescu_students__portal.Data;
using Tudor_Vladimirescu_students__portal.IRepositories;
using TudorPortal.Persistance.Repositories;

namespace TudorPortal.Persistance
{
    public static class PersistanceServiceRegistration
    {
        public static IServiceCollection AddPersistanceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TudorPortalDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("TudorPortalConnectionString")));
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<ITopicsRepository, TopicsRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<IEventLikeRepository, EventLikeRepository>();
            services.AddScoped<ITopicLikeRepository, TopicLikeRepository>();

            return services;
        }
    }
}
