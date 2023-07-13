namespace GateFlowDashboardAPI.Extensions
{
    public static class Extension
    {
        public static void Required<T>(this T argument, string argumentName)
        {
            if (argument == null)
            {
                throw new InvalidOperationException($"{argumentName} is required.");
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
}