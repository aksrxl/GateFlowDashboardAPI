namespace GateFlowDashboardAPI.BusinessLogic.Implementations
{
    using GateFlowDashboardAPI.BusinessLogic.Contract;
    using GateFlowDashboardAPI.DataAccess.IRepository;
    using GateFlowDashboardAPI.EFCore;
    using GateFlowDashboardAPI.EFCore.Models;
    using GateFlowDashboardAPI.Models.Response;
    using Microsoft.EntityFrameworkCore;
    using static Constants;

    public class GateFlow : IGateFlow
    {
        private readonly ISensorEventRepository _sensorEventRepository;
        private readonly ILogger<GateFlow> _logger;
        public GateFlow(ISensorEventRepository sensorEventRepository, ILogger<GateFlow> logger)
        {
            _sensorEventRepository = sensorEventRepository;
            _logger = logger;
        }

        public async Task<IEnumerable<SensorEventResponse>> GetGateFlowSummary(Dictionary<string, List<string>> filterParams, string correlationId)
        {
            _logger.LogInformation(DefaultLogger, correlationId, DateTime.UtcNow, "Initiated GetGateFlowSummary call.");
            var filteredExpression = DynamicFilterGenerator.GenerateFilterExpression<SensorEvent>(filterParams, correlationId, _logger);
            var groupedData = await _sensorEventRepository.GetAllSensorEvents(correlationId)
                                               .Where(filteredExpression)
                                               .GroupBy(e => new { e.Gate, e.Type })
                                               .Select(g => new SensorEventResponse
                                               {
                                                   Gate = g.Key.Gate,
                                                   Type = g.Key.Type,
                                                   NumberOfPeople = g.Count(),
                                                   CreatedDateFrom = g.Min(e => e.CreatedDate),
                                                   CreatedDateTo = g.Max(e => e.CreatedDate)
                                               }).ToListAsync();
            _logger.LogInformation(DefaultLogger, correlationId, DateTime.UtcNow, "Finished GetGateFlowSummary call.");
            return groupedData;
        }

        public async Task<string> GenerateRecordForSimulation(string gate, string type, DateTime dateTime, string correlationId)
        {
            _logger.LogInformation(DefaultLogger, correlationId, DateTime.UtcNow, "Initiated GenerateRecordForSimulation call.");
            var sensorEvent = new SensorEvent
            {
                Id = Guid.NewGuid().ToString(),
                Gate = gate,
                Type = type,
                CreatedDate = dateTime
            };
            var id = await _sensorEventRepository.SaveSensorEvent(sensorEvent, correlationId);
            _logger.LogInformation(DefaultLogger, correlationId, DateTime.UtcNow, "Finished GenerateRecordForSimulation call.");
            return id;
        }
    }
}