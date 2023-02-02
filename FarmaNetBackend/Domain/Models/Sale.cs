namespace FarmaNetBackend.Domain.Models
{
    public class Sale
    {
        public int _idMedication { get; set; }
        public int _idPharmacy { get; set; }
        public int _price { get; set; }
        public int _quantity { get; set; }

        public Medication Medication { get; set; }
        public Pharmacy Pharmacy { get; set; }
    }
}