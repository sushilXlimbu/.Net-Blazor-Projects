using Microsoft.AspNetCore.Components;
using static System.Runtime.InteropServices.JavaScript.JSType;
using NeoRMS.Data;

namespace NeoRMS.Pages
{
    public class TerminationBase: ComponentBase
    {

        public string searchQuery { get; set; }


        protected List<TerminationData> filteredData
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
                    data.TerminatedBy.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    (data.SettlementAmount + "").Contains(searchQuery)

                ).ToList();
            }
        }
 

        [Inject] NavigationManager navigationManager { get; set; }
        public void NavigateTo(string logNo)
        {
            navigationManager.NavigateTo($"/rentalmanagement/terminationTab/{logNo}");
        }

        public List<TerminationData> Data
        {
            get
            {
                return data;
            }
        }

        protected List<TerminationData> data = new List<TerminationData>
        {
            new TerminationData
            {
                AgreementNo = "AG0001",
                LogNo = "Log0040",
                PropertyNo = "P0001",
                PropertyName = "Biraj Housing",
                date = DateOnly.FromDateTime(new DateTime(2023, 04, 11)),
                Time = new TimeOnly(11,30),
                Reason = "End of contract",
                SettlementAmount = 10000.00f,
                PaymentMethod = "Cash",
                TerminatedBy = "Biraj"
            },
            new TerminationData
            {
                AgreementNo = "AG0002",
                PropertyNo = "P0002",
                LogNo = "Log0041",
                PropertyName = "Bijay Housing",
                date = DateOnly.FromDateTime(new DateTime(2023, 04, 10)),
                Time = new TimeOnly(23,00),
                Reason = "End of contract",
                SettlementAmount = 20000.00f,
                PaymentMethod = "Cash",
                TerminatedBy = "Muna"
            },
            new TerminationData
            {
                AgreementNo = "AG0003",
                PropertyNo = "P0003",
                LogNo = "Log0042",
                PropertyName = "Muna Housing",
                date = DateOnly.FromDateTime(new DateTime(2023, 04, 09)),
                Time = new TimeOnly(05,12),
                Reason = "End of contract",
                SettlementAmount = 15000.00f,
                PaymentMethod = "Cash",
                TerminatedBy = "Priyanka"
            },
            new TerminationData
            {
                AgreementNo = "AG0004",
                PropertyNo = "P0004",
                LogNo = "Log0043",
                PropertyName = "Saswat Housing",
                date = DateOnly.FromDateTime(new DateTime(2023, 04, 08)),
                Time = new TimeOnly(09,02),
                Reason = "End of contract",
                SettlementAmount = 20000.00f,
                PaymentMethod = "Cash",
                TerminatedBy = "Shaswot"
            },
            new TerminationData
            {
                AgreementNo = "AG0005",
                PropertyNo = "P0005",
                LogNo = "Log0044",
                PropertyName = "Sudeshna Housing",
                date = DateOnly.FromDateTime(new DateTime(2023, 04, 07)),
                Time = new TimeOnly(09,22),
                Reason = "End of contract",
                SettlementAmount = 500000.00f,
                PaymentMethod = "Cash",
                TerminatedBy = "Sudeshna"
            }
        };

    }

    
}
