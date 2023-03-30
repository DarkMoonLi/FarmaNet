using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.MedicationDto;
using System.Collections.Generic;

namespace FarmaNetBackend.IRepositories
{
    public interface IMedicationRepository
    {
        public List<MedicationDto> GetMedications();
        public MedicationDto GetMedicationById(int id);
        public List<MedicationDto> GetMedicationsByName(string medicationDto);
        public List<MedicationDto> GetMedicationsByType(int medicationTypeId);
        public List<MedicationDto> GetMedicationsByPharmacyId(int id);
        public void AddMedication(AddMedicationDto medicationDto);
        public MedicationDto UpdateMedication(UpdateMedicationDto medicationDto);
        public void DeleteMedication(int id);
    }
}