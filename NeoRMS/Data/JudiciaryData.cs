namespace NeoRMS.Data
{
    public class JudiciaryData
    {

        public string AgreementNo { get; set; }
        public string LogNo { get; set; }
        public string PropertyName { get; set; }

        public TimeOnly Time { get; set; }

        public DateOnly date { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        public string Action { get; set; }

        public string Reason { get; set; }

        public string GovRep { get; set; }

        public string PoliceRep { get; set; }

    }
}
