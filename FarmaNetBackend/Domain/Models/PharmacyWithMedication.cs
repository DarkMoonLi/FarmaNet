namespace FarmaNetBackend.Domain.Models
{
    public class PharmacyWithMedication
    {
        public int MedicationId { get; set; }
        public int PharmacyId { get; set; }
        
        public float? Price { get; set; }
        public int Quantity { get; set; }

        public Pharmacy Pharmacy { get; set; }
        public Medication Medication { get; set; }


        public PharmacyWithMedication()
        { }
    }
}