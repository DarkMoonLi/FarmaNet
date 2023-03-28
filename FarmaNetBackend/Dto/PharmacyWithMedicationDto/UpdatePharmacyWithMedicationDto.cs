namespace FarmaNetBackend.Dto.PharmacyWithMedicationDto
{
    public class UpdatePharmacyWithMedicationDto
    {
        public int MedicationId { get; set; }
        public int PharmacyId { get; set; }
        public int Quantity { get; set; }
        public double? Price { get; set; }
    }
}
