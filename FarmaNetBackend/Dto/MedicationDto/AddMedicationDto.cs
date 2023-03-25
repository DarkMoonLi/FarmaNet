using FarmaNetBackend.Models;
using Microsoft.AspNetCore.Http;

namespace FarmaNetBackend.Dto.MedicationDto
{
    public class AddMedicationDto
    {
        public string Name { get; set; }
        public string IndicationsForUse { get; set; }
        public string Composition { get; set; }
        public string Contraindications { get; set; }
        public string Instruction { get; set; }
        public int MedicationTypeId { get; set; }
        public int MedicationImageId { get; set; }

        public Medication ConvertToMedication()
        {
            return new Medication
            {
                Name              = this.Name,
                IndicationsForUse = this.IndicationsForUse,
                Composition       = this.Composition,
                Contraindications = this.Contraindications,
                Instruction       = this.Instruction,
                MedicationTypeId  = this.MedicationTypeId,
                MedicationImageId = this.MedicationImageId
            };
        }
    }
}
