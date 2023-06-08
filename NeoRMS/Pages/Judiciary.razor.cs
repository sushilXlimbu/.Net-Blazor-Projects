using Microsoft.AspNetCore.Components;
using NeoRMS.Data;

namespace NeoRMS.Pages
{
    public class JudiciaryBase : ComponentBase
    {

        public string searchQuery { get; set; }

        protected List<JudiciaryData> filteredData
        {
            get
            {
                if (string.IsNullOrWhiteSpace(searchQuery))
                    return data;

                return data.Where(data =>
                    data.AgreementNo.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    data.Action.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    (data.Reason + "").Contains(searchQuery)

                ).ToList();
            }
        }


        [Inject] NavigationManager navigationManager { get; set; }
        public void NavigateTo(string logNo)
        {
            navigationManager.NavigateTo($"/rentalmanagement/judiciaryTab/{logNo}");
        }

        public List<JudiciaryData> Data
        {
            get { return data; }
        }


        protected List<JudiciaryData> data = new List<JudiciaryData>
        {
            new JudiciaryData
            {
                AgreementNo = "AG021",
                LogNo = "Log0041",
                PropertyName = "Biraj Housing",
                Time =  new TimeOnly(11,30),
                date = DateOnly.FromDateTime(new DateTime(2022, 4, 1)),
                Action = "Kick out",
                Reason = " Didn't pay the rent",
                GovRep = "Bijay Baniya",
                PoliceRep = "Abishek Yadav"
            },
            new JudiciaryData
            {
                 AgreementNo = "AG052",
                 LogNo = "Log0041",
                 PropertyName = "Bijay Housing",
                Time =  new TimeOnly(01,30),
                date = DateOnly.FromDateTime(new DateTime(2022, 1, 1)),
                Action = "Warning",
                Reason = "Made Loud noise",
                GovRep = "Shaswot Tripati",
                PoliceRep = "Sudeshna Pandey"
            },
            new JudiciaryData
            {
                 AgreementNo = "AG033",
                 LogNo = "Log0041",
                 PropertyName = "Muna Housing",
                Time =  new TimeOnly(9,15),
                date = DateOnly.FromDateTime(new DateTime(2022, 5, 1)),
                Action = "Banned",
                Reason = "Destroy of property",
                GovRep = "Biraj Nakarmi",
                PoliceRep = "Priyanka Upreti"
            },
            new JudiciaryData
            {
                  AgreementNo = "AG014",
                  LogNo = "Log0041",
                 PropertyName = "Saswat Housing",
                Time =  new TimeOnly(11,00),
                date = DateOnly.FromDateTime(new DateTime(2022, 2, 11)),
                Action = "Close",
                Reason = "End of contract",
                GovRep = "Priyanka Chopra",
                PoliceRep = "Priyanka Upreti"
            },
            new JudiciaryData
            {
                AgreementNo = "AG005",
                LogNo = "Log0041",
                PropertyName = "Sudhesna Housing",
                Time =  new TimeOnly(15,30),
                date = DateOnly.FromDateTime(new DateTime(2022, 11, 11)),
                Action = "Called cops",
                Reason = "Illigel activities",
                GovRep = "Bijay Baniya",
                PoliceRep = "Priyanka Upreti"
            }
        };

    }
}
