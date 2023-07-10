namespace GateFlowDashboardAPI.EFCore.Models;

public class SensorEvent
{
    public string Id { get; set; }
    public string Gate { get; set; }
    public string Type { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}