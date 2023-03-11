using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.MedicationTypeDto;
using FarmaNetBackend.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace FarmaNetBackend.Repositories
{
    public class MedicationTypeRepository : IMedicationTypeRepository
    {
        readonly ApplicationDbContext _context;

        public MedicationTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<MedicationType> GetMedicationTypes()
        {
            List<MedicationType> types = _context.MedicationsTypes.ToList();

            return types;
        }

        public MedicationType GetMedicationTypeById(int id)
        {
            MedicationType type = (MedicationType)_context.MedicationsTypes.Where(t => t.MedicationTypeId == id);

            return type;
        }

        public void AddMedicationType(AddMedicationTypeDto medicationTypeDto)
        {
            MedicationType type = medicationTypeDto.ConvertToMedicationType();

            _context.MedicationsTypes.Add(type);
        }

        public void UpdateMedicationType(UpdateMedicationTypeDto medicationTypeDto)
        {
        }

        public void RemoveMedicationType(int id)
        {
            MedicationType type = _context.MedicationsTypes.FirstOrDefault(t => t.MedicationTypeId == id);
            
            if (type != null)
            {
                _context.MedicationsTypes.Remove(type);
            }
        }
    }

    public static class ConvertMedicationType
    {
        public static MedicationTypeDto ConvertToImportDto(this MedicationType medicationType)
        {
            return new MedicationTypeDto(medicationType);
        }
    }
}
