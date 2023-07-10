namespace GateFlowDashboardAPI.EFCore
{
        using GateFlowDashboardAPI.EFCore.Models;
        using GateFlowDashboardAPI.Enums;

        public class SeedGenerator
        {
                public void SeedData(ApiContext context)
                {
                        var sensorEvents = new List<SensorEvent>{
                                new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-2),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-2),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-3)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-5),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-4),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-3)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-4),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-2),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-2),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-4),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate A",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-2),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-3)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-5),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-4),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-3)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-4),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-2),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-2),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-4),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate B",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-2),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-3)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-5),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-4),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-3)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-4),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-2),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-2),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-4),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate C",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-3)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-5),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-4),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-3)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-4),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-2),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-2),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-4),
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now.AddDays(-1)
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Leave),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now
                                }, new SensorEvent
                                {
                                        Id = Guid.NewGuid().ToString(),
                                        Gate = "Gate D",
                                        Type = nameof(Type.Enter),
                                        CreatedDate = DateTime.Now
                                }
};
                        context.SensorEvent.AddRange(sensorEvents);
                        context.SaveChanges();
                }
        }
}