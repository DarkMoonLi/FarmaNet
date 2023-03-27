namespace FarmaNetBackend.Dto.ImportWithMedicationDto
{
    public class UpdateImportWithMedicationDto
    {
        public int ImportId { get; set; }
        public int MedicationId { get; set; }
        public int Quantity { get; set; }
        public double? Price { get; set; }
    }
}
