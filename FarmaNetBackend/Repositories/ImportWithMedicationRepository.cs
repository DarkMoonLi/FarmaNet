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

        public ImportWithMedication GetImportWithMedicationById(int id)
        {
            ImportWithMedication importWithMedication = (ImportWithMedication)_context.ImportWithMedications.Where(i => i.ImportId == id);

            return importWithMedication;
        }

        public void AddImportWithMedication( AddImportWithMedicationDto importWithMedicationDto)
        {
            ImportWithMedication importWithMedication = importWithMedicationDto.ConvertToImportWithMedication();

            _context.ImportWithMedications.Add(importWithMedication);
        }

        public void UpdateImportWithMedication(UpdateImportWithMedicationDto importWithMedicationDto)
        { }

        public void RemoveImportWithMedication(int id)
        {
            ImportWithMedication importWithMedication = _context.ImportWithMedications.FirstOrDefault(i => i.ImportId == id);

            if (importWithMedication != null)
            {
                _context.ImportWithMedications.Remove(importWithMedication);
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
