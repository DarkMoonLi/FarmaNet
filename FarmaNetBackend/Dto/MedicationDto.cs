using FarmaNetBackend.Domain.Models;

namespace FarmaNetBackend.Dto.MedicationDto
{
    public class MedicationDto
    {
        public int IdMedication { get; }
        public string Name { get; set; }
        public string Recipe { get; set; }
        public int IdMedicationType { get; set; }
        public MedicationType TypeMedication { get; set; }

        public MedicationDto(Medication med)
        {
            IdMedication = med.MedicationId;
            Name = med.Name;
            Recipe = med.Recipe;
            IdMedicationType = med.MedicationTypeId;
            TypeMedication = med.MedicationType;
        }
  }
}