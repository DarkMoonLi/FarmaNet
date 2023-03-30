using System.Collections.Generic;
using System.Linq;
using FarmaNetBackend.Dto.MedicationDto;
using FarmaNetBackend.Models;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Infrastructure;

namespace FarmaNetBackend.Repositories
{
    public class MedicationRepository : IMedicationRepository
    {
        readonly ApplicationDbContext _context;

        public MedicationRepository( ApplicationDbContext context )
        {
            _context = context;
        }

        public List<MedicationDto> GetMedications()
        {
            List<Medication> medications = _context.Medications.ToList();

            List<MedicationDto> result = ConvertMedications(medications);

            return result;
        }

        public List<MedicationDto> GetMedicationsByName(string name)
        {
            List<Medication> medications = _context.Medications.Where(m => m.Name.Contains(name)).ToList();

            List<MedicationDto> result = ConvertMedications(medications);

            return result;
        }

        public List<MedicationDto> GetMedicationsByType(int medicationTypeId)
        {
            List<Medication> medications = _context.Medications.Where(m => m.MedicationTypeId == medicationTypeId).ToList();

            List<MedicationDto> result = ConvertMedications(medications);

            return result;
        }

        public MedicationDto GetMedicationById(int id)
        {
            Medication med = _context.Medications.FirstOrDefault(p => p.MedicationId == id);

            if (med != null)
            {
                MedicationDto result = ConvertMedication(med);
                return result;
            }

            return null;
        }

        public List<MedicationDto> GetMedicationsByPharmacyId(int id)
        {
            List<Medication> medications = _context.Medications
                                            .Join(_context.PharmacyWithMedications, m => m.MedicationId, pm => pm.MedicationId, (m, pm) => new { Medicine = m, PharmacyMedicine = pm })
                                            .Where(mpm => mpm.PharmacyMedicine.PharmacyId == id)
                                            .Select(mpm => mpm.Medicine)
                                            .ToList();

            List<MedicationDto> result = ConvertMedications(medications);

            return result;
        }

        public void AddMedication(AddMedicationDto medicationDto)
        {
            Medication medication = medicationDto.ConvertToMedication();

            _context.Medications.Add(medication);
            _context.SaveChanges();
        }

        public MedicationDto UpdateMedication(UpdateMedicationDto medicationDto)
        {
            Medication medication = _context.Medications.FirstOrDefault(m => m.MedicationId.Equals(medicationDto.MedicationId));

            if (medication != null)
            {
                medication.MedicationTypeId  = medicationDto.MedicationTypeId;
                medication.Name              = medicationDto.Name;
                medication.IndicationsForUse = medicationDto.IndicationsForUse;
                medication.Instruction       = medicationDto.Instruction;
                medication.Composition       = medicationDto.Composition;
                medication.Contraindications = medicationDto.Contraindications;
                medication.MedicationImageId = medicationDto.MedicationImageId;

                _context.Medications.Update(medication);
                _context.SaveChanges();

                MedicationDto result = ConvertMedication(medication);

                return result;
            }

            return null;
        }

        public void DeleteMedication(int id)
        {
            Medication medication = _context.Medications.FirstOrDefault(m => m.MedicationId.Equals(id));
            
            if (medication != null)
            {
                _context.Medications.Remove(medication);
                _context.SaveChanges();
            }
        }

        private List<MedicationDto> ConvertMedications(List<Medication> medications)
        {
            List<MedicationDto> result = new List<MedicationDto>();

            foreach (Medication med in medications)
            {
                MedicationDto medDto = ConvertMedication(med);

                result.Add(medDto);
            }

            return result;
        }

        private MedicationDto ConvertMedication(Medication medication)
        {
            MedicationDto medDto = new MedicationDto(medication);

            MedicationImage image = _context.MedicationImages.FirstOrDefault(i => i.ImageId.Equals(medication.MedicationImageId));

            if (image != null)
            {
                medDto.ImageTitle = image.Title;
                medDto.ImagePath = image.Path;
            }

            return medDto;
        }
    }
}