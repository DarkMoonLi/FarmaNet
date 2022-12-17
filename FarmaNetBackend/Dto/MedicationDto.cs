using System;
using FarmaNetBackend.Models.Medication;

namespace FarmaNetBackend.Dto.MedicationDto
{
    public class MedicationDto
    {
        public int IdMedication { get; }
        public string Name { get; set; }
        public string Recipe { get; set; }
        public int IdMedicationType { get; set; }
        public TypeMedication TypeMedication { get; set; }
  }
}
