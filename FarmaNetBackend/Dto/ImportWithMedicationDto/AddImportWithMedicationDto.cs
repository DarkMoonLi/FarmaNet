using FarmaNetBackend.Models;

namespace FarmaNetBackend.Dto.ImportWithMedicationDto
{
    public class AddImportWithMedicationDto
    {
        public int ImportId { get; set; }
        public int MedicationId { get; set; }
        public int Quantity { get; set; }
        public double? Price { get; set; }

        public ImportWithMedication ConvertToImportWithMedication()
        {
            return new ImportWithMedication
            {
                ImportId = this.ImportId,
                MedicationId = this.MedicationId,
                Quantity = this.Quantity,
                Price = this.Price
            };
        }
    }
}
