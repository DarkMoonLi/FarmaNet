using FarmaNetBackend.Models;

namespace FarmaNetBackend.Dto.MedicationWithManufacturerDto
{
    public class MedicationWithManufacturerDto
    {
        public int ManufacturerId { get; set; }
        public int MedicationId { get; set; }

        public MedicationWithManufacturerDto(MedicationWithManufacturer medicationWithManufacturer)
        {
            ManufacturerId = medicationWithManufacturer.ManufacturerId;
            MedicationId = medicationWithManufacturer.MedicationId;
        }
    }
}
