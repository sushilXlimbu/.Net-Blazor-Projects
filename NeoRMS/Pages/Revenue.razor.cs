using Microsoft.AspNetCore.Components;
using System.Reflection;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NeoRMS.Pages
{
    public class RevenueBase: ComponentBase
    {

        public string searchQuery { get; set; }

        [Inject] NavigationManager navigationManager { get; set; }
        public void NavigateTo(string logNo)
        {
            navigationManager.NavigateTo($"/rentalmanagement/revenueTab/{logNo}");
        }


        PropertyBase propertyBase = new PropertyBase();
        protected List<RevenueData> data { get; set; }


        protected override void OnInitialized()
        {
           data= propertyBase.Data;
           // Console.WriteLine(data.Count);
        }

        public List<RevenueData> filteredData
        {
            get
            {
                if (string.IsNullOrWhiteSpace(searchQuery))
                    return data;

                return data.Where(data =>
                    data.AgreementNo.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    data.PropertyNo.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    data.PaymentMethod.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    data.Reason.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    (data.ReceivedAmount + "").Contains(searchQuery) ||
                    (data.TpsDeduction + "").Contains(searchQuery) ||
                    (data.Rebate + "").Contains(searchQuery)

                ).ToList();
            }
        }


    }
 


    public class RevenueData
    {

        public string AgreementNo { get; set; }
        public string LogNo { get; set; }

        public string PropertyNo { get; set; }
        public string PropertyName { get; set; }
        public string DocumentName { get; set; }
        public string DocumentType { get; set; }
        public string File { get; set; }
        public string MaintenanceType { get; set; }

        public DateOnly date { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        public float ReceivedAmount { get; set; }

        public string PaymentMethod { get; set; }

        public float TpsDeduction { get; set; }

        public float Rebate { get; set; }

        public string Reason { get; set; }

    }

}
