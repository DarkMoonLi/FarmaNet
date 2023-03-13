using FarmaNetBackend.Dto.ImportWithMedicationDto;
using FarmaNetBackend.Infrastructure;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using System.Collections.Generic;
using System.Linq;

namespace FarmaNetBackend.Repositories
{
    public class ImportWithMedicationRepository : IImportWithMedicationRepository
    {
        readonly ApplicationDbContext _context;

        public ImportWithMedicationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<ImportWithMedication> GetImportWithMedications()
        {
            List<ImportWithMedication> importWithMedications = _context.ImportWithMedications.ToList();

            return importWithMedications;
        }

        public ImportWithMedication GetImportWithMedicationById(GetImportWithMedicationDto importWithMedicationDto)
        {
            return _context.ImportWithMedications.FirstOrDefault(i => i.ImportId == importWithMedicationDto.ImportId
                                                                    && i.MedicationId == importWithMedicationDto.MedicationId);
        }

        public void AddImportWithMedication(AddImportWithMedicationDto importWithMedicationDto)
        {
            ImportWithMedication importWithMedication = importWithMedicationDto.ConvertToImportWithMedication();

            _context.ImportWithMedications.Add(importWithMedication);
            _context.SaveChanges();
        }

        public void UpdateImportWithMedication(UpdateImportWithMedicationDto importWithMedicationDto)
        {
            ImportWithMedication importWithMedication = GetImportWithMedicationById(new GetImportWithMedicationDto
                                                                                    { 
                                                                                    ImportId = importWithMedicationDto.ImportId,
                                                                                    MedicationId = importWithMedicationDto.MedicationId
                                                                                    });

            if (importWithMedication != null)
            {
                importWithMedication.Quantity = importWithMedicationDto.Quantity;
                importWithMedication.Price = importWithMedicationDto.Price;

                _context.ImportWithMedications.Update(importWithMedication);
                _context.SaveChanges();
            }
        }

        public void RemoveImportWithMedication(GetImportWithMedicationDto importWithMedicationDto)
        {
            ImportWithMedication importWithMedication = GetImportWithMedicationById(importWithMedicationDto);

            if (importWithMedication != null)
            {
                _context.ImportWithMedications.Remove(importWithMedication);
                _context.SaveChanges();
            }
        }
    }

    public static class ConvertImportWithMedication
    {
        public static ImportWithMedicationDto ConvertToImportWithMedicationDto(this ImportWithMedication importWithMedication)
        {
            return new ImportWithMedicationDto(importWithMedication);
        }
    }
}
