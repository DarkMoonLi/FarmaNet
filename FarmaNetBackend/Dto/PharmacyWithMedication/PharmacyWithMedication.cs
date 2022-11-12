namespace FarmaNetBackend.Dto.PharmacyWithMedication
{
    public class PharmacyWithMedication
    {
        public int IdMedication { get; set; }
        public int IdPharmacy { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}
