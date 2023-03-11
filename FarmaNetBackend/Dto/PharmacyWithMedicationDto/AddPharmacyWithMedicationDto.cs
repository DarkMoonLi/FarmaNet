using FarmaNetBackend.Models;

namespace FarmaNetBackend.Dto.PharmacyWithMedicationDto
{
    public class AddPharmacyWithMedicationDto
    {
        public int PharmacyId { get; set; }
        public int MedicationId { get; set; }
        public int Quantity { get; set; }
        public float? Price { get; set; }

        public PharmacyWithMedication ConvertToPharmacyWithMedication()
        {
            return new PharmacyWithMedication
            {
                PharmacyId = this.PharmacyId,
                MedicationId = this.MedicationId,
                Quantity = this.Quantity,
                Price = this.Price
            };
        }
    }
}
