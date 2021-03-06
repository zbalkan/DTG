﻿using System;
using System.Linq;

namespace DTG
{
    public static class TimeZoneInfoExtensions
    {
        public static MilitaryTimeZone ToMilTimeZone(this TimeZoneInfo timeZoneInfo)
        {
            if (timeZoneInfo == null) throw new ArgumentNullException(nameof(timeZoneInfo));
            return MilitaryTimeZones.GetByOffset(timeZoneInfo.BaseUtcOffset.Hours);
        }

        public static TimeZoneInfo FromMilTimeZone(this TimeZoneInfo timeZoneInfo, MilitaryTimeZone milTimeZone)
        {
            if (timeZoneInfo == null) throw new ArgumentNullException(nameof(timeZoneInfo));
            if (milTimeZone == null) throw new ArgumentNullException(nameof(milTimeZone));
            timeZoneInfo = TimeZoneInfo.GetSystemTimeZones()
                .FirstOrDefault(tz => tz.BaseUtcOffset.Hours == milTimeZone.Offset && tz.BaseUtcOffset.Minutes == 0);
            return timeZoneInfo;
        }
    }
}