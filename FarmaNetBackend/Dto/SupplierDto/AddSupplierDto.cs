using FarmaNetBackend.Domain.Models;

namespace FarmaNetBackend.Dto.SupplierDto
{
    public class AddSupplierDto
    {
        public string Name { get; set; }
        public string Inn { get; set; }

        public Supplier ConvertToSupplier()
        {
            return new Supplier
            {
                Name = this.Name,
                Inn = this.Inn
            };
        }
    }
}
