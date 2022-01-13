using System;

namespace DateConverter.Infrastructure
{
    public static class DateTimeExtensions
    {
        public static DateTime Blend(this DateTime source, DateTime time)
        {
            return new DateTime(source.Year, source.Month, source.Day, time.Hour, time.Minute, time.Second);
        }

        public static string ToDisplayString(this DateTime source)
        {
            return source.ToString("o").Replace(".0000000", string.Empty);
        }

        public static string ToDisplayString(this DateTimeOffset source)
        {
            return source.ToString("o").Replace(".0000000", string.Empty);
        }
    }
}
