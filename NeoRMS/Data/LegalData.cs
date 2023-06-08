namespace NeoRMS.Data
{
    public class LegalData
    {

        
        public string LogNo { get; set; }

        public string PropertyNo { get; set; }
        public string PropertyName { get; set; }
        public string DocumentName { get; set; }
        public string DocumentType { get; set; }
        public string File { get; set; }
        public string MaintenanceType { get; set; }

        public DateOnly date { get; set; } = DateOnly.FromDateTime(DateTime.Now);




    }
}
