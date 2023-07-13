namespace GateFlowDashboardAPI.EFCore
{
    using GateFlowDashboardAPI.EFCore.Models;
    using Microsoft.EntityFrameworkCore;
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }

        protected override void OnConfiguring
       (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "MyDatabase");
        }
        public DbSet<SensorEvent> SensorEvent { get; set; }
    }
}