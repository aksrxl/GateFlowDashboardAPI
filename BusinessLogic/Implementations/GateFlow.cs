namespace GateFlowDashboardAPI.BusinessLogic.Implementations;

using GateFlowDashboardAPI.BusinessLogic.Contract;
using GateFlowDashboardAPI.DataAccess.IRepository;
using GateFlowDashboardAPI.Models.Response;
using Microsoft.EntityFrameworkCore;

public class GateFlow : IGateFlow
{

    private readonly ISensorEventRepository _sensorEventRepository;

    public GateFlow(ISensorEventRepository sensorEventRepository)
    {
        _sensorEventRepository = sensorEventRepository;
    }

    public async Task<IEnumerable<SensorEventResponse>> GetGateFlowSummary()
    {
        return await _sensorEventRepository.GetAllSensorEvents().GroupBy(e => new { e.Gate, e.Type })
    .Select(g => new SensorEventResponse
    {
        Gate = g.Key.Gate,
        Type = g.Key.Type,
        NumberOfPeople = g.Count()
    })
    .ToListAsync();
    }
}