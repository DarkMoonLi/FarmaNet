﻿using FarmaNetBackend.IRepositories;
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
            return _context.Imports.ToList();
        }

        public Import GetImportById(GetImportDto importDto)
        {
            return _context.Imports.FirstOrDefault(i => i.ImportId == importDto.ImportId);
        }

        public void AddImport(AddImportDto importDto)
        {
            Import import = importDto.ConvertToImport();

            _context.Imports.Add(import);
            _context.SaveChanges();
        }

        public void UpdateImport(UpdateImportDto importDto)
        {
            Import import = GetImportById(new GetImportDto{ImportId = importDto.ImportId});

            if (import != null)
            {
                import.SupplierId = importDto.SupplierId;
                import.SumPrice = importDto.SumPrice;
                import.Number = importDto.Number;
                import.Date = importDto.Date;
                import.PharmacyId = importDto.PharmacyId;
                
                _context.Imports.Update(import);
                _context.SaveChanges();
            }
        }

        public void RemoveImport(GetImportDto importDto)
        {
            Import import = GetImportById(importDto);

            if (import != null)
            {
                _context.Imports.Remove(import);
                _context.SaveChanges();
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
