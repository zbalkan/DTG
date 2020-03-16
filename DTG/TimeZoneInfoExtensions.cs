using System;
using System.Linq;

namespace DTG
{
    public static class TimeZoneInfoExtensions
    {
        public static MilitaryTimeZone ToMilTimeZone(this TimeZoneInfo timeZoneInfo)
        {
            return MilitaryTimeZones.TimeZones.FirstOrDefault(tz => tz.Offset == timeZoneInfo.BaseUtcOffset.Hours);
        }

        public static TimeZoneInfo FromMilTimeZone(this TimeZoneInfo timeZoneInfo, MilitaryTimeZone milTimeZone)
        {
            timeZoneInfo = TimeZoneInfo.GetSystemTimeZones().FirstOrDefault(tz => tz.BaseUtcOffset.Hours == milTimeZone.Offset);
            return timeZoneInfo;
        }
    }
}
