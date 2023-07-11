namespace GateFlowDashboardAPI.Controllers;

using Microsoft.AspNetCore.Mvc;
using GateFlowDashboardAPI.Models.Response;
using GateFlowDashboardAPI.BusinessLogic.Contract;
using GateFlowDashboardAPI.Models.Request;
using GateFlowDashboardAPI.Enums;
using GateFlowDashboardAPI.Extensions;

[ApiController]
[Route("[controller]/[action]")]
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
    /// <param name="filterParams">filter param eg. {"Gate":["Gate A","Gate B","Gate C"],"Type":["Leave","Enter"],"CreatedDate":["2023-07-06","2023-07-07"]}</param>
    /// <returns></returns>
    [HttpGet("/GetGateFlowSummary")]
    public async Task<ActionResult<IEnumerable<SensorEventResponse>>> Get([FromQuery] Dictionary<string, List<string>> filterParams)
    {
        var resultSet = await _gateFlow.GetGateFlowSummary(filterParams);
        return Ok(resultSet);
    }

    /// <summary>
    /// Generates the data for simulation
    /// </summary>
    /// <param name="gate">Name of the gate. eg 'Gate A'</param>
    /// <param name="type"> Possible values are 'Enter/Leave'</param>
    /// <param name="dateTime">DateTime in zulu format eg. 2023-07-11T10:09:08.139Z</param>
    /// <returns>id of the created record</returns>
    [HttpPost("/GenerateRecordForSimulation/gate/type/{dateTime}")]
    public async Task<ActionResult<string>> Post(string gate, string type, DateTime dateTime)
    {
        gate.Required(nameof(gate));
        type.Required(nameof(type));
        var id = await _gateFlow.GenerateRecordForSimulation(gate, type, dateTime);
        return Ok(id);
    }
}