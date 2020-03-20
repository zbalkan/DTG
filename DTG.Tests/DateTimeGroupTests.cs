using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DTG.Tests
{
    [TestClass]
    public class DateTimeGroupTests
    {
        public static IEnumerable<object[]> Data
        {
            get
            {
                yield return new object[] {"Alpha", "A", 1};
                yield return new object[] {"Bravo", "B", 2};
                yield return new object[] {"Charlie", "C", 3};
                yield return new object[] {"Delta", "D", 4};
                yield return new object[] {"Echo", "E", 5};
                yield return new object[] {"Foxtrot", "F", 6};
                yield return new object[] {"Golf", "G", 7};
                yield return new object[] {"Hotel", "H", 8};
                yield return new object[] {"India", "I", 9};
                yield return new object[] {"Kilo", "K", 10};
                yield return new object[] {"Lima", "L", 11};
                yield return new object[] {"Mike", "M", 12};
                yield return new object[] {"November", "N", -1};
                yield return new object[] {"Oscar", "O", -2};
                yield return new object[] {"Papa", "P", -3};
                yield return new object[] {"Quebec", "Q", -4};
                yield return new object[] {"Romeo", "R", -5};
                yield return new object[] {"Sierra", "S", -6};
                yield return new object[] {"Tango", "T", -7};
                yield return new object[] {"Uniform", "U", -8};
                yield return new object[] {"Victor", "V", -9};
                yield return new object[] {"Whiskey", "W", -10};
                yield return new object[] {"X-ray", "X", -11};
                yield return new object[] {"Yankee", "Y", -12};
                yield return new object[] {"Zulu", "Z", 0};
            }
        }

        [DataTestMethod]
        [DynamicData(nameof(Data))]
        public void TestForData(string name, string abbr, int offset)
        {
            var dtg = new DateTimeGroup(DateTime.Now,
                TimeZoneInfo.GetSystemTimeZones().ToList().FirstOrDefault(tz => tz.BaseUtcOffset.Hours == offset));

            Assert.AreEqual(abbr, dtg.MilitaryTimeZone.Abbreviation);
            Assert.AreEqual(name, dtg.MilitaryTimeZone.TimeZoneName);
            Assert.AreEqual(offset, dtg.MilitaryTimeZone.Offset);
        }
    }
}