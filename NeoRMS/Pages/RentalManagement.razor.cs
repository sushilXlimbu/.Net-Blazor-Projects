using Microsoft.AspNetCore.Components;
using NeoRMS.Data;

namespace NeoRMS.Pages
{
    public class RentalManagementBase:ComponentBase
    {

        [Parameter]
        public string LogNo { get; set; }

        [Parameter]
        public string _activeTab { get; set; }

        public bool companyModal { get; set; }

        public bool revenueModal { get; set; }

        public bool agreementModal { get; set; }
        public bool rentaldetailModal { get; set; }

        public bool maintenanceModal { get; set; }
        public bool legalModal { get; set; }

        public bool communicationModal { get; set; }

        public bool judiciaryModal { get; set; }

        public bool propertyModal { get; set; }

        public bool ownerModal { get; set; }
        public bool roomModal { get; set; }

        public bool terminationModal { get; set; }


        public bool addData { get; set; }

        public string activeTab = "rentaldetailTab";

        public bool IsChecked { get; set; }

        //storing value for revenue modal
        protected RevenueData _revenueData = new RevenueData();



        protected List<string> _maintenance = new List<string> { "Painting", "Electricity", "Plumbing", "HVAC", "Landscaping", "Pest control", "Roofing", "Carpentry", "Flooring", "Appliance repair" };

        protected List<string> _costBearer = new List<string> { "Tenant", "Landlord" };

        protected List<string> _paymentMethod = new List<string> { "Cash", "Check", "Bank Transfer", "Online", "Credit Card" };

        protected List<string> _propertyType = new List<string> { "Apartment", "House", "Commercial", "Housing" };

        protected AgreementData _agreementData = new AgreementData();

        protected RentalData _rentalData = new RentalData();




        protected JudiciaryBase judiciaryBase = new JudiciaryBase();
        protected List<JudiciaryData> _judiciaryData;

        protected CommunicationBase communicationBase = new CommunicationBase();
        protected List<CommunicationData> _communicationData;

        protected PropertyDetailBase propertydetailBase = new PropertyDetailBase();
        protected List<PropertyData> _propertydetailData;

        protected PropertyBase propertyBase = new PropertyBase();
        public List<RevenueData> _revenuData;

        protected OwnerdetailBase ownerBase = new OwnerdetailBase();
        protected List<OwnerData> _ownerData;

        protected TerminationBase terminationBase = new TerminationBase();
        protected List<TerminationData> _terminationData;

        protected RoomsBase roomsBase = new RoomsBase();
        protected List<RoomsData> _roomsData;

        



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
        public void showRentalDetailModal()
        {
            rentaldetailModal = true;
        }



        protected override void OnInitialized()
        {
            if (_activeTab != null)
            {
                activeTab = _activeTab;

            }
             
            
          
            
            _judiciaryData = judiciaryBase.Data;
            _communicationData = communicationBase.Data;
            _propertydetailData = propertydetailBase.Data;
            _ownerData = ownerBase.Data;
            _terminationData = terminationBase.Data;
            _roomsData = roomsBase.Data;
            _revenuData = propertyBase.Data;
        }

        //protected void filldata(string LogNo)
        //{
        //    var data = rentalData.FirstOrDefault(r => r.LogNo == LogNo);
        //    if (data != null)
        //    {
        //        _rentalData.LogNo = data.LogNo;
        //        _rentalData.AgreementNo = data.AgreementNo;
        //        _rentalData.PropertyName = data.PropertyName;
        //        _rentalData.Address = data.Address;
        //        _rentalData.BlockNo = data.BlockNo;
        //        _rentalData.Penalty = data.Penalty;
        //        _rentalData.FloorNo = data.FloorNo;
        //        _rentalData.RoomNo = data.RoomNo;
        //        _rentalData.RentalType = data.RentalType;
        //        _rentalData.IncrementMethod = data.IncrementMethod;
        //        _rentalData.Penalty = data.Penalty;
        //        Console.WriteLine("Found");

        //    }
        //    else
        //    {
        //        Console.WriteLine("Not found");
        //    }

        //}
       

        protected async Task closeCompanyModal(bool isOK)
        {
            if (isOK)
            {
                Console.WriteLine("Okay");
            }
            companyModal = false;
        }

        protected void openRentalModal()
        {

            rentaldetailModal = true;
        }
        protected void openRevenueModal()
        {

            revenueModal = true;
        }

        protected void openMaintenanceModal()
        {
            maintenanceModal = true;
        }

        public void openCommunicationModal()
        {
            communicationModal = true;
        }
        public void openLegalModal()
        {
            legalModal = true;
        }

        public void openJudiciaryModal()
        {
            judiciaryModal = true;
        }

        public void openPropertyModal()
        {
            propertyModal = true;
        }

        public void openOwnerModal()
        {
            ownerModal = true;
        }
        public void openRoomModal()
        {
            roomModal = true;
        }

        public void openTerminationModal()
        {
            terminationModal = true;
        }

        protected async Task closeRevenueModal(bool isOK)
        {
            if (isOK)
            {
                // Add the new RevenueData object to the list of data
                revenueData.Add(_revenueData);
            }
            revenueModal = false;
        }
        protected async Task closeRoomModal(bool isOK)
        {
            if (isOK)
            {


            }
            roomModal = false;
        }
        protected async Task closerentaldetailModal(bool isOK)
        {
            if (isOK)
            {


            }
            rentaldetailModal = false;
        }

        protected async Task closeAgreementModal(bool isOK)
        {
            if (isOK)
            {

            }
            agreementModal = false;
        }

        protected async Task closeMaintenanceModal(bool isOk)
        {
            if (isOk)
            {

            }
            maintenanceModal = false;
        }
        protected async Task closeLegalModal(bool isOk)
        {
            if (isOk)
            {

            }
            legalModal = false;
        }

        protected async Task closeCommunicationModal(bool isOk)
        {
            if (isOk)
            {

            }
            communicationModal = false;
        }

        protected async Task closeJudiciaryModal(bool isOK)
        {
            if (isOK)
            {

            }
            judiciaryModal = false;
        }

        protected async Task closePropertyModal(bool isOK)
        {
            if (isOK)
            {
            }
            propertyModal = false;
        }

        protected async Task closeOwnerModal(bool isOK)
        {
            if (isOK)
            {
            }
            ownerModal = false;
        }

        protected async Task closeTerminationModal(bool isOK)
        {
            if (isOK)
            {
            }
            terminationModal = false;
        }




        public void setActiveClass(string tabId)
        {
            activeTab = tabId;
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

        public string getActiveClass(string tabId)
        {
            if (tabId == activeTab)
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
