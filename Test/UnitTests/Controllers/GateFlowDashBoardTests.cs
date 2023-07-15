using GateFlowDashboardAPI.BusinessLogic.Contract;
using GateFlowDashboardAPI.Controllers;
using GateFlowDashboardAPI.Models.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace GateFlowDashboardAPIUnitTests.Controllers
{
    public class GateFlowDashBoardTests
    {
        private GateFlowDashBoard _controller;
        private Mock<IGateFlow> _gateFlowServiceMock;
        private Mock<ILogger<GateFlowDashBoard>> _loggerMock;

        public GateFlowDashBoardTests()
        {
            _gateFlowServiceMock = new Mock<IGateFlow>();
            _loggerMock = new Mock<ILogger<GateFlowDashBoard>>();
            _controller = new GateFlowDashBoard(_gateFlowServiceMock.Object, _loggerMock.Object);
        }

        [Fact]
        public async Task Get_Returns_OkResult_For_Valid_Input()
        {
            // Arrange
            var filterParams = new Dictionary<string, List<string>>();
            var correlationId = Guid.NewGuid().ToString();
            var resultSet = new List<SensorEventResponse>();
            _gateFlowServiceMock.Setup(mock => mock.GetGateFlowSummary(filterParams, correlationId)).ReturnsAsync(resultSet);

            // Act
            var result = await _controller.Get(filterParams);

            // Assert
            Assert.IsType<OkObjectResult>(result.Result);
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            Assert.Equal(resultSet, okResult.Value);
            _loggerMock.Verify(
               x => x.Log(
                   LogLevel.Information,
                   It.IsAny<EventId>(),
                   It.Is<It.IsAnyType>((v, t) => v.ToString().Contains("Invoked GetGateFlowSummary Endpoint.")),
                   It.IsAny<Exception>(),
                   It.IsAny<Func<It.IsAnyType, Exception, string>>()
               ),
               Times.Once, "Expected Info 'Invoked GetGateFlowSummary Endpoint.' to be logged exactly once.");
            _loggerMock.Verify(
              x => x.Log(
                  LogLevel.Information,
                  It.IsAny<EventId>(),
                  It.Is<It.IsAnyType>((v, t) => v.ToString().Contains("Invoked GetGateFlowSummary Endpoint.")),
                  It.IsAny<Exception>(),
                  It.IsAny<Func<It.IsAnyType, Exception, string>>()
              ),
              Times.Once, "Expected Info 'Invoking GetGateFlowSummary Endpoint Finished.' to be logged exactly once.");
        }
    }
}