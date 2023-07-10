namespace GateFlowDashboardAPI.DataAccess.IRepository;

using GateFlowDashboardAPI.EFCore.Models;
public interface ISensorEventRepository
{
    public IQueryable<SensorEvent> GetAllSensorEvents();
}