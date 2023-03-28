namespace FarmaNetBackend.Dto.SaleDto
{
    public class SaleReportDto
    {
        public string MedicationName { get; set; }
        public double? Price { get; set; }
        public int Quantity { get; set; }
        public double? Sum { get; set; }
    }
}
