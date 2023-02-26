using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Dto.PharmacyWithMedication;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.IRepositories
{
    public interface IPharmacyWithMedicationReopsitory
    {
        public List<PharmacyWithMedication> GetPharmacyWithMedications();
        public PharmacyWithMedication GetPharmacyWithMedicationById(int id);
        public void AddPharmacyWithMedication(PharmacyWithMedicationDto pharmacyWithMedicationDto);
        public void UpdatePharmacyWithMedication(PharmacyWithMedicationDto pharmacyWithMedicationDto);
        public void RemovePharmacyWithMedication(int id);
    }
}
