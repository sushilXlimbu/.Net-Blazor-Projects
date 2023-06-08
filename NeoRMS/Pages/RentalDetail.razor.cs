using Microsoft.AspNetCore.Components;
using NeoRMS.Data;

namespace NeoRMS.Pages
{
    public class RentalDetailBase:ComponentBase
    {

        [Inject] NavigationManager navigationManager { get; set; }

        public void NavigateTo(string logNo)
        {
            navigationManager.NavigateTo($"/rentalmanagement/rentaldetailTab/{logNo}");
        }
        public List<RentalData> rentalData = new List<RentalData>()
        {
            new RentalData
            {
                LogNo="Log0041",
                AgreementNo = "A001",
                PropertyName = "Biraj Apartment",
                Address = "kalanki",
                BlockNo = "1",
                FloorNo = "2",
                RoomNo = "3",
                RentalType = "Yearly",
                IncrementMethod = "5% per Year",
                Penalty = "1%"

            },
            new RentalData
            {
                LogNo="Log0042",
                AgreementNo = "A002",
                PropertyName = "Sujan Apartment",
                Address = "Balaju",
                BlockNo = "2",
                FloorNo = "12",
                RoomNo = "4",
                RentalType = "Yearly",
                IncrementMethod = "5% per Year",
                Penalty = "1%"

            },
            new RentalData
            {
                LogNo="Log0043",
                AgreementNo = "A003",
                PropertyName = "Priyanka Housing",
                Address = "Koteyshowr",
                BlockNo = "1",
                FloorNo = "1",
                RoomNo = "3",
                RentalType = "Yearly",
                IncrementMethod = "5% per Year",
                Penalty = "1%"

            },
            new RentalData
            {
                LogNo="Log0044",
                AgreementNo = "A004",
                PropertyName = "Suman Colony",
                Address = "Ranibari",
                BlockNo = "4",
                FloorNo = "3",
                RoomNo = "6",
                RentalType = "Yearly",
                IncrementMethod = "5% per Year",
                Penalty = "1%"

            }
        };
    }
}
