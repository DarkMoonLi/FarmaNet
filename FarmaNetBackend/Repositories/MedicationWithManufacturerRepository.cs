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

        public MedicationWithManufacturer GetMedicationWithManufacturerById(GetMedicationWithManufacturerDto medicationWithManufacturerDto)
        {
            return _context.MedicationWithManufacturers.FirstOrDefault(t => t.MedicationId == medicationWithManufacturerDto.MedicationId
                                                                            && t.ManufacturerId == medicationWithManufacturerDto.ManufacturerId);
        }

        public void AddMedicationWithManufacturer(AddMedicationWithManufacturerDto medicationWithManufacturerDto)
        {
            MedicationWithManufacturer medicationWithManufacturer = medicationWithManufacturerDto.ConvertToMedicationWithManufacturer();

            _context.MedicationWithManufacturers.Add(medicationWithManufacturer);
            _context.SaveChanges();
        }

        // Может и не нужно?
        public void UpdateMedicationWithManufacturer(UpdateMedicationWithManufacturerDto medicationWithManufacturerDto)
        {
            MedicationWithManufacturer medicationWithManufacturer = GetMedicationWithManufacturerById(new GetMedicationWithManufacturerDto
                                                                                                        {
                                                                                                        ManufacturerId = medicationWithManufacturerDto.ManufacturerId,
                                                                                                        MedicationId = medicationWithManufacturerDto.MedicationId
                                                                                                        });
            if (medicationWithManufacturer != null)
            {
                _context.MedicationWithManufacturers.Update(medicationWithManufacturer);
                _context.SaveChanges();
            }
        }

        public void RemoveMedicationWithManufacturer(GetMedicationWithManufacturerDto medicationWithManufacturerDto)
        {
            MedicationWithManufacturer medication = GetMedicationWithManufacturerById(medicationWithManufacturerDto);

            if (medication != null)
            {
                _context.MedicationWithManufacturers.Remove(medication);
                _context.SaveChanges();
            }
        }
    }
}
