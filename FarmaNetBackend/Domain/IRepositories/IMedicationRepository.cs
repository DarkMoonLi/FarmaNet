using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Dto.MedicationDto;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.IRepositories
{
    public interface IMedicationRepository
    {
        public List<Medication> GetMedications();
        public Medication GetMedicationById(int id);
        public void AddMedication(AddMedicationDto medicationDto);
        public void UpdateMedication(UpdateMedicationDto medicationDto);
        public void DeleteMedication(int id);
    }
}