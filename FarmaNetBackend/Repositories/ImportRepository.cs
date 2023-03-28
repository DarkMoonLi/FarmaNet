﻿using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.ImportDto;
using FarmaNetBackend.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using FarmaNetBackend.Dto.SupplierDto;

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

        public List<ImportReportDto> GetImportsByPharmacy(int id)
        {
            List<Import> imports = _context.Imports.Where(i => i.PharmacyId.Equals(id)).ToList();

            List<ImportReportDto> result = new List<ImportReportDto>();

            foreach (Import import in imports)
            {
                Supplier supplier = _context.Suppliers.FirstOrDefault(s => s.SupplierId.Equals(import.SupplierId));

                if (supplier != null)
                {
                    ImportReportDto importReportDto = new ImportReportDto();

                    importReportDto.SumPrice = import.SumPrice;
                    importReportDto.SupplierName = supplier.Name;
                    importReportDto.Date = import.Date;

                    result.Add(importReportDto);
                }
            }

            return result;
        }

    public List<SupplierDto> GetSupplierByPharmacy(int id)
        {
            List<SupplierDto> suppliers = (from i in _context.Imports
                                          join s in _context.Suppliers on i.SupplierId equals s.SupplierId
                                          where i.PharmacyId.Equals(id)
                                          select s).Distinct().ToList().ConvertAll(s => new SupplierDto(s));

            return suppliers;
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
