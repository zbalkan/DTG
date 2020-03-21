using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace DTG
{
    public class DateTimeGroup
    {
        public DateTime DateTime { get; set; }
        public TimeZoneInfo TimeZoneInfo { get; set; }
        public string DayCode => DateTime.ToString("dd", CultureInfo.InvariantCulture);
        public string HourCode => DateTime.ToString("HH", CultureInfo.InvariantCulture);
        public string MinuteCode => DateTime.ToString("mm", CultureInfo.InvariantCulture);
        public string MonthCode => DateTime.ToString("MMM", CultureInfo.InvariantCulture).ToUpperInvariant();
        public string YearCode => DateTime.ToString("yy", CultureInfo.InvariantCulture);
        public int Day => DateTime.Day;
        public int Hour => DateTime.Hour;
        public int Minute => DateTime.Minute;
        public int Month => DateTime.Month;
        public int Year => DateTime.Year;
        public MilitaryTimeZone MilitaryTimeZone => TimeZoneInfo.ToMilTimeZone();

        public override string ToString() =>
            $"{DayCode}{HourCode}{MinuteCode}{MilitaryTimeZone.Abbreviation} {MonthCode} {YearCode}";
    }
}