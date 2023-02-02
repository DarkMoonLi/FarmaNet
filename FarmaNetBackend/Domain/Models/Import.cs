using System;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.Models
{
	public class Import
	{
		public int _idImport { get; set; }
		public int _number { get; set; }
		public DateOnly _date { get; set; }
		public float _sumPrice { get; set; }
		public int _idSupplier { get; set; }
		public int _idPharmacy { get; set; }

		public virtual List<ImportWithMedication> ImportWithMedications { get; set; }
        public Supplier Supplier { get; set; }
        public Pharmacy Pharmacy { get; set; }
	}
}