using Microsoft.AspNetCore.Components;
using NeoRMS.Data;

namespace NeoRMS.Pages
{
    public class MaintenanceBase: ComponentBase
    {

        public string searchQuery { get; set; }

        protected List<MaintenanceData> filteredData
        {
            get
            {
                if (string.IsNullOrWhiteSpace(searchQuery))
                    return data;

                return data.Where(data =>
                    data.AggreementNo.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    data.PropertyNo.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    data.MaintenanceType.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    data.CostBearer.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    (data.MaintenanceCost + "").Contains(searchQuery)

                ).ToList();
            }
        }

        [Inject] NavigationManager navigationManager { get; set; }

        public void NavigateTo(string logNo)
        {
            navigationManager.NavigateTo($"/property/maintenanceTab/{logNo}");
        }


        protected List<MaintenanceData> data = new List<MaintenanceData>
        {
            new MaintenanceData
            {
                AggreementNo = "AG0001",
                LogNo = "Log0041",
                PropertyNo = "P0001",
                PropertyName = "Sudeshna House",
                date = DateOnly.FromDateTime(new DateTime(2022, 1, 1)),
                MaintenanceType = "Painting",
                MaintenanceCost = 1000.00f,
                CostBearer = "Tenant"
            },
            new MaintenanceData
            {
                AggreementNo = "AG0002",
                LogNo = "Log0041",
                PropertyNo = "P0002",
                PropertyName = "Bijay House",
                date = DateOnly.FromDateTime(new DateTime(2022, 2, 3)),
                MaintenanceType = "Electricity",
                MaintenanceCost = 2000.00f,
                CostBearer = "Landlord"
            },
            new MaintenanceData
            {
                AggreementNo = "AG0003",
                LogNo = "Log0041",
                PropertyNo = "P0003",
                PropertyName = "Manisha House",
                date = DateOnly.FromDateTime(new DateTime(2022, 2, 10)),
                MaintenanceType = "Plumbing",
                MaintenanceCost = 3000.00f,
                CostBearer = "Tenant"
            },
            new MaintenanceData
            {
                AggreementNo = "AG0004",
                LogNo = "Log0041",
                PropertyNo = "P0004",
                PropertyName = "Sushil House",
                date = DateOnly.FromDateTime(new DateTime(2022, 5, 3)),
                MaintenanceType = "HVAC",
                MaintenanceCost = 4000.00f,
                CostBearer = "Landlord"
            },
            new MaintenanceData
            {
                AggreementNo = "AG0005",
                LogNo = "Log0041",
                PropertyNo = "P0005",
                PropertyName = "Sujan House",
                date = DateOnly.FromDateTime(new DateTime(2022, 5, 21)),
                MaintenanceType = "Landscaping",
                MaintenanceCost = 5000.00f,
                CostBearer = "Tenant"
            }
        };

    }
}
