using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;

namespace DTG
{
    public class DateTimeGroup
    {
        private TimeZoneInfo _timeZoneInfo;
        private int timeZoneOffset;
        private MilitaryTimeZone _militaryTimeZone;

        public DateTime DateTime { get; set; }
        public int TimeZoneOffset
        {
            get
            {
                return timeZoneOffset;
            }

            set
            {
                timeZoneOffset = value;
                _timeZoneInfo = TimeZoneInfo.GetSystemTimeZones().FirstOrDefault(tz => tz.BaseUtcOffset.Hours == timeZoneOffset);
                _militaryTimeZone = _timeZoneInfo.ToMilTimeZone();
            }
        }
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
        public MilitaryTimeZone MilitaryTimeZone { get => _militaryTimeZone; private set => _militaryTimeZone = value; }

        public override string ToString() =>
            $"{DayCode}{HourCode}{MinuteCode}{MilitaryTimeZone.Abbreviation} {MonthCode} {YearCode}";
    }
}