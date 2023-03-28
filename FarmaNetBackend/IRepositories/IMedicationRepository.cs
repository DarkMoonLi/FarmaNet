using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.MedicationDto;
using System.Collections.Generic;

namespace FarmaNetBackend.IRepositories
{
    public interface IMedicationRepository
    {
        public List<Medication> GetMedications();
        public Medication GetMedicationById(int id);
        public List<Medication> GetMedicationsByName(string medicationDto);
        public List<Medication> GetMedicationsByType(int medicationTypeId);
        public List<Medication> GetMedicationsByPharmacyId(int id);
        public void AddMedication(AddMedicationDto medicationDto);
        //public void UpdateMedication(int id);
        public void DeleteMedication(int id);
    }
}