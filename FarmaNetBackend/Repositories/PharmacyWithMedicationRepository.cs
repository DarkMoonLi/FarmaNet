using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.PharmacyWithMedicationDto;
using FarmaNetBackend.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace FarmaNetBackend.Repositories
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

        public PharmacyWithMedication GetPharmacyWithMedicationById(GetPharmacyWithMedicationDto pharmacyWithMedicationDto)
        {
            return _context.PharmacyWithMedications.FirstOrDefault(p => p.PharmacyId == pharmacyWithMedicationDto.PharmacyId
                                                                        && p.MedicationId == pharmacyWithMedicationDto.MedicationId);
        }

        public void AddPharmacyWithMedication(AddPharmacyWithMedicationDto pharmacyWithMedicationDto)
        {
            PharmacyWithMedication pharmacy = pharmacyWithMedicationDto.ConvertToPharmacyWithMedication();

            _context.PharmacyWithMedications.Add(pharmacy);
            _context.SaveChanges();
        }

        public void UpdatePharmacyWithMedication(UpdatePharmacyWithMedicationDto pharmacyWithMedicationDto)
        {
            PharmacyWithMedication pharmacyWithMedication = GetPharmacyWithMedicationById(new GetPharmacyWithMedicationDto
                                                                                            {
                                                                                            MedicationId = pharmacyWithMedicationDto.MedicationId,
                                                                                            PharmacyId = pharmacyWithMedicationDto.PharmacyId
                                                                                            });

            if (pharmacyWithMedication != null)
            {
                pharmacyWithMedication.Price = pharmacyWithMedicationDto.Price;
                pharmacyWithMedication.Quantity = pharmacyWithMedicationDto.Quantity;

                _context.PharmacyWithMedications.Update(pharmacyWithMedication);
                _context.SaveChanges();
            }
        }

        public void RemovePharmacyWithMedication(GetPharmacyWithMedicationDto pharmacyWithMedicationDto)
        {
            PharmacyWithMedication pharmacy = GetPharmacyWithMedicationById(pharmacyWithMedicationDto);

            if (pharmacy != null)
            {
                _context.PharmacyWithMedications.Remove(pharmacy);
                _context.SaveChanges();
            }
        }
    }
}
