using System;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TudorPortal.Business.Services;
using TudorPortal.Business.Services.IServices;

namespace TudorPortal.Business
{
    public static class BussinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<ITopicsService, TopicsService>();
            services.AddScoped<ITopicLikeService, TopicLikeService>();
            services.AddScoped<IEventLikeService, EventLikeService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
