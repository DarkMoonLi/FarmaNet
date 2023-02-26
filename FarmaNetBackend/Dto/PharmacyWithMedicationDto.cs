namespace FarmaNetBackend.Dto.PharmacyWithMedication
{
    public class PharmacyWithMedicationDto
    {
        public int IdMedication { get; set; }
        public int IdPharmacy { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}
