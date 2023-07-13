namespace GateFlowDashboardAPI.Controllers
{
    using GateFlowDashboardAPI.BusinessLogic.Contract;
    using GateFlowDashboardAPI.Extensions;
    using GateFlowDashboardAPI.Models.Response;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using static Constants;

    [ApiController]
    [Route("[controller]/[action]")]
    public class GateFlowDashBoard : ControllerBase
    {
        private readonly IGateFlow _gateFlow;
        private readonly ILogger<GateFlowDashBoard> _logger;
        public GateFlowDashBoard(IGateFlow gateFlow, ILogger<GateFlowDashBoard> logger)
        {
            _gateFlow = gateFlow;
            _logger = logger;
        }

        /// <summary>
        /// Gets the list of sensor events grouped by gate and type
        /// </summary>
        /// <param name="filterParams">filter param eg. {"Gate":["Gate A","Gate B","Gate C"],"Type":["Leave","Enter"],"CreatedDate":["yyyy-mm-dd","yyyy-mm-dd"]}</param>
        /// <returns></returns>
        [HttpGet("/GetGateFlowSummary")]
        public async Task<ActionResult<IEnumerable<SensorEventResponse>>> Get([FromQuery] Dictionary<string, List<string>> filterParams)
        {
            var correlationId = Guid.NewGuid().ToString(); // Generate new or retriev from the request
            _logger.LogInformation(DefaultLogger, correlationId, DateTime.UtcNow, "Invoked GetGateFlowSummary Endpoint.");
            var resultSet = await _gateFlow.GetGateFlowSummary(filterParams, correlationId);
            _logger.LogInformation(DefaultLogger, correlationId, DateTime.UtcNow, "Invoking GetGateFlowSummary Endpoint Finished.");
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
            var correlationId = Guid.NewGuid().ToString(); // Generate new or retriev from the request
            _logger.LogInformation(DefaultLogger, correlationId, DateTime.UtcNow, "Invoked GenerateRecordForSimulation Endpoint.");
            var id = await _gateFlow.GenerateRecordForSimulation(gate, type, dateTime, correlationId);
            _logger.LogInformation(DefaultLogger, correlationId, DateTime.UtcNow, "Finished GetGateFlowSummary Endpoint Finished.");
            return Ok(id);
        }
    }
}