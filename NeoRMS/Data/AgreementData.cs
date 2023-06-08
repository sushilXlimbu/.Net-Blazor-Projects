namespace NeoRMS.Data
{
    public class AgreementData
    {

            public string AgreementNo { get; set; }

            public string Name { get; set; }

            public DateOnly Date { get; set; } = DateOnly.FromDateTime(DateTime.Now);

            public int NoOfRooms { get; set; }

            public float IncrementMethod { get; set; }

            public float Penalty { get; set; }

            public bool LivingRoom { get; set; }

            public bool Washroom { get; set; }

            public bool BedRoom { get; set; }

            public bool Terrace { get; set; }

            public bool Kitchen { get; set; }

            public bool Balcony { get; set; }

            public string RentalType { get; set; }


        
    }
}
