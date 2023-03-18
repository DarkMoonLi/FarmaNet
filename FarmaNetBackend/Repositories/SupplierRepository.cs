using FarmaNetBackend.Dto.SupplierDto;
using FarmaNetBackend.Infrastructure;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using System.Collections.Generic;
using System.Linq;

namespace FarmaNetBackend.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        ApplicationDbContext _context;

        public SupplierRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Supplier> GetSuppliers()
        {
            return _context.Suppliers.ToList();
        }

        public Supplier GetSupplierById(GetSupplierDto supplierDto)
        {
            return _context.Suppliers.FirstOrDefault(s => s.SupplierId == supplierDto.SupplierId);
        }

        public void AddSupplier(AddSupplierDto supplierDto)
        {
            Supplier supplier = supplierDto.ConvertToSupplier();
            
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
        }

        public void UpdateSupplier(UpdateSupplierDto supplierDto)
        {
            Supplier supplier = GetSupplierById(new GetSupplierDto{SupplierId = supplierDto.SupplierId});

            if (supplier != null)
            {
                supplier.Name = supplierDto.Name;
                supplier.Inn = supplierDto.Inn;

                _context.Suppliers.Update(supplier);
                _context.SaveChanges();
            }
        }

        public void RemoveSupplier(GetSupplierDto supplierDto)
        {
            Supplier supplier = GetSupplierById(supplierDto);

            if (supplier != null)
            {
                _context.Suppliers.Remove(supplier);
                _context.SaveChanges();
            }
        }
    }
}
