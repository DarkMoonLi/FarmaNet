using FarmaNetBackend.Models.Medication;

namespace FarmaNetBackend.Dto.MedicationDto
{
    public class MedicationDto
    {
        public int IdMedication { get; }
        public string Name { get; set; }
        public string Recipe { get; set; }
        public int IdMedicationType { get; set; }
        public TypeMedication MedicationType { get; set; }

        public MedicationDto(Medication med)
        {
            IdMedication = med._id;
            Name = med._name;
            Recipe = med._recipe;
            IdMedicationType = med._idMedicationType;
            MedicationType = med._typeMedication;
        }
  }
}
