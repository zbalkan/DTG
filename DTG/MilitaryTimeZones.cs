using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DTG
{
    public static class MilitaryTimeZones
    {
        public static ReadOnlyCollection<MilitaryTimeZone> TimeZones { get => new ReadOnlyCollection<MilitaryTimeZone>(GetTimeZoneList()); }

        private static List<MilitaryTimeZone> GetTimeZoneList()
        {
            return new List<MilitaryTimeZone>()
            {
                new MilitaryTimeZone{TimeZoneName = "Alpha", Abbreviation = "A", Offset = +1},
                new MilitaryTimeZone{TimeZoneName = "Bravo", Abbreviation = "B", Offset = +2},
                new MilitaryTimeZone{TimeZoneName = "Charlie", Abbreviation = "C", Offset = +3},
                new MilitaryTimeZone{TimeZoneName = "Delta", Abbreviation = "D", Offset = +4},
                new MilitaryTimeZone{TimeZoneName = "Echo", Abbreviation = "E", Offset = +5},
                new MilitaryTimeZone{TimeZoneName = "Foxtrot", Abbreviation = "F", Offset = +6},
                new MilitaryTimeZone{TimeZoneName = "Golf", Abbreviation = "G", Offset = +7},
                new MilitaryTimeZone{TimeZoneName = "Hotel", Abbreviation = "H", Offset = +8},
                new MilitaryTimeZone{TimeZoneName = "India", Abbreviation = "I", Offset = +9},
                new MilitaryTimeZone{TimeZoneName = "Kilo", Abbreviation = "K", Offset = +10},
                new MilitaryTimeZone{TimeZoneName = "Lima", Abbreviation = "L", Offset = +11},
                new MilitaryTimeZone{TimeZoneName = "Mike", Abbreviation = "M", Offset = +12},
                new MilitaryTimeZone{TimeZoneName = "November", Abbreviation = "N", Offset = -1},
                new MilitaryTimeZone{TimeZoneName = "Oscar", Abbreviation = "O", Offset = -2},
                new MilitaryTimeZone{TimeZoneName = "Papa", Abbreviation = "P", Offset = -3},
                new MilitaryTimeZone{TimeZoneName = "Quebec", Abbreviation = "Q", Offset = -4},
                new MilitaryTimeZone{TimeZoneName = "Romeo", Abbreviation = "R", Offset = -5},
                new MilitaryTimeZone{TimeZoneName = "Sierra", Abbreviation = "S", Offset = -6},
                new MilitaryTimeZone{TimeZoneName = "Tango", Abbreviation = "T", Offset = -7},
                new MilitaryTimeZone{TimeZoneName = "Uniform", Abbreviation = "U", Offset = -8},
                new MilitaryTimeZone{TimeZoneName = "Victor", Abbreviation = "V", Offset = -9},
                new MilitaryTimeZone{TimeZoneName = "Whiskey", Abbreviation = "W", Offset = -10},
                new MilitaryTimeZone{TimeZoneName = "X-ray", Abbreviation = "X", Offset = -11},
                new MilitaryTimeZone{TimeZoneName = "Yankee", Abbreviation = "Y", Offset = -12},
                new MilitaryTimeZone{TimeZoneName = "Zulu", Abbreviation = "Z", Offset = 0}
            };
        }
    }
}
