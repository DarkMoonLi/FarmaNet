using System.Collections.Generic;
using System.Linq;
using FarmaNetBackend.Dto.MedicationDto;
using FarmaNetBackend.Models.Medication;
using Recipes.Infrastructure;

namespace FarmaNetBackend
{
    public class MedicationRepository : IMedicationRepository
    {
        readonly MedicationDbContext _context;

        public MedicationRepository( MedicationDbContext context )
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
            Medication medication = (Medication)_context.Medications.Where(p => p.GetId() == id);
            return medication;
        }

        public void AddMedication( MedicationDto medicationDto )
        {
            Medication medication = medicationDto.ConvertToMedication();
            _context.Medications.Add( medication );
        }

        public void DeleteMedication( int id )
        {
            Medication medication = _context.Medications.FirstOrDefault( o => o.GetId() == id );
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
            return new Medication( 
                medicationDto.Name,
                medicationDto.Recipe,
                medicationDto.IdMedicationType 
            );
        }

        public static MedicationDto ConvertToMedicationDto( this Medication medication )
        {
            return new MedicationDto
            {
                Name = medication.GetName(),
                Recipe = medication.GetRecipe(),
                IdMedicationType = medication.GetTypeId()
            };
        }

        public static MedicationDto ConvertToMedicationDtoById( this Medication medication )
        {
            return new MedicationDto
            {
                Name = medication.GetName(),
                Recipe = medication.GetRecipe(),
                IdMedicationType = medication.GetTypeId()
            };
        }
    }
}