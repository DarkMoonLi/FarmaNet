using FarmaNetBackend.Domain.Models;
using System;

namespace FarmaNetBackend.Dto.ImportDto
{
    public class ImportDto
    {
        public int ImportId { get; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double? SumPrice { get; set; }
        public int SupplierId { get; set; }
        public int PharmacyId { get; set; }

        public ImportDto(Import import)
        {
            ImportId   = import.ImportId;
            Number     = import.Number;
            Date       = import.Date;
            SumPrice   = import.SumPrice;
            SupplierId = import.SupplierId;
            PharmacyId = import.PharmacyId;
        }
    }
}
