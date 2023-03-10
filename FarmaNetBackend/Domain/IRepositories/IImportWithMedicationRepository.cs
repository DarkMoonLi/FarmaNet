using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Dto.ImportWithMedicationDto;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.IRepositories
{
    public interface IImportWithMedicationRepository
    {
        public List<ImportWithMedication> GetImportWithMedications();
        public ImportWithMedication GetImportWithMedicationById(int id);
        public void AddImportWithMedication(AddImportWithMedicationDto importWithMedicationDto);
        public void UpdateImportWithMedication(UpdateImportWithMedicationDto importWithMedicationDto);
        public void RemoveImportWithMedication(int id);

    }
}
