using System.Collections.Generic;
using System.Linq;
using FarmaNetBackend.Dto.MedicationDto;
using FarmaNetBackend.Models.Medication;

namespace FarmaNetBackend.Infrastructure.Repositories
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
            Medication medication = (Medication)_context.Medications.Where(p => p._id == id);
            return medication;
        }

        public void AddMedication( MedicationDto medicationDto )
        {
            Medication medication = medicationDto.ConvertToMedication();
            _context.Medications.Add( medication );
        }

        public void DeleteMedication( int id )
        {
            Medication medication = _context.Medications.FirstOrDefault( o => o._id == id );
            if ( medication != null )
            {
                _context.Medications.Remove( medication );
            }
        }
    }

    public static class ConvertMedication
    {
        public static Medication ConvertToMedication( this MedicationDto medicationDto )
        {
            return new Medication
            {
                _name = medicationDto.Name,
                _recipe = medicationDto.Recipe,
                _idMedicationType = medicationDto.IdMedicationType,
                _typeMedication = medicationDto.MedicationType
            }; 
        }

        public static MedicationDto ConvertToMedicationDto( this Medication medication )
        {
            return new MedicationDto(medication)
            {
                Name = medication._name,
                Recipe = medication._recipe,
                IdMedicationType = medication._idMedicationType,
                MedicationType = medication._typeMedication
            };
        }

        public static MedicationDto ConvertToMedicationDtoById( this Medication medication )
        {
            return new MedicationDto(medication)
            {
                Name = medication._name,
                Recipe = medication._recipe,
                IdMedicationType = medication._idMedicationType
            };
        }
    }
}