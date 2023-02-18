namespace FarmaNetBackend.Domain.Models
{
    public class Sale
    {
        public int MedicationId { get; set; }
        public int PharmacyId { get; set; }
        
        public int? Price { get; set; }
        public int Quantity { get; set; }

        public Medication Medication { get; set; }
        public Pharmacy Pharmacy { get; set; }


        public Sale()
        { }
    }
}