namespace GateFlowDashboardAPI.DataAccess.Repository
{
    using GateFlowDashboardAPI.DataAccess.IRepository;
    using GateFlowDashboardAPI.EFCore;
    using GateFlowDashboardAPI.EFCore.Models;
    using System.Linq;
    using System.Threading.Tasks;
    using static Constants;

    public class SensorEventRepository : ISensorEventRepository
    {
        private readonly ApiContext _apiContext;
        private readonly ILogger<SensorEventRepository> _logger;
        public SensorEventRepository(ApiContext apiContext,ILogger<SensorEventRepository> logger)
        {
            _apiContext = apiContext;
            _logger = logger;
        }

        public IQueryable<SensorEvent> GetAllSensorEvents(string correlationId)
        {
            _logger.LogInformation(DefaultLogger, correlationId, DateTime.UtcNow, "Initiated GetAllSensorEvents call.");
            var getAllSensorEventsQuery = _apiContext.SensorEvent.AsQueryable();
            _logger.LogInformation(DefaultLogger, correlationId, DateTime.UtcNow, "Finished GetAllSensorEvents call.");
            return getAllSensorEventsQuery;
        }

        public async Task<string> SaveSensorEvent(SensorEvent sensorEvent, string correlationId)
        {
            _logger.LogInformation(DefaultLogger, correlationId, DateTime.UtcNow, "Initiated SaveSensorEvent call.");
            var entity = await _apiContext.SensorEvent.AddAsync(sensorEvent);
            await _apiContext.SaveChangesAsync();
            _logger.LogInformation(DefaultLogger, correlationId, DateTime.UtcNow, "Finished SaveSensorEvent call.");
            return entity.Entity.Id;
        }
    }
}