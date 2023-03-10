using FarmaNetBackend.Domain.Models;

namespace FarmaNetBackend.Dto.MedicationTypeDto
{
    public class MedicationTypeDto
    {
        public int MedicationTypeId { get; }
        public string Name { get; set; }

        public MedicationTypeDto(MedicationType medicationType)
        {
            MedicationTypeId = medicationType.MedicationTypeId;
            Name = medicationType.Name;
        }
    }
}
