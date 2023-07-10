namespace GateFlowDashboardAPI.DataAccess.Repository;

using GateFlowDashboardAPI.DataAccess.IRepository;
using GateFlowDashboardAPI.EFCore;
using GateFlowDashboardAPI.EFCore.Models;
using System.Linq;

public class SensorEventRepository : ISensorEventRepository
{
    private readonly ApiContext _apiContext;
    public SensorEventRepository(ApiContext apiContext)
    {
        _apiContext = apiContext;
    }

    public IQueryable<SensorEvent> GetAllSensorEvents()
    {
        return _apiContext.SensorEvent.AsQueryable();
    }
}