namespace FarmaNetBackend.Dto.SaleDto
{
    public class UpdateSaleDto
    {
        public int MedicationId { get; set; }
        public int PharmacyId { get; set; }
        public int? Price { get; set; }
        public int Quantity { get; set; }
    }
}
