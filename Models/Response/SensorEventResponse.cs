namespace GateFlowDashboardAPI.Models.Response;

public class SensorEventResponse
{
    public string Gate { get; set; }
    public string Type { get; set; }
    public int NumberOfPeople { get; set; }
    public DateTime CreatedDateFrom { get; set; }
    public DateTime CreatedDateTo { get; set; }
}