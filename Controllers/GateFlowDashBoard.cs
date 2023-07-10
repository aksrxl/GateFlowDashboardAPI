namespace GateFlowDashboardAPI.Controllers;

using Microsoft.AspNetCore.Mvc;
using GateFlowDashboardAPI.Models.Response;
using GateFlowDashboardAPI.BusinessLogic.Contract;

[ApiController]
[Route("[controller]")]
public class GateFlowDashBoard : ControllerBase
{
    private readonly IGateFlow _gateFlow;
    public GateFlowDashBoard(IGateFlow gateFlow)
    {
        _gateFlow = gateFlow;
    }

    /// <summary>
    /// Gets the list of sensor events grouped by gate and type
    /// </summary>
    /// <returns></returns>
    [HttpGet(Name = "GetGateFlowSummary")]
    public async Task<IEnumerable<SensorEventResponse>> Get([FromQuery] Dictionary<string, List<string>> filterParams)
    {
        return await _gateFlow.GetGateFlowSummary(filterParams);
    }
}