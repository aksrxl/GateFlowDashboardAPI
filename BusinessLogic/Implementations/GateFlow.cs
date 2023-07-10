namespace GateFlowDashboardAPI.BusinessLogic.Implementations;

using GateFlowDashboardAPI.BusinessLogic.Contract;
using GateFlowDashboardAPI.DataAccess.IRepository;
using GateFlowDashboardAPI.Models.Response;
using Microsoft.EntityFrameworkCore;
using GateFlowDashboardAPI.EFCore;
using GateFlowDashboardAPI.EFCore.Models;

public class GateFlow : IGateFlow
{

    private readonly ISensorEventRepository _sensorEventRepository;

    public GateFlow(ISensorEventRepository sensorEventRepository)
    {
        _sensorEventRepository = sensorEventRepository;
    }

    public async Task<IEnumerable<SensorEventResponse>> GetGateFlowSummary(Dictionary<string, List<string>> filterParams)
    {
        var filteredExpression = DynamicFilterGenerator.GenerateFilterExpression<SensorEvent>(filterParams);
        return await _sensorEventRepository.GetAllSensorEvents()
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
    }
}