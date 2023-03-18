using FarmaNetBackend.Models;

namespace FarmaNetBackend.Dto.WriteDownsDto
{
    public class WriteDownsDto
    {
        public int MedicationId { get; set; }
        public int PharmacyId { get; set; }
        public int Quantity { get; set; }

        public WriteDownsDto(WriteDowns writeDowns)
        {
            MedicationId = writeDowns.MedicationId;
            PharmacyId = writeDowns.PharmacyId;
            Quantity = writeDowns.Quantity;
        }
    }
}
