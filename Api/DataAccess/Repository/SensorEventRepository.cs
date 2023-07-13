namespace GateFlowDashboardAPI.DataAccess.Repository
{
    using GateFlowDashboardAPI.DataAccess.IRepository;
    using GateFlowDashboardAPI.EFCore;
    using GateFlowDashboardAPI.EFCore.Models;
    using System.Linq;
    using System.Threading.Tasks;

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

        public async Task<string> SaveSensorEvent(SensorEvent sensorEvent)
        {
            var entity = await _apiContext.SensorEvent.AddAsync(sensorEvent);
            await _apiContext.SaveChangesAsync();
            return entity.Entity.Id;
        }
    }
}