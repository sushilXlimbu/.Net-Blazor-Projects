using Microsoft.AspNetCore.Components.Web;

namespace NeoRMS.Data
{
    public class RoomsData
    {

        public string AgreementNo { get; set; }
        public string PropertyName { get; set; }

        public string PropertyNo { get; set; }

        public int FloorNumber { get; set; }

        public int PlotNumber { get; set; }

        public float Length { get; set; }

        public float Width { get; set; }

        public float Height { get; set; }

        public float Area { get; set; }

        public List<String> Facilities { get; set; }
    }
}
