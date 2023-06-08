using Microsoft.AspNetCore.Components;

namespace NeoRMS.Pages
{
    public class CommunicationBase : ComponentBase
    {

        public string searchQuery { get; set; }



        [Inject] NavigationManager navigationManager { get; set; }
        public void NavigateTo(string logNo)
        {
            navigationManager.NavigateTo($"/rentalmanagement/communicationTab/{logNo}");
        }

        protected List<CommunicationData> filteredData
        {
            get
            {
                if (string.IsNullOrWhiteSpace(searchQuery))
                    return data;

                return data.Where(data =>
                    data.AgreementNo.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    data.PropertyNo.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    data.Sender.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    data.Recipient.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)
                ).ToList();
            }
        }


        public List<CommunicationData> Data
        {
            get { return data; }
        }


        protected List<CommunicationData> data = new List<CommunicationData>
        {
            new CommunicationData
            {
                AgreementNo = "AG0001",
                LogNo = "Log0041",
                PropertyNo = "P0001",
                PropertyName = "Biraj Housing",
                date = DateOnly.FromDateTime(new DateTime(2023, 04, 11)),
                time = new TimeOnly(11,30),
                Sender = "John Smith",
                Recipient = "Jane Doe",
                Message = "I noticed a leak in the ceiling of the bathroom. Can you please send someone to fix it as soon as possible?"
            },
            new CommunicationData
            {
                AgreementNo = "AG0002",
                LogNo = "Log0041",
                PropertyNo = "P0002",
                PropertyName = "Bijay Housing",
                date = DateOnly.FromDateTime(new DateTime(2023, 04, 10)),
                time = new TimeOnly(23,00),
                Sender = "Mary Johnson",
                Recipient = "Joe Smith",
                Message = "The air conditioning unit in my bedroom is not working properly. It's blowing warm air instead of cold. Can you please have someone take a look at it?"
            },
            new CommunicationData
            {
                AgreementNo = "AG0003",
                LogNo = "Log0041",
                PropertyNo = "P0003",
                PropertyName = "Muna Housing",
                date = DateOnly.FromDateTime(new DateTime(2023, 04, 09)),
                time = new TimeOnly(05,12),
                Sender = "David Lee",
                Recipient = "Samantha Green",
                Message = "I'm having trouble with the locks on the front door. They seem to be jammed and it's difficult to open and close the door. Can you please have someone fix it?"
            },
            new CommunicationData
            {
                AgreementNo = "AG0004",
                LogNo = "Log0041",
                PropertyNo = "P0004",
                PropertyName = "Saswat Housing",
                date = DateOnly.FromDateTime(new DateTime(2023, 04, 08)),
                time = new TimeOnly(09,02),
                Sender = "Sarah Hernandez",
                Recipient = "Michael Brown",
                Message = "The kitchen sink is clogged and water is not draining properly. It's causing some unpleasant odors. Can you please send a plumber to fix it?"
            },
            new CommunicationData
            {
                AgreementNo = "AG0005",
                LogNo = "Log0041",
                PropertyNo = "P0005",
                PropertyName = "Sudhesna Housing",
                date = DateOnly.FromDateTime(new DateTime(2023, 04, 07)),
                time = new TimeOnly(09,22),
                Sender = "Robert Wilson",
                Recipient = "Emily Davis",
                Message = "The heating system in my apartment is not working. It's very cold and I'm having trouble sleeping at night. Can you please send someone to fix it?"
            }
        };
    }

    public class CommunicationData
    {
        public string AgreementNo { get; set; }
        public string LogNo { get; set; }

        public string PropertyNo { get; set; }
        public string PropertyName { get; set; }

        public DateOnly date { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        public TimeOnly time { get; set; } 

        public string Sender { get; set; }

        public string Recipient { get; set; }

        public string Message { get; set; }

    }
}
