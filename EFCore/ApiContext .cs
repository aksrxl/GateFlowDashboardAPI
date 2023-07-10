namespace GateFlowDashboardAPI.EFCore
{
    using Microsoft.EntityFrameworkCore;
    using GateFlowDashboardAPI.EFCore.Models;
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