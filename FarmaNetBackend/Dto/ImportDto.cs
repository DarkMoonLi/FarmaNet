using System;

namespace FarmaNetBackend.Dto.ImportDto
{
    public class ImportDto
    {
        public int IdImport { get; }
        public short Number { get; set; }
        public DateTime Date { get; set; }
        public double SumPrice { get; set; }
        public int IdSupplier { get; set; }
        public int IdPharmacy { get; set; }
    }
}
