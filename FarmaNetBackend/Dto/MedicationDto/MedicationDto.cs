using FarmaNetBackend.Models;
using Microsoft.AspNetCore.Http;

namespace FarmaNetBackend.Dto.MedicationDto
{
    public class MedicationDto
    {
        public int MedicationId { get; }
        public string Name { get; set; }
        public string IndicationsForUse { get; set; }
        public string Composition { get; set; }
        public string Contraindications { get; set; }
        public string Instruction { get; set; }
        public int MedicationTypeId { get; set; }
        public int MedicationImageId { get; set; }
        public string ImageTitle { get; set; }
        public string ImagePath { get; set; }
        
        public MedicationDto(Medication med)
        {
            this.MedicationId      = med.MedicationId;
            this.Name              = med.Name;
            this.IndicationsForUse = med.IndicationsForUse;
            this.Composition       = med.Composition;
            this.Contraindications = med.Contraindications;
            this.Instruction       = med.Instruction;
            this.MedicationTypeId  = med.MedicationTypeId;
            this.MedicationImageId = med.MedicationImageId;
        }
  }
}