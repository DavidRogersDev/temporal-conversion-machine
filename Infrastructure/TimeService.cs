using System;
using System.Collections.Generic;
using System.Linq;

namespace DateConverter.Infrastructure
{
    public class TimeService
    {
        public TimeService()
        {
        }
        
        public DateTimeOffset ConvertToZonedOffset(DateTimeOffset toConvert, string targetTimezone)
        {
            var universalTime = toConvert.ToUniversalTime();
            var dateTimeOffset = TimeZoneInfo.ConvertTime(universalTime, TimeZoneInfo.FindSystemTimeZoneById(targetTimezone));

            return dateTimeOffset;
        }

        public TimeSpan GetOffsetForZone(string zoneId, DateTime dateForOffset)
        {
            return TimeZoneInfo.FindSystemTimeZoneById(zoneId).GetUtcOffset(dateForOffset);
        }

        public static IReadOnlyCollection<TimeZoneInfo> TimeZoneInfos = TimeZoneInfo.GetSystemTimeZones();

        public List<KeyValuePair<string, string>> TimeZonesList() => (
            from timeZoneInfo in TimeZoneInfos
            let placesInTimeZone = timeZoneInfo.DisplayName.Substring(timeZoneInfo.DisplayName.IndexOf(')') + 1)
            let places = placesInTimeZone.Split(",", StringSplitOptions.RemoveEmptyEntries)
            from place in places
            select new KeyValuePair<string, string>(timeZoneInfo.Id, place)
        ).ToList();

        public TimeSpan GetOffsetFromId(string zoneId) => TimeZoneInfos.Single(t => t.Id == zoneId).BaseUtcOffset;
    }
}
