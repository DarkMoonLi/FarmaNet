namespace FarmaNetBackend.Models
{
    public class WriteDowns
    {   
        public int PharmacyId { get; set; }
        public int MedicationId { get; set; }

        public int Quantity { get; set; }

        public Pharmacy Pharmacy { get; set; }
        public Medication Medication { get; set; }


        public WriteDowns()
        { }
    }
}