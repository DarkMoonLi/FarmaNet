namespace FarmaNetBackend.Models
{
    public class PharmacyWithMedication
    {
        public int MedicationId { get; set; }
        public int PharmacyId { get; set; }
        
        public double? Price { get; set; }
        public int Quantity { get; set; }

        public Pharmacy Pharmacy { get; set; }
        public Medication Medication { get; set; }


        public PharmacyWithMedication()
        { }
    }
}