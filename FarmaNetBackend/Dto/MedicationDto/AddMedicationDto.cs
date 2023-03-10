using FarmaNetBackend.Domain.Models;

namespace FarmaNetBackend.Dto.MedicationDto
{
    public class AddMedicationDto
    {
        public string Name { get; set; }
        public string Recipe { get; set; }
        public int MedicationTypeId { get; set; }

        public Medication ConvertToMedication()
        {
            return new Medication
            {
                Name = this.Name,
                Recipe = this.Recipe,
                MedicationTypeId = this.MedicationTypeId
            };
        }
    }
}
