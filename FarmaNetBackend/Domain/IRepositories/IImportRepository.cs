using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Dto.ImportDto;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.IRepositories
{
    public interface IImportRepository
    {
        public List<Import> GetImports();
        public Import GetImportById(int id);
        public void AddImport(ImportDto importDto);
        public void UpdateImport(ImportDto importDto);
        public void RemoveImport(int id);
    }
}
