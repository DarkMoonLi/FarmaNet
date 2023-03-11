using FarmaNetBackend.Domain.IRepositories;
using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Dto.ImportDto;
using FarmaNetBackend.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace FarmaNetBackend.Infrastructure.Repositories
{
    public class ImportRepository : IImportRepository
    {
        readonly ApplicationDbContext _context;

        public ImportRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Import> GetImports()
        {
            List<Import> imports = _context.Imports.ToList();

            return imports;
        }

        public Import GetImportById(int id)
        {
            Import import = (Import)_context.Imports.Where(i => i.ImportId == id);

            return import;
        }

        public void AddImport(ImportDto importDto)
        {
            Import import = importDto.ConvertToImport();

            _context.Imports.Add(import);
        }

        public void UpdateImport(ImportDto importDto)
        {

        }

        public void RemoveImport(int id)
        {
            Import import = _context.Imports.FirstOrDefault(i => i.ImportId == id);

            if (import != null)
            {
                _context.Imports.Remove(import);
            }
        }
    }

    public static class ConvertImport
    {
        public static Import ConvertToImport( this ImportDto importDto)
        {
            return new Import
            {
                Date       = importDto.Date,
                ImportId   = importDto.ImportId,
                Number     = importDto.Number,
                PharmacyId = importDto.PharmacyId,
                SumPrice   = importDto.SumPrice,
                SupplierId = importDto.SupplierId
            };
        }

        public static ImportDto ConvertToImportDto( this Import import)
        {
            return new ImportDto(import);
        }
    }
}
