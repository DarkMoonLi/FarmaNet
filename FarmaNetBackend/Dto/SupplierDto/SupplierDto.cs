using FarmaNetBackend.Models;

namespace FarmaNetBackend.Dto.SupplierDto
{
    public class SupplierDto
    {
        public int SupplierId { get; }
        public string Name { get; set; }
        public string Inn { get; set; }

        public SupplierDto(Supplier supplier)
        {
            SupplierId = supplier.SupplierId;
            Name = supplier.Name;
            Inn = supplier.Inn;
        }
    }
}
