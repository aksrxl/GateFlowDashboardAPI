namespace GateFlowDashboardAPI.Extensions
{
    using System;
    using static Constants;
    using Type = Enums.Type;

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

        public static void IsValidEnumValue<TEnum, T>(this string value, ILogger<T> logger, string correlationId) where TEnum : struct, Enum
        {
            var isValid = Enum.TryParse<TEnum>(value, out _);
            if (!isValid)
            {
                var enums = Enum.GetNames(typeof(Type));
                var message = $"{value} is not a valid value for type.Possible values are '{string.Join("/", enums)}'";
                logger.LogError(DefaultLogger, correlationId, DateTime.UtcNow, message);
                throw new InvalidOperationException(message);
            }
        }
    }
}