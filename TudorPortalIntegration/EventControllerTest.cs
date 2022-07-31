using FluentAssertions;
using PowerArgs.Cli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using TudorPortal.Business.Models;

namespace TudorPortalIntegration
{
    [TestClass]
    public class EventControllerTest : BaseIntegrationTests
    {
        [TestMethod]

        public async Task AddEvent_ShouldInsertEvent()
        {
            // Arrange
            var addEventModel = new AddEventModel
            {
                Title = "Test",
                Content = "Testare",
                Eventcreated = DateTime.Now,
                Picture = "test.png"
            };

            // Act
            var addEventResponse = await ApplicationHttpClient.PostAsJsonAsync("api/event", addEventModel);

            // Assert
            addEventResponse.EnsureSuccessStatusCode();
            var eventId = await addEventResponse.Content.ReadAsStringAsync();
            eventId.Should().NotBeNullOrEmpty();

            var eventResponse = await ApplicationHttpClient.GetAsync($"api/event/{eventId}");
            eventResponse.EnsureSuccessStatusCode();
            var _event = await eventResponse.Content.ReadFromJsonAsync<Event>();
            _event.Should().NotBeNull();
            _event.ToString().Should().Be(eventId);
        }
    }
}
