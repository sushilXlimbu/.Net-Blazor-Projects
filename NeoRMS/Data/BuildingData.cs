using System.Numerics;

namespace NeoRMS.Data
{
    public class BuildingData
    {
        public string BuildingName { get; set; }
        public string BuildingType { get; set;}
        public string OccupancyStatus { get; set;}
        public int NumberOfBlock { get; set;}
        public string Country { get; set; }
        public BigInteger PostalCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string StreetAddress { get; set; }

    }
}
