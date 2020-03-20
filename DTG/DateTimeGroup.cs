﻿using System;
using System.Globalization;

namespace DTG
{
    public class DateTimeGroup
    {
        public string DayCode { get; }
        public string HourCode { get; }
        public string MinuteCode { get; }
        public string MonthCode { get; }
        public string YearCode { get; }
        public int Day { get; }
        public int Hour { get; }
        public int Minute { get; }
        public int Month { get; }
        public int Year { get; }
        public MilitaryTimeZone MilitaryTimeZone { get; }
        public DateTime DateTime { get; }
        public TimeZoneInfo TimeZoneInfo { get; set; }

        public DateTimeGroup(DateTime dateTime, TimeZoneInfo timeZoneInfo)
        {
            // Original values
            Day = dateTime.Day;
            Hour = dateTime.Hour;
            Minute = dateTime.Minute;
            Month = dateTime.Month;
            Year = dateTime.Year;

            // Formatted values
            DayCode = dateTime.ToString("dd", CultureInfo.InvariantCulture);
            HourCode = dateTime.ToString("HH", CultureInfo.InvariantCulture);
            MinuteCode = dateTime.ToString("mm", CultureInfo.InvariantCulture);
            MonthCode = dateTime.ToString("MMM", CultureInfo.InvariantCulture).ToUpperInvariant();
            YearCode = dateTime.ToString("yy", CultureInfo.InvariantCulture);

            // Calculated values
            MilitaryTimeZone = timeZoneInfo.ToMilTimeZone();
        }

        public override string ToString()
        {
            return $"{DayCode}{HourCode}{MinuteCode}{MilitaryTimeZone.Abbreviation} {MonthCode} {YearCode}";
        }
    }
}
