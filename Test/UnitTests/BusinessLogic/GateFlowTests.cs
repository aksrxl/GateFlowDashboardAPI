using GateFlowDashboardAPI.BusinessLogic.Implementations;
using GateFlowDashboardAPI.DataAccess.IRepository;
using GateFlowDashboardAPI.EFCore.Models;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Logging;
using Moq;
using System.Linq.Expressions;
using Xunit;

namespace GateFlowDashboardAPIUnitTests.BusinessLogic
{
    public class GateFlowTests
    {

        private GateFlow _gateFlow;
        private Mock<ISensorEventRepository> _mockSensorEventRepository;
        private Mock<ILogger<GateFlow>> _mockLogger;
        private List<SensorEvent> sensorEvents;

        public GateFlowTests()
        {
            _mockSensorEventRepository = new Mock<ISensorEventRepository>();
            _mockLogger = new Mock<ILogger<GateFlow>>();
            _gateFlow = new GateFlow(_mockSensorEventRepository.Object, _mockLogger.Object);
            sensorEvents = sensorEvents = new List<SensorEvent>
            {
                new SensorEvent { Gate = "Gate A", Type = "Enter", CreatedDate = DateTime.UtcNow },
                new SensorEvent { Gate = "Gate A", Type = "Leave", CreatedDate = DateTime.UtcNow },
                new SensorEvent { Gate = "Gate B", Type = "Enter", CreatedDate = DateTime.UtcNow },
            };
        }

        [Fact]
        public async Task GetGateFlowSummary_Should_Throw_Invalid_Operation_Exception_For_Incorrect_Filter_Param()
        {
            // Arrange
            var correlationId = Guid.NewGuid().ToString();
            var filterParams = new Dictionary<string, List<string>>()
            {
                { "Gate",new List<string> { "Gate A" }}
            };

            var loggerMock = new Mock<ILogger<GateFlow>>();
            var sensorEventRepositoryMock = new Mock<ISensorEventRepository>();
            var asyncSensorEvents = new TestAsyncEnumerable<SensorEvent>(sensorEvents);
            var sensorEventsQueryable = asyncSensorEvents.AsQueryable();

            _mockSensorEventRepository.Setup(repo => repo.GetAllSensorEvents(It.IsAny<string>())).Returns(sensorEventsQueryable);

            // Act
            var result = await _gateFlow.GetGateFlowSummary(filterParams, correlationId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
            _mockLogger.Verify(
              x => x.Log(
                  LogLevel.Information,
                  It.IsAny<EventId>(),
                  It.Is<It.IsAnyType>((v, t) => v.ToString().Contains("Initiated GetGateFlowSummary call.")),
                  It.IsAny<Exception>(),
                  It.IsAny<Func<It.IsAnyType, Exception, string>>()
              ),
              Times.Once, "Expected Info 'Initiated GetGateFlowSummary call.' to be logged exactly once.");
            _mockLogger.Verify(
              x => x.Log(
                  LogLevel.Information,
                  It.IsAny<EventId>(),
                  It.Is<It.IsAnyType>((v, t) => v.ToString().Contains("Finished GetGateFlowSummary call.")),
                  It.IsAny<Exception>(),
                  It.IsAny<Func<It.IsAnyType, Exception, string>>()
              ),
              Times.Once, "Expected Info 'Finished GetGateFlowSummary call.' to be logged exactly once.");
        }

        [Fact]
        public async Task GetGateFlowSummary_Should_Return_Grouped_Data_ForValid_Input()
        {
            // Arrange
            var correlationId = Guid.NewGuid().ToString();
            var filterParams = new Dictionary<string, List<string>>()
            {
                { "Some Invalid Column",new List<string> { "Gate A" }}
            };

            var loggerMock = new Mock<ILogger<GateFlow>>();
            var sensorEventRepositoryMock = new Mock<ISensorEventRepository>();
            var asyncSensorEvents = new TestAsyncEnumerable<SensorEvent>(sensorEvents);
            var sensorEventsQueryable = asyncSensorEvents.AsQueryable();

            _mockSensorEventRepository.Setup(repo => repo.GetAllSensorEvents(It.IsAny<string>())).Returns(sensorEventsQueryable);

            // Act
            var result = await Assert.ThrowsAsync<InvalidOperationException>(async () => await _gateFlow.GetGateFlowSummary(filterParams, correlationId));

            // Assert
            Assert.NotNull(result);
            _mockLogger.Verify(
              x => x.Log(
                  LogLevel.Information,
                  It.IsAny<EventId>(),
                  It.Is<It.IsAnyType>((v, t) => v.ToString().Contains("Initiated GetGateFlowSummary call.")),
                  It.IsAny<Exception>(),
                  It.IsAny<Func<It.IsAnyType, Exception, string>>()
              ),
              Times.Once, "Expected Info 'Initiated GetGateFlowSummary call.' to be logged exactly once.");
            _mockLogger.Verify(
              x => x.Log(
                  LogLevel.Information,
                  It.IsAny<EventId>(),
                  It.Is<It.IsAnyType>((v, t) => v.ToString().Contains("Finished GetGateFlowSummary call.")),
                  It.IsAny<Exception>(),
                  It.IsAny<Func<It.IsAnyType, Exception, string>>()
              ),
              Times.Never, "Expected Info 'Finished GetGateFlowSummary call.' to be logged exactly once.");
        }
    }


    #region PrivateMethod
    // TestAsyncEnumerable class implementation for mocking IAsyncEnumerable
    internal class TestAsyncEnumerable<T> : EnumerableQuery<T>, IAsyncEnumerable<T>, IQueryable<T>
    {
        public TestAsyncEnumerable(IEnumerable<T> enumerable)
            : base(enumerable)
        { }

        public TestAsyncEnumerable(Expression expression)
            : base(expression)
        { }

        public IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default)
        {
            return new TestAsyncEnumerator<T>(this.AsEnumerable().GetEnumerator());
        }

        IQueryProvider IQueryable.Provider => new TestAsyncQueryProvider<T>(this);
    }

    internal class TestAsyncEnumerator<T> : IAsyncEnumerator<T>
    {
        private readonly IEnumerator<T> _enumerator;

        public TestAsyncEnumerator(IEnumerator<T> enumerator)
        {
            _enumerator = enumerator ?? throw new ArgumentNullException(nameof(enumerator));
        }

        public ValueTask<bool> MoveNextAsync()
        {
            return new ValueTask<bool>(_enumerator.MoveNext());
        }

        public T Current => _enumerator.Current;

        public ValueTask DisposeAsync()
        {
            _enumerator.Dispose();
            return new ValueTask();
        }
    }

    internal class TestAsyncQueryProvider<TEntity> : IAsyncQueryProvider
    {
        private readonly IQueryProvider _inner;

        internal TestAsyncQueryProvider(IQueryProvider inner)
        {
            _inner = inner;
        }

        public IQueryable CreateQuery(Expression expression)
        {
            return new TestAsyncEnumerable<TEntity>(expression);
        }

        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            return new TestAsyncEnumerable<TElement>(expression);
        }

        public object Execute(Expression expression)
        {
            return _inner.Execute(expression);
        }

        public TResult Execute<TResult>(Expression expression)
        {
            return _inner.Execute<TResult>(expression);
        }

        public IAsyncEnumerable<TResult> ExecuteAsync<TResult>(Expression expression)
        {
            return new TestAsyncEnumerable<TResult>(expression);
        }

        public Task<TResult> ExecuteAsync<TResult>(Expression expression, CancellationToken cancellationToken)
        {
            return Task.FromResult(Execute<TResult>(expression));
        }

        TResult IAsyncQueryProvider.ExecuteAsync<TResult>(Expression expression, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
