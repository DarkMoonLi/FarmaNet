using FarmaNetBackend.Domain.Models;

namespace FarmaNetBackend.Dto.MedicationWithManufacturerDto
{
    public class AddMedicationWithManufacturerDto
    {
        public int ManufacturerId { get; set; }
        public int MedicationId { get; set; }

        public MedicationWithManufacturer ConvertToMedicationWithManufacturer()
        {
            return new MedicationWithManufacturer
            {
                ManufacturerId = this.ManufacturerId,
                MedicationId = this.MedicationId
            };
        }
    }
}
