using FarmaNetBackend.Domain.Models;

namespace FarmaNetBackend.Dto.SaleDto
{
    public class AddSaleDto
    {
        public int MedicationId { get; set; }
        public int PharmacyId { get; set; }
        public int? Price { get; set; }
        public int Quantity { get; set; }

        public Sale ConvertToSale()
        {
            return new Sale
            {
                MedicationId = this.MedicationId,
                PharmacyId = this.PharmacyId,
                Price = this.Price,
                Quantity = this.Quantity
            };
        }
    }
}
