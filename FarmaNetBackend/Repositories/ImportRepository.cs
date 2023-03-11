﻿﻿using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.ImportDto;
using FarmaNetBackend.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace FarmaNetBackend.Repositories
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

        public void AddImport(AddImportDto importDto)
        {
            Import import = importDto.ConvertToImport();

            _context.Imports.Add(import);
        }

        public void UpdateImport(UpdateImportDto importDto)
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
        public static ImportDto ConvertToImportDto( this Import import)
        {
            return new ImportDto(import);
        }
    }
}