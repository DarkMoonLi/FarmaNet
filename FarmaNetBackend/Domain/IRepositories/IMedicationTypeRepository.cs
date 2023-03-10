using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Dto.MedicationTypeDto;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.IRepositories
{
    public interface IMedicationTypeRepository
    {
        public List<MedicationType> GetMedicationTypes();
        public MedicationType GetMedicationTypeById(int id);
        public void AddMedicationType(AddMedicationTypeDto medicationTypeDto);
        public void UpdateMedicationType(UpdateMedicationTypeDto medicationTypeDto);
        public void RemoveMedicationType(int id);
    }
}
