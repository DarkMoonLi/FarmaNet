using FarmaNetBackend.Domain.Models;

namespace FarmaNetBackend.Dto.WriteDownsDto
{
    public class AddWriteDownsDto
    {
        public int MedicationId { get; set; }
        public int PharmacyId { get; set; }
        public int Quantity { get; set; }

        public WriteDowns ConvertToWriteDowns()
        {
            return new WriteDowns
            {
                MedicationId = this.MedicationId,
                PharmacyId = this.PharmacyId,
                Quantity = this.Quantity
            };
        }
    }
}
