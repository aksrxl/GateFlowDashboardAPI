namespace GateFlowDashboardAPI.DataAccess.IRepository
{
    using GateFlowDashboardAPI.EFCore.Models;
    public interface ISensorEventRepository
    {
        /// <summary>
        /// Gets the SensorEvent Data
        /// </summary>
        /// <returns></returns>
        public IQueryable<SensorEvent> GetAllSensorEvents(string correlationId);

        /// <summary>
        /// Saves Sensor Event Data
        /// </summary>
        /// <param name="sensorEvent"></param>
        /// <returns></returns>
        public Task<string> SaveSensorEvent(SensorEvent sensorEvent, string correlationId);
    }
}