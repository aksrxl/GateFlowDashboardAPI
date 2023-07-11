namespace GateFlowDashboardAPI.Extensions;

public static class Extension
{

    public static void Required(this string input, string paramName)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new InvalidOperationException($"{paramName} is required.");
        }
    }

    public static void CheckDateFormat(this string input)
    {
        if (!DateTime.TryParse(input, out var _))
        {
            throw new InvalidOperationException($"{input} is not a valid date");
        }
    }
}