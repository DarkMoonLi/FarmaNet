using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Dto.ImportWithMedicationDto;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.IRepositories
{
    public interface IImportWithMedicationRepository
    {
        public List<ImportWithMedication> GetImportWithMedications();
        public ImportWithMedication GetImportWithMedicationById(int id);
        public void AddImportWithMedication(ImportWithMedicationDto importWithMedicationDto);
        public void UpdateImportWithMedication(ImportWithMedicationDto importWithMedicationDto);
        public void RemoveImportWithMedication(int id);

    }
}
