using System;

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
    }
}
