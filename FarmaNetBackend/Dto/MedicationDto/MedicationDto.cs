using FarmaNetBackend.Domain.Models;

namespace FarmaNetBackend.Dto.MedicationDto
{
    public class MedicationDto
    {
        public int MedicationId { get; }
        public string Name { get; set; }
        public string Recipe { get; set; }
        public int MedicationTypeId { get; set; }
        
        public MedicationDto(Medication med)
        {
            MedicationId     = med.MedicationId;
            Name             = med.Name;
            Recipe           = med.Recipe;
            MedicationTypeId = med.MedicationTypeId;
        }
  }
}