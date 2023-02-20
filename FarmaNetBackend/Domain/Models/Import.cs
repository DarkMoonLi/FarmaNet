using System.Collections.Generic;
using System;

namespace FarmaNetBackend.Domain.Models
{
	public class Import
	{
		public int ImportId { get; set; }

		public int Number { get; set; }
		public DateTime Date { get; set; }
		public double? SumPrice { get; set; }
		
		
		public int SupplierId { get; set; }
		public int PharmacyId { get; set; }


		public virtual List<ImportWithMedication> ImportWithMedications { get; set; }
        public Supplier Supplier { get; set; }
        public Pharmacy Pharmacy { get; set; }


		public Import()
		{  }
	}
}