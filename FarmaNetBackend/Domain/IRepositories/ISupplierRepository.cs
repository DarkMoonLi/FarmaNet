using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Dto.SupplierDto;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.IRepositories
{
    public interface ISupplierRepository
    {
        public List<Supplier> GetSuppliers();
        public Supplier GetSupplierById(int id);
        public void AddSupplier(AddSupplierDto supplierDto);
        public void UpdateSupplier(UpdateSupplierDto supplierDto);
        public void RemoveSupplier(int id);
    }
}
