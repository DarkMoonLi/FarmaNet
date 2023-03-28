using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.ImportDto;
using System.Collections.Generic;
using FarmaNetBackend.Dto.SupplierDto;

namespace FarmaNetBackend.IRepositories
{
    public interface IImportRepository
    {
        public List<Import> GetImports();
        public List<ImportReportDto> GetImportsByPharmacy(int id);
        public List<SupplierDto> GetSupplierByPharmacy(int id);
        public Import GetImportById(GetImportDto importDto);
        public void AddImport(AddImportDto importDto);
        public void UpdateImport(UpdateImportDto importDto);
        public void RemoveImport(GetImportDto importDto);
    }
}
