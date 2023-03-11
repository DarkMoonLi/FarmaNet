using FarmaNetBackend.Models;

namespace FarmaNetBackend.Dto.MedicationTypeDto
{
    public class AddMedicationTypeDto
    {
        public string Name { get; set; }

        public MedicationType ConvertToMedicationType()
        {
            return new MedicationType
            {
                Name = this.Name
            };
        }
    }
}
