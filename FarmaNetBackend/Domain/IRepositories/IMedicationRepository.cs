using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Dto.MedicationDto;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.IRepositories
{
    public interface IMedicationRepository
    {
        public List<Medication> GetMedications();
        public Medication GetMedicationById(int id);
        public void AddMedication(MedicationDto medicationDto);
        public void UpdateMedication(MedicationDto medicationDto);
        public void DeleteMedication(int id);
    }
}