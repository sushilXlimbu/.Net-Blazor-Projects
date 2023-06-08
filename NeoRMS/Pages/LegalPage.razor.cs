using Microsoft.AspNetCore.Components;

namespace NeoRMS.Pages
{
    public class LegalPageBase:ComponentBase
    {


        [Inject] NavigationManager navigationManager { get; set; }
        public void NavigateTo(string logNo)
        {
            navigationManager.NavigateTo($"/property/legalTab/{logNo}");
        }

        protected List<RevenueData> legalData = new List<RevenueData>()
        {
            new RevenueData
            {
                
                LogNo = "Log0041",
                PropertyNo = "P1",
                PropertyName = "Biraj Housing",
                DocumentName = "Total Revenue",
                DocumentType = "Reports",
                File = "Document.pdf",
                date = new DateOnly(2022, 1, 1),
               
            },
            new RevenueData
            {
                
                LogNo = "Log0042",
                PropertyNo = "P2",
                PropertyName = "Bijay Housing",
                DocumentName = "Total Revenue",
                DocumentType = "Reports",
                File = "Document.pdf",
                date = new DateOnly(2022, 2, 1),
                
            },
            new RevenueData
            {
                
                LogNo = "Log0043",
                PropertyNo = "P3",
                PropertyName = "Muna Housing",
                DocumentName = "Total Revenue",
                DocumentType = "Reports",
                File = "Document.pdf",
                date = new DateOnly(2022, 3, 1),
                
            },
            new RevenueData
            {
                
                LogNo = "Log0044",
                PropertyNo = "P4",
                PropertyName = "Saswat Housing",
                DocumentName = "Total Revenue",
                DocumentType = "Reports",
                File = "Document.pdf",
                date = new DateOnly(2022, 4, 1),
               
            },
            new RevenueData
            {
                
                LogNo = "Log0045",
                PropertyNo = "P5",
                PropertyName = "Sudheshna Housing",
                DocumentName = "Total Revenue",
                DocumentType = "Reports",
                File = "Document.pdf",
                date = new DateOnly(2022, 5, 1),
                
            }
        };
    }
}
