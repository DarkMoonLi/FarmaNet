namespace FarmaNetBackend.Domain.Models
{
    public class WriteDowns
    {
        private int _idMedication { get; set; }
        private int _idPharmacy { get; set; }
        private int _quantity { get; set; }

        public Pharmacy Pharmacy { get; set; }
        public Medication Medication { get; set; }
    }
}