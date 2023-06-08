using Microsoft.AspNetCore.Components;
using NeoRMS.Data;

namespace NeoRMS.Pages
{
    public class OwnerdetailBase: ComponentBase
    {

        public string searchQuery { get; set; }


        [Inject] NavigationManager navigationManager { get; set; }
        public void NavigateTo(string logNo)
        {
            navigationManager.NavigateTo($"/property/ownerTab/{logNo}");
        }


        protected List<OwnerData> filteredData
        {
            get
            {
                if (string.IsNullOrWhiteSpace(searchQuery))
                    return data;

                return data.Where(data =>
                    data.AgreementNo.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    data.PropertyNo.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    data.OwnerName.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    data.PhoneNo.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    data.Email.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    data.Address.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)

                ).ToList();
            }
        }

        public List<OwnerData> Data
        {
            get
            {
                return data;
            }
        }



        protected List<OwnerData> data = new List<OwnerData>
        {
            new OwnerData
            {
                AgreementNo = "AG0001",
                PropertyNo = "P0001",
                OwnerName = "Biraj",
                PropertyName = "Biraj Housing",
                PhoneNo = "1234567890",
                Email = "biraj@example.com",
                Address = "Kathmandu, Nepal"
            },
            new OwnerData
            {
                AgreementNo = "AG0002",
                PropertyNo = "P0002",
                OwnerName = "Muna",
                PropertyName = "Muna Housing",
                PhoneNo = "2345678901",
                Email = "muna@example.com",
                Address = "Pokhara, Nepal"
            }, 
            new OwnerData
            {
                AgreementNo = "AG0003",
                PropertyNo = "P0003",
                OwnerName = "Priyanka",
                PropertyName = "Priyanka Housing",
                PhoneNo = "3456789012",
                Email = "priyanka@example.com",
                Address = "Biratnagar, Nepal"
            },
            new OwnerData
            {
                AgreementNo = "AG0004",
                PropertyNo = "P0004",
                OwnerName = "Shaswot",
                PropertyName = "Shaswot Housing",
                PhoneNo = "4567890123",
                Email = "shaswot@example.com",
                Address = "Lalitpur, Nepal"
            },
            new OwnerData
            {
                AgreementNo = "AG0005",
                PropertyNo = "P0005",
                OwnerName = "Sudeshna",
                PropertyName = "Sudeshna Housing",
                PhoneNo = "5678901234",
                Email = "sudeshna@example.com",
                Address = "Bhaktapur, Nepal"
            }
        };

    }
}
