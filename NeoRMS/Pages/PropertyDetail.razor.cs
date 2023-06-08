using Microsoft.AspNetCore.Components;
using NeoRMS.Data;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NeoRMS.Pages
{
    public class PropertyDetailBase : ComponentBase
    {
        public string searchQuery { get; set; }

        public bool companyModal { get; set; }
        public bool individualModal { get; set; }




        public void showCompanyModal()
        {
            companyModal = true;
        }
        public void showIndividualModal()
        {
            individualModal = true;
        }
        protected List<PropertyData> filteredData
        {
            get
            {
                if (string.IsNullOrWhiteSpace(searchQuery))
                    return data;

                return data.Where(data =>
                    data.AgreementNo.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    data.Type.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    data.Name.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    data.Address.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    (data.Number_of_Rooms + "").Contains(searchQuery) ||
                    (data.Owned_By + "").Contains(searchQuery)

                ).ToList();
            }
        }

        [Inject] NavigationManager navigationManager { get; set; }

        public void NavigateTo(string logNo)
        {
            navigationManager.NavigateTo($"/property/propertyTab/{logNo}");
        }





        protected async Task closeCompanyModal()
        {

            companyModal = false;
        }
        protected async Task closeIndividualModal()
        {

            individualModal = false;
        }

        public List<PropertyData> Data
        {
            get { return data; }
        }

        protected List<PropertyData> data = new List<PropertyData>()
        {
            new PropertyData
            {
                AgreementNo = "AG1220",
                LogNo = "0041",
                Type = "House",
                Name = "Neo",
                Address = "Damak",
                Number_of_Rooms = 8,
                Owned_By = "Company",
                No_Of_Floors = 2,
                RentalType = "Lease 10 years",
                IncrementMethod = "Yearly",

                PenaltyRate = 0.05,
                Date = DateOnly.FromDateTime(new DateTime(2023, 04, 11))

            },
            new PropertyData
            {
                AgreementNo = "AG1221",
                LogNo = "0042",
                Type = "House",
                Name = "sushil",
                Date = DateOnly.FromDateTime(new DateTime(2023, 08, 01)),
                Address = "Balaju",
                Number_of_Rooms = 5,
                Owned_By = "Individual",
                No_Of_Floors = 1,
                RentalType = "Lease 5 years",
                IncrementMethod = "Monthly",
                PenaltyRate = 0.03
            },
            new PropertyData
            {
                AgreementNo = "AG1222",
                LogNo = "0043",
                Type = "Apartment",
                Date = DateOnly.FromDateTime(new DateTime(2023, 02, 12)),
                Name = "CG",
                Address = "Lalitpur",
                Number_of_Rooms = 5,
                No_Of_Floors = 1,
                Owned_By = "Company",
                RentalType = "Yearly",
                IncrementMethod = "Yearly",
                PenaltyRate = 0.06
            },
            new PropertyData
            {
                AgreementNo = "AG1223",
                LogNo = "0044",
                Type = "Commercial",
                Date = DateOnly.FromDateTime(new DateTime(2023, 04, 05)),
                Name = "Rajib",
                Address = "Nayabazar",
                Number_of_Rooms = 12,
                No_Of_Floors = 3,
                Owned_By = "Individual",
                RentalType = "Quarterly",
                IncrementMethod = "Monthly",
                PenaltyRate = 0.08
            },
            new PropertyData
            {
                AgreementNo = "AG1224",
                LogNo = "0045",
                Type = "House",
                Date = DateOnly.FromDateTime(new DateTime(2023, 12, 01)),
                Name = "Ninad",
                Address = "Kathmandu",
                Number_of_Rooms = 8,
                No_Of_Floors = 2,
                Owned_By = "Individual",
                RentalType = "Monthly",
                IncrementMethod = "Monthly",
                PenaltyRate = 0.02
            },
            new PropertyData
            {
                AgreementNo = "AG1225",
                LogNo = "0045",
                Date = DateOnly.FromDateTime(new DateTime(2023, 04, 03)),
                Type = "Apartment",
                Name = "Biraj",
                Address = "Birathnagar",
                Number_of_Rooms = 9,
                No_Of_Floors = 2,
                Owned_By = "Company",
                RentalType = "Lease 10 years",
                IncrementMethod = "Yearly",
                PenaltyRate = 0.04
            },
        };

    }
}
