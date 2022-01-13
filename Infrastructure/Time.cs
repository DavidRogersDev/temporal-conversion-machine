using System;
using System.Linq;
using System.Collections.Generic;

namespace DateConverter.Infrastructure
{
    public sealed class Time
    {
        public static readonly List<KeyValuePair<string, string>> Ti =  (
            from timeZoneInfo in TimeZoneInfo.GetSystemTimeZones()
            let placesInTimeZone = timeZoneInfo.DisplayName.Substring(timeZoneInfo.DisplayName.IndexOf(')') + 1)
            let places = placesInTimeZone.Split(",", StringSplitOptions.RemoveEmptyEntries)
            from place in places
            select new KeyValuePair<string, string>(timeZoneInfo.Id, place)
        ).ToList();
    }
}
