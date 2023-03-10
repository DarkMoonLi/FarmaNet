using FarmaNetBackend.Domain.IRepositories;
using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Dto.PharmacyWithMedicationDto;
using FarmaNetBackend.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace FarmaNetBackend.Domain.Repositories
{
    public class PharmacyWithMedicationRepository : IPharmacyWithMedicationRepository
    {
        readonly ApplicationDbContext _context;

        public PharmacyWithMedicationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<PharmacyWithMedication> GetPharmacyWithMedications()
        {
            return _context.PharmacyWithMedications.ToList();
        }

        public PharmacyWithMedication GetPharmacyWithMedicationById(int id)
        {
            // Поиск ПК по нескольким столбцам сделать
            return (PharmacyWithMedication)_context.PharmacyWithMedications.Where(p => p.PharmacyId == id);
        }

        public void AddPharmacyWithMedication(AddPharmacyWithMedicationDto pharmacyWithMedicationDto)
        {
            PharmacyWithMedication pharmacy = pharmacyWithMedicationDto.ConvertToPharmacyWithMedication();

            _context.PharmacyWithMedications.Add(pharmacy);
        }

        public void UpdatePharmacyWithMedication(UpdatePharmacyWithMedicationDto pharmacyWithMedicationDto)
        { }

        public void RemovePharmacyWithMedication(int id)
        {
            PharmacyWithMedication pharmacy = _context.PharmacyWithMedications.FirstOrDefault(p => p.PharmacyId == id);

            if (pharmacy != null)
            {
                _context.PharmacyWithMedications.Remove(pharmacy);
            }
        }
    }
}
