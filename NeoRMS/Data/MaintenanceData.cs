namespace NeoRMS.Data
{
    public class MaintenanceData
    {

        public string AggreementNo { get; set; }
        public string LogNo { get; set; }

        public string PropertyNo { get; set; }
        public string PropertyName { get; set; }

        public DateOnly date { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        public string MaintenanceType { get; set; }

        public float MaintenanceCost { get; set; }

        public string CostBearer { get; set; }

    }
}
