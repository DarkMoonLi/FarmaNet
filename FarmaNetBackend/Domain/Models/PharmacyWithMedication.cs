namespace FarmaNetBackend.Domain.Models
{
    public class PharmacyWithMedication
    {
        public int _idMedication { get; set; }
        public int _idPharmacy { get; set; }
        public float _price { get; set; }
        public int _quantity { get; set; }

        public Pharmacy Pharmacy { get; set; }
        public Medication Medication { get; set; }
    }
}