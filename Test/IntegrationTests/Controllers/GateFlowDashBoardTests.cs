using GateFlowDashboardAPI;
using GateFlowDashboardAPI.EFCore;
using GateFlowDashboardAPI.Models.Response;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System.Net;
using Xunit;

namespace GateFlowDashboardAPIInitegrationTests.Controllers
{
    public class GateFlowDashBoardTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;
        private readonly HttpClient _client;

        public GateFlowDashBoardTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
            _client = _factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureServices(services =>
                {
                    // Configure test database and data seeding
                    services.AddDbContext<ApiContext>(options =>
                    {
                        options.UseInMemoryDatabase("TestDatabase");
                    });
                });
            })
            .CreateClient();

            // Seed the data
            using var scope = _factory.Services.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ApiContext>();
            SeedData(context);
        }

        #region GetGateFlowSummary
        [Fact]
        public async Task GetGateFlowSummary_Returns_OK_With_Data()
        {
            //Arrange
            var validKey = "Gate";

            // Act
            var response = await _client.GetAsync($"https://localhost:7101/GetGateFlowSummary?{validKey}=Gate A");

            // Assert
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var sensorData = JsonConvert.DeserializeObject<IEnumerable<SensorEventResponse>>(content);
            Assert.NotNull(sensorData);
            Assert.NotEmpty(sensorData);
        }

        [Fact]
        public async Task GetGateFlowSummary_Returns_BadRequest_With_Invalid_Input()
        {
            //Arrange
            var invalidKey = "SomeInvalidKey";

            // Act
            var response = await _client.GetAsync($"https://localhost:7101/GetGateFlowSummary?{invalidKey}=Gate A");

            // Assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }
        #endregion

        #region PrivateMethod
        private static void SeedData(ApiContext context)
        {
            var seedGenerator = new SeedGenerator();
            seedGenerator.SeedData(context);
            context.SaveChanges();
        }
        #endregion
    }
}
