using FarmaNetBackend.Models;

namespace FarmaNetBackend.Dto.MedicationDto
{
    public class MedicationDto
    {
        public int IdMedication { get; }
        public string Name { get; set; }
        public string Recipe { get; set; }
        public int IdMedicationType { get; set; }
        public TypeMedication TypeMedication { get; set; }

        public MedicationDto(Medication med)
        {
            /*IdMedication = med.GetId();
            Name = med.GetName();
            Recipe = med.GetRecipe();
            IdMedicationType = med.GetTypeId();
            TypeMedication = med.GetTypeMedication();*/
        }
  }
}
