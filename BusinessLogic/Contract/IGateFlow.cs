namespace GateFlowDashboardAPI.BusinessLogic.Contract;

using GateFlowDashboardAPI.Models.Response;
using GateFlowDashboardAPI.Enums;

public interface IGateFlow
{
    public Task<IEnumerable<SensorEventResponse>> GetGateFlowSummary(Dictionary<string, List<string>> filterParams);

    public Task<string> GenerateRecordForSimulation(string gate, string type, DateTime dateTime);

}