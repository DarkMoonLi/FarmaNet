namespace FarmaNetBackend.Dto.PharmacyWithMedicationDto
{
    public class PharmacyWithMedicationDto
    {
        public int MedicationId { get; set; }
        public int PharmacyId { get; set; }
        public int Quantity { get; set; }
        public float? Price { get; set; }
    }
}
