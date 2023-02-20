using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Dto.MedicationTypeDto;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.IRepositories
{
    public interface IMedicationTypeRepository
    {
        public List<MedicationType> GetMedicationTypes();
        public MedicationType GetMedicationTypeById(int id);
        public void AddMedicationType(MedicationTypeDto medicationTypeDto);
        public void UpdateMedicationType(MedicationTypeDto medicationTypeDto);
        public void RemoveMedicationType(int id);
    }
}
