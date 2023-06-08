namespace NeoRMS.Data
{
    public class TerminationData
    {

        public string AgreementNo { get; set; }
        public string LogNo { get; set; }
        public string PropertyName { get; set; }

        public string PropertyNo { get; set; }

        public DateOnly date { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        public TimeOnly Time { get; set; }

        public string Reason { get; set; }

        public float SettlementAmount { get; set; }

        public string PaymentMethod { get; set; }

        public string TerminatedBy { get; set; }

    }
}
