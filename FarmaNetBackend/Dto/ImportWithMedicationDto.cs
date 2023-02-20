namespace FarmaNetBackend.Dto.ImportWithMedicationDto
{
    public class ImportWithMedicationDto
    {
        public int IdInvoice { get; set; }
        public int IdMedication { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}
