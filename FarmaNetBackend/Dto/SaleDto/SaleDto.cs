using FarmaNetBackend.Models;

namespace FarmaNetBackend.Dto.SaleDto
{
    public class SaleDto
    {
        public int MedicationId { get; set; }
        public int PharmacyId { get; set; }
        public double? Price { get; set; }
        public int Quantity { get; set; }

        public SaleDto(Sale sale)
        {
            MedicationId = sale.MedicationId;
            PharmacyId = sale.PharmacyId;
            Price = sale.Price;
            Quantity = sale.Quantity;
        }
    }
}
