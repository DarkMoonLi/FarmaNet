namespace FarmaNetBackend.Dto.SaleDto
{
    public class SaleDto
    {
        public int MedicationId { get; set; }
        public int PharmacyId { get; set; }
        public int? Price { get; set; }
        public int Quantity { get; set; }
    }
}
