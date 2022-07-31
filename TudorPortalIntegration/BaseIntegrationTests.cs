using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tudor_Vladimirescu_students__portal.Data;
using TudorPortal.Api.Controllers;

namespace TudorPortalIntegration
{
    public class BaseIntegrationTests
    {
        private WebApplicationFactory<TopicsController> _application;
        protected HttpClient ApplicationHttpClient { get; set; }

        [TestInitialize]
        public async Task TestInitialize()
        {
            _application = new WebApplicationFactory<TopicsController>()
                .WithWebHostBuilder(_ => { });

            ApplicationHttpClient = _application.CreateClient();

            await CleanupDatabase();
        }

        [TestCleanup]

        public async Task TestCleanup()
        {
            await CleanupDatabase();
        }

        private async Task CleanupDatabase()
        {
            using var scope = _application.Services.CreateScope();
            var databaseContext = scope.ServiceProvider.GetRequiredService<TudorPortalDbContext>();
            databaseContext.Database.Migrate();
            databaseContext.Topics.RemoveRange(databaseContext.Topics.ToList());
            databaseContext.User.RemoveRange(databaseContext.User.ToList());
            databaseContext.TopicLike.RemoveRange(databaseContext.TopicLike.ToList());
            databaseContext.Comment.RemoveRange(databaseContext.Comment.ToList());
            await databaseContext.SaveChangesAsync();
        }
    }
}
