using System;

namespace FarmaNetBackend.Dto.ImportDto
{
    public class ImportReportDto
    {
        public DateTime Date { get; set; }
        public double? SumPrice { get; set; }
        public string SupplierName { get; set; }
    }
}
