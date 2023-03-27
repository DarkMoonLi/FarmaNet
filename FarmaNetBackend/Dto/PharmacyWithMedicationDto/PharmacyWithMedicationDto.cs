using FarmaNetBackend.Models;

namespace FarmaNetBackend.Dto.PharmacyWithMedicationDto
{
    public class PharmacyWithMedicationDto
    {
        public int MedicationId { get; set; }
        public int PharmacyId { get; set; }
        public int Quantity { get; set; }
        public double? Price { get; set; }

        public PharmacyWithMedicationDto(PharmacyWithMedication pharmacyWithMedication)
        {
            MedicationId = pharmacyWithMedication.MedicationId;
            PharmacyId = pharmacyWithMedication.PharmacyId;
            Quantity = pharmacyWithMedication.Quantity;
            Price = pharmacyWithMedication.Price;
        }
    }
}
