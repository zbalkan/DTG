using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace DTG.Tests
{
    [TestClass]
    public class DateTimeGroupTests
    {
        [TestMethod]
        public void TestForZulu()
        {
            var dtg = new DateTimeGroup(DateTime.Now, TimeZoneInfo.Utc);

            Assert.AreEqual("Z", dtg.MilitaryTimeZone.Abbreviation);
            Assert.AreEqual("Zulu", dtg.MilitaryTimeZone.TimeZoneName);
            Assert.AreEqual(0, dtg.MilitaryTimeZone.Offset);
        }


        [TestMethod]
        public void TestForAlpha()
        {
            var dtg = new DateTimeGroup(DateTime.Now, TimeZoneInfo.GetSystemTimeZones().ToList().FirstOrDefault(tz => tz.BaseUtcOffset.Hours == 1));

            Assert.AreEqual("A", dtg.MilitaryTimeZone.Abbreviation);
            Assert.AreEqual("Alpha", dtg.MilitaryTimeZone.TimeZoneName);
            Assert.AreEqual(1, dtg.MilitaryTimeZone.Offset);
        }
    }
}
