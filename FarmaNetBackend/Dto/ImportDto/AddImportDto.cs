using FarmaNetBackend.Models;
using System;

namespace FarmaNetBackend.Dto.ImportDto
{
    public class AddImportDto
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double? SumPrice { get; set; }
        public int SupplierId { get; set; }
        public int PharmacyId { get; set; }

        public Import ConvertToImport()
        {
            return new Import
            {
                Number = this.Number,
                Date = this.Date,
                SumPrice = this.SumPrice,
                SupplierId = this.SupplierId,
                PharmacyId = this.PharmacyId
            };
        }
    }
}
