using System.ComponentModel.DataAnnotations.Schema;

namespace DTG
{
    [ComplexType]
    public sealed class MilitaryTimeZone
    {
        public string TimeZoneName { get; set; }
        public int Offset { get; set; }
        public string Abbreviation { get; set; }
    }
}