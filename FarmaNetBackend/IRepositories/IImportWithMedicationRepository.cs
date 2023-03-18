using FarmaNetBackend.Dto.ImportWithMedicationDto;
using FarmaNetBackend.Models;
using System.Collections.Generic;

namespace FarmaNetBackend.IRepositories
{
    public interface IImportWithMedicationRepository
    {
        public List<ImportWithMedication> GetImportWithMedications();
        public ImportWithMedication GetImportWithMedicationById(GetImportWithMedicationDto importWithMedicationDto);
        public void AddImportWithMedication(AddImportWithMedicationDto importWithMedicationDto);
        public void UpdateImportWithMedication(UpdateImportWithMedicationDto importWithMedicationDto);
        public void RemoveImportWithMedication(GetImportWithMedicationDto importWithMedicationDto);

    }
}
