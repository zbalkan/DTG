using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace DTG
{
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Local")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    public class DateTimeGroup
    {
        public DateTimeGroup(DateTime dateTime, TimeZoneInfo timeZoneInfo)
        {
            if (timeZoneInfo == null) throw new ArgumentNullException(nameof(timeZoneInfo));
            
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

        public string DayCode { get; private set; }
        public string HourCode { get; private set; }
        public string MinuteCode { get; private set;}
        public string MonthCode { get; private set;}
        public string YearCode { get; private set;}
        public int Day { get; private set;}
        public int Hour { get; private set;}
        public int Minute { get; private set;}
        public int Month { get; private set;}
        public int Year { get; private set;}
        public MilitaryTimeZone MilitaryTimeZone { get; private set;}
        public DateTime DateTime { get; private set;}
        public TimeZoneInfo TimeZoneInfo { get; private set; }

        public override string ToString() =>
            $"{DayCode}{HourCode}{MinuteCode}{MilitaryTimeZone.Abbreviation} {MonthCode} {YearCode}";
    }
}