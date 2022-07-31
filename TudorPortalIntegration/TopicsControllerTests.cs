using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tudor_Vladimirescu_students__portal.Entities;
using TudorPortal.Business.Models;

namespace TudorPortalIntegration
{
    [TestClass]
    public class TopicsControllerTests : BaseIntegrationTests
    {
        [TestMethod]

        public async Task AddTopic_ShouldInsertTopic()
        {
            // Arrange
            var addTopicModel = new AddTopicsModel
            {
                Title = "Test",
                Content = "Testare",
                Topiccreated = DateTime.Now,
                Status = 1,
                Picture = "test.png"
            };

            // Act
            var addTopicResponse = await ApplicationHttpClient.PostAsJsonAsync("api/topics", addTopicModel);

            // Assert
            addTopicResponse.EnsureSuccessStatusCode();
            var topicId = await addTopicResponse.Content.ReadAsStringAsync();
            topicId.Should().NotBeNullOrEmpty();

            var topicsResponse = await ApplicationHttpClient.GetAsync($"api/topics/{topicId}");
            topicsResponse.EnsureSuccessStatusCode();
            var topic = await topicsResponse.Content.ReadFromJsonAsync<Topics>();
            topic.Should().NotBeNull();
            topic.Id.ToString().Should().Be(topicId);
        }
    }
}
