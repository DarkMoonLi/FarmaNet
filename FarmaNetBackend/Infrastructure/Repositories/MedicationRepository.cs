using System.Collections.Generic;
using System.Linq;
using FarmaNetBackend.Dto.MedicationDto;
using FarmaNetBackend.Models;
using FarmaNetBackend.Domain.IRepositories;
using FarmaNetBackend.Data;

namespace FarmaNetBackend.Infrastructure.Repositories
{
    public class MedicationRepository : IMedicationRepository
    {
        readonly PharmacyDbContext _context;

        public MedicationRepository( PharmacyDbContext context )
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
            Medication medication = (Medication)_context.Medications.Where(p => p.Id == id);
            return medication;
        }

        public void AddMedication( MedicationDto medicationDto )
        {
            Medication medication = medicationDto.ConvertToMedication();
            _context.Medications.Add( medication );
        }

        public void DeleteMedication( int id )
        {
            Medication medication = _context.Medications.FirstOrDefault( o => o.Id == id );
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
                Name = medicationDto.Name,
                Recipe = medicationDto.Recipe,
                IdMedicationType = medicationDto.IdMedicationType,
                TypeMedication = medicationDto.TypeMedication
            }; 
        }

        public static MedicationDto ConvertToMedicationDto( this Medication medication )
        {
            return new MedicationDto(medication);
            /*{
                Name = medication.Name,
                Recipe = medication.Recipe,
                IdMedicationType = medication.IdMedicationType,
                TypeMedication = medication.TypeMedication
            };*/
        }

        public static MedicationDto ConvertToMedicationDtoById( this Medication medication )
        {
            return new MedicationDto(medication);
            /*{
                Name = medication.GetName(),
                Recipe = medication.GetRecipe(),
                IdMedicationType = medication.GetTypeId()
            };*/
        }
    }
}