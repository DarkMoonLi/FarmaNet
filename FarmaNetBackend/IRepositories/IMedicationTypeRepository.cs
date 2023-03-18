using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.MedicationTypeDto;
using System.Collections.Generic;

namespace FarmaNetBackend.IRepositories
{
    public interface IMedicationTypeRepository
    {
        public List<MedicationType> GetMedicationTypes();
        public MedicationType GetMedicationTypeById(GetMedicationTypeDto medicationTypeDto);
        public void AddMedicationType(AddMedicationTypeDto medicationTypeDto);
        public void UpdateMedicationType(UpdateMedicationTypeDto medicationTypeDto);
        public void RemoveMedicationType(GetMedicationTypeDto medicationTypeDto);
    }
}
