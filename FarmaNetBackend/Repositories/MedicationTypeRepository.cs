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
            return _context.MedicationsTypes.ToList();
        }

        public MedicationType GetMedicationTypeById(GetMedicationTypeDto medicationTypeDto)
        {
            return _context.MedicationsTypes.FirstOrDefault(t => t.MedicationTypeId == medicationTypeDto.MedicationTypeId);
        }

        public void AddMedicationType(AddMedicationTypeDto medicationTypeDto)
        {
            MedicationType type = medicationTypeDto.ConvertToMedicationType();

            _context.MedicationsTypes.Add(type);
            _context.SaveChanges();
        }

        public void UpdateMedicationType(UpdateMedicationTypeDto medicationTypeDto)
        {
            MedicationType medicationType = GetMedicationTypeById(new GetMedicationTypeDto { MedicationTypeId = medicationTypeDto.MedicationTypeId });

            if (medicationType != null)
            {
                medicationType.Name = medicationTypeDto.Name;
                
                _context.MedicationsTypes.Update(medicationType);
                _context.SaveChanges();
            }
        }

        public void RemoveMedicationType(GetMedicationTypeDto medicationTypeDto)
        {
            MedicationType type = GetMedicationTypeById(medicationTypeDto);
            
            if (type != null)
            {
                _context.MedicationsTypes.Remove(type);
                _context.SaveChanges();
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
