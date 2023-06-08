using Microsoft.AspNetCore.Components;
using NeoRMS.Data;

namespace NeoRMS.Pages
{
    public class PropertyBase: ComponentBase
    {

        [Parameter]
        public string LogNo { get; set; }

        [Parameter]
        public string _activeTab { get; set; }

        public bool companyModal { get; set; }

        public bool revenueModal { get; set; }

        public bool agreementModal { get; set; }

        public bool maintenanceModal { get; set; }
        public bool legalModal { get; set; }

        public bool communicationModal { get; set; }

        public bool judiciaryModal { get; set; }

        public bool propertyModal { get; set; }

        public bool ownerModal { get; set; }
        public bool roomModal { get; set; }

        public bool terminationModal { get; set; }


        public bool addData { get; set; }

        public string activeTab = "propertyTab";

        public string activeTab2 = "revenueTab";

        public bool IsChecked { get; set; }

        //storing value for revenue modal
        protected RevenueData _revenueData = new RevenueData();



        protected List<string> _maintenance = new List<string> { "Painting", "Electricity", "Plumbing", "HVAC", "Landscaping", "Pest control", "Roofing", "Carpentry", "Flooring", "Appliance repair" };

        protected List<string> _costBearer = new List<string> { "Tenant", "Landlord" };

        protected List<string> _paymentMethod = new List<string> { "Cash", "Check", "Bank Transfer", "Online", "Credit Card" };

        protected List<string> _propertyType = new List<string> { "Apartment", "House", "Commercial", "Housing" };

        protected AgreementData _agreementData = new AgreementData();


        protected JudiciaryBase judiciaryBase = new JudiciaryBase();
        protected List<JudiciaryData> _judiciaryData;
        
        protected CommunicationBase communicationBase = new CommunicationBase();
        protected List<CommunicationData> _communicationData;

        protected PropertyDetailBase propertyBase = new PropertyDetailBase();
        protected List<PropertyData> _propertyData;

        protected OwnerdetailBase ownerBase = new OwnerdetailBase();
        protected List<OwnerData> _ownerData;

        protected TerminationBase terminationBase = new TerminationBase();
        protected List<TerminationData> _terminationData;

        protected RoomsBase roomsBase = new RoomsBase();
        protected List <RoomsData> _roomsData;


        protected void CheckAll()
        {
            IsChecked = true;
        }
        
        protected void RejectAll()
        {
            IsChecked = false;
        }

        public void startEdit()
        {
            addData = true;
        }

        public void showCompanyModal()
        {
            companyModal = true;
        }

        public void showAgreementModal()
        {
            agreementModal = true;
        }
        
        

        protected override void OnInitialized()
        {
            if(_activeTab != null )
            {
                activeTab = _activeTab;
                activeTab2 = _activeTab;

            }
            _judiciaryData = judiciaryBase.Data;
            _communicationData = communicationBase.Data;
            _propertyData = propertyBase.Data;
            _ownerData = ownerBase.Data;
            _terminationData = terminationBase.Data;
            _roomsData = roomsBase.Data;
        }

        

        protected async Task closeCompanyModal(bool isOK)
        {
            if (isOK)
            {
                Console.WriteLine("Okay");
            }
            companyModal = false;
        }

       
        protected async Task closeAgreementModal(bool isOK)
        {
            if (isOK)
            {
               
            }
            agreementModal = false;
        }

        


        public void setActiveClass(string tabId)
        {
            activeTab = tabId;
        }
        
        public void setActiveClass2(string tabId)
        {
            activeTab2 = tabId;
        }

        public string GetTabHeadClass(string tabId)
        {
            if (tabId == activeTab)
            {
                return "nav-link active";
            }
            else
            {
                return "nav-link";
            }
        }

        public string GetTabBtnClass(string tabId)
        {
            if (tabId == activeTab)
            {
                return "addTabButton";
            }
            else
            {
                return "removeTabButton";
            }
        }
        public string GetActiveClass(string tabId)
        {
            if(tabId == activeTab)
            {
                return "active";
            }
            else
            {
                return "";
            }
        }


        protected List<string> agreements = new List<string>
        {
            new string(
                "Tenant agrees to pay rent of $X per month, due on the 1st of each month, with a late fee of $Y for payments received after the due date.\r\n"),
            new string(
                "Tenant agrees to pay a security deposit of $Z, which will be returned within 30 days of the end of the lease term, provided there is no damage to the property.\r\n"),
            new string(
                "Tenant agrees to keep the property in a clean and orderly condition and to promptly report any maintenance issues to the landlord. Landlord agrees to make repairs in a timely manner.\r\n"),
            new string("Tenant agrees to use the property solely for residential purposes and to comply with all applicable laws and regulations.\r\n"),
            new string(
                "Tenant agrees to pay for all utilities not included in the rent, including electricity, gas, water, and trash removal.\r\n"),
            new string(
                "Tenant agrees to obtain renters' insurance with a minimum coverage of $X and to provide proof of insurance to the landlord.\r\n"),
            new string(
                "Pets are not allowed on the property without the landlord's prior written consent. If pets are allowed, a pet deposit of $X and a monthly pet fee of $Y will be required.\r\n"),
            new string(
                "The lease term is for X months and may be terminated by either party with written notice of at least 30 days before the end of the lease term. Tenant may renew the lease for an additional term of X months by providing written notice to the landlord at least 60 days before the end of the current lease term."),
            new string(
                "Tenant may not make any alterations to the property without the landlord's prior written consent.\r\n"),
            new string(
                "Landlord may access the property for inspection or maintenance purposes with reasonable notice to the tenant, except in cases of emergency.")
        };


        public List<RevenueData> Data
        {
            get { return revenueData; }
        }

        protected List<RevenueData> revenueData = new List<RevenueData>()
        {
            new RevenueData
            {
                AgreementNo = "AG1220",
                LogNo = "Log0041",
                PropertyNo = "P1",
                PropertyName = "Biraj Housing",
                DocumentName = "Total Revenue",
                DocumentType = "Reports",
                File = "Document.pdf",
                date = new DateOnly(2022, 1, 1),
                ReceivedAmount = 100.0f,
                MaintenanceType = "Cleaing",
                PaymentMethod = "Credit Card",
                TpsDeduction = 5.0f,
                Rebate = 10.0f,
                Reason = "Monthly Rent"
            },
            new RevenueData
            {
                AgreementNo = "AG1221",
                LogNo = "Log0042",
                PropertyNo = "P2",
                PropertyName = "Bijay Housing",
                DocumentName = "Total Revenue",
                DocumentType = "Reports",
                File = "Document.pdf",
                date = new DateOnly(2022, 2, 1),
                ReceivedAmount = 200.0f,
                 MaintenanceType = "Cleaing",
                PaymentMethod = "Cash",
                TpsDeduction = 10.0f,
                Rebate = 20.0f,
                Reason = "Monthly Rent"
            },
            new RevenueData
            {
                AgreementNo = "AG1222",
                LogNo = "Log0043",
                PropertyNo = "P3",
                PropertyName = "Muna Housing",
                DocumentName = "Total Revenue",
                DocumentType = "Reports",
                File = "Document.pdf",
                date = new DateOnly(2022, 3, 1),
                ReceivedAmount = 300.0f,
                 MaintenanceType = "Cleaing",
                PaymentMethod = "Check",
                TpsDeduction = 15.0f,
                Rebate = 30.0f,
                Reason = "Monthly Rent"
            },
            new RevenueData
            {
                AgreementNo = "AG1223",
                LogNo = "Log0044",
                PropertyNo = "P4",
                PropertyName = "Saswat Housing",
                DocumentName = "Total Revenue",
                DocumentType = "Reports",
                File = "Document.pdf",
                date = new DateOnly(2022, 4, 1),
                ReceivedAmount = 400.0f,
                 MaintenanceType = "Cleaing",
                PaymentMethod = "Bank Transfer",
                TpsDeduction = 20.0f,
                Rebate = 40.0f,
                Reason = "Monthly Rent"
            },
            new RevenueData
            {
                AgreementNo = "AG1224",
                LogNo = "Log0045",
                PropertyNo = "P5",
                PropertyName = "Sudheshna Housing",
                DocumentName = "Total Revenue",
                DocumentType = "Reports",
                File = "Document.pdf",
                date = new DateOnly(2022, 5, 1),
                ReceivedAmount = 500.0f,
                 MaintenanceType = "Cleaing",
                PaymentMethod = "Credit Card",
                TpsDeduction = 25.0f,
                Rebate = 50.0f,
                Reason = "Monthly Rent"
            }
        };
    }
    
}
