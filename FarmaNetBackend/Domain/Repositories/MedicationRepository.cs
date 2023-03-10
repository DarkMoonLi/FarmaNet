using System.Collections.Generic;
using System.Linq;
using FarmaNetBackend.Dto.MedicationDto;
using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Domain.IRepositories;
using FarmaNetBackend.Infrastructure;

namespace FarmaNetBackend.Domain.Repositories
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
            List<Medication> medications = _context.Medications.ToList();
            return medications;
        }

        public Medication GetMedicationById( int id )
        {
            Medication medication = (Medication)_context.Medications.Where(p => p.MedicationId == id);
            return medication;
        }

        public void AddMedication(AddMedicationDto medicationDto)
        {
            Medication medication = medicationDto.ConvertToMedication();
            _context.Medications.Add( medication );
        }

        public void UpdateMedication(UpdateMedicationDto medicationDto)
        {
            
        }

        public void DeleteMedication( int id )
        {
            Medication medication = _context.Medications.FirstOrDefault( o => o.MedicationId == id );
            if ( medication != null )
            {
                _context.Medications.Remove( medication );
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