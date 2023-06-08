using Microsoft.AspNetCore.Components;
using NeoRMS.Data;

namespace NeoRMS.Pages
{
    public class RoomsBase: ComponentBase
    {


        public string searchQuery { get; set; }


        [Inject] NavigationManager navigationManager { get; set; }
        public void NavigateTo()
        {
            navigationManager.NavigateTo($"/property/roomsTab");
        }


        protected List<RoomsData> filteredData
        {
            get
            {
                if (string.IsNullOrWhiteSpace(searchQuery))
                    return data;

                return data.Where(data =>
                    data.FloorNumber.ToString().Contains(searchQuery) ||
                    data.PlotNumber.ToString().Contains(searchQuery) ||
                    data.Length.ToString().Contains(searchQuery) ||
                    data.Width.ToString().Contains(searchQuery) ||
                    data.Height.ToString().Contains(searchQuery) ||
                    data.Area.ToString().Contains(searchQuery) ||
                    data.Facilities.Any(facility => facility.Contains(searchQuery, StringComparison.OrdinalIgnoreCase))
                ).ToList();
            }
        }
        public List<RoomsData> Data
        {
            get
            {
                return data;
            }
        }
        List<RoomsData> data = new List<RoomsData>
        {
            new RoomsData
            {
                AgreementNo = "AG0001",
                PropertyName = "Biraj Housing",
                PropertyNo = "P0001",
                FloorNumber = 1,
                PlotNumber = 101,
                Length = 10,
                Width = 12,
                Height = 8,
                Area = 120,
                Facilities = new List<string> { "Electricity", "Water", "Internet", "Tv cable", "Furniture" }
            },
            new RoomsData
            {
                AgreementNo = "AG0002",
                PropertyName = "Biraj Housing",
                PropertyNo = "P0002",
                FloorNumber = 2,
                PlotNumber = 201,
                Length = 11,
                Width = 13,
                Height = 9,
                Area = 143,
                Facilities = new List<string> { "Electricity", "Water", "Internet", "Tv cable", "Furniture", "Kitchenware" }
            },
            new RoomsData
            {
                AgreementNo = "AG0003",
                PropertyName = "Biraj Housing",
                PropertyNo = "P0003",
                FloorNumber = 3,
                PlotNumber = 301,
                Length = 12,
                Width = 14,
                Height = 10,
                Area = 168,
                Facilities = new List<string> { "Electricity", "Water", "Internet", "Tv cable", "Furniture", "Kitchenware", "Garbage Collection" }
            },
            new RoomsData
            {
                AgreementNo = "AG0004",
                PropertyName = "Biraj Housing",
                PropertyNo = "P0004",
                FloorNumber = 4,
                PlotNumber = 401,
                Length = 13,
                Width = 15,
                Height = 11,
                Area = 195,
                Facilities = new List<string> { "Electricity", "Water", "Internet", "Tv cable", "Furniture", "Kitchenware", "Garbage Collection", "Parking" }
            },
            new RoomsData
            {
                AgreementNo = "AG0005",
                PropertyName = "Biraj Housing",
                PropertyNo = "P0005",
                FloorNumber = 5,
                PlotNumber = 501,
                Length = 14,
                Width = 16,
                Height = 12,
                Area = 224,
                Facilities = new List<string> { "Electricity", "Water", "Internet", "Tv cable", "Furniture", "Kitchenware", "Garbage Collection", "Parking", "Terrace" }
            }
        };
    }
}
