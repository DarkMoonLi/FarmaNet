using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.ImportDto;
using System.Collections.Generic;

namespace FarmaNetBackend.IRepositories
{
    public interface IImportRepository
    {
        public List<Import> GetImports();
        public Import GetImportById(int id);
        public void AddImport(AddImportDto importDto);
        public void UpdateImport(UpdateImportDto importDto);
        public void RemoveImport(int id);
    }
}
