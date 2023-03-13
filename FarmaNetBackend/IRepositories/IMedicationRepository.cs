using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.MedicationDto;
using System.Collections.Generic;

namespace FarmaNetBackend.IRepositories
{
    public interface IMedicationRepository
    {
        public List<Medication> GetMedications();
        public Medication GetMedicationById(GetMedicationDto medicationDto);
        public void AddMedication(AddMedicationDto medicationDto);
        public void UpdateMedication(UpdateMedicationDto medicationDto);
        public void DeleteMedication(GetMedicationDto medicationDto);
    }
}