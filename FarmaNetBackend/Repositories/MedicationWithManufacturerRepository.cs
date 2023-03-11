using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.MedicationWithManufacturerDto;
using FarmaNetBackend.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace FarmaNetBackend.Repositories
{
    public class MedicationWithManufacturerRepository : IMedicationWithManufacturerRepository
    {
        readonly ApplicationDbContext _context;

        public MedicationWithManufacturerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<MedicationWithManufacturer> GetMedicationWithManufacturers()
        {
            return _context.MedicationWithManufacturers.ToList();
        }

        public MedicationWithManufacturer GetMedicationWithManufacturerById(int id)
        {
            // Поиск по ПК, если он состоит из нескольких столбцов.
            return (MedicationWithManufacturer)_context.MedicationWithManufacturers.Where(t => t.MedicationId == id);
        }

        public void AddMedicationWithManufacturer(AddMedicationWithManufacturerDto medicationWithManufacturerDto)
        {
            MedicationWithManufacturer type = medicationWithManufacturerDto.ConvertToMedicationWithManufacturer();

            _context.MedicationWithManufacturers.Add(type);
        }

        public void UpdateMedicationWithManufacturer(UpdateMedicationWithManufacturerDto medicationWithManufacturerDto)
        {
        }

        public void RemoveMedicationWithManufacturer(int id)
        {
            // Поиск по ПК, если он состоит из нескольких столбцов.
            MedicationWithManufacturer medication = _context.MedicationWithManufacturers.FirstOrDefault(t => t.MedicationId == id);

            if (medication != null)
            {
                _context.MedicationWithManufacturers.Remove(medication);
            }
        }
    }
}
