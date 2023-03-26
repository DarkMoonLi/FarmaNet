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

        public List<Medication> GetMedications()
        {
            return _context.Medications.ToList();
        }

        public List<Medication> GetMedicationsByName(string name)
        {
            return _context.Medications.Where(m => m.Name == name).ToList();
        }

        public List<Medication> GetMedicationsByType(int medicationTypeId)
        {
            return _context.Medications.Where(m => m.MedicationTypeId == medicationTypeId).ToList();
        }

        public Medication GetMedicationById(GetMedicationDto medicationDto)
        {
            return _context.Medications.FirstOrDefault(p => p.MedicationId == medicationDto.MedicationId);
        }

        public void AddMedication(AddMedicationDto medicationDto)
        {
            Medication medication = medicationDto.ConvertToMedication();

            _context.Medications.Add(medication);
            _context.SaveChanges();
        }

        public void UpdateMedication(UpdateMedicationDto medicationDto)
        {
            Medication medication = GetMedicationById(new GetMedicationDto{ MedicationId = medicationDto.MedicationId });

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
            }
        }

        public void DeleteMedication(GetMedicationDto medicationDto)
        {
            Medication medication = GetMedicationById(medicationDto);
            
            if (medication != null)
            {
                _context.Medications.Remove(medication);
                _context.SaveChanges();
            }
        }
    }

    public static class ConvertMedication
    {
        public static MedicationDto ConvertToMedicationDto( this Medication medication )
        {
            return new MedicationDto(medication);
        }
    }
}