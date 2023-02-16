using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaNetBackend.Domain.Models
{
	public class Import
	{
		public int ImportId { get; set; }

		public int Number { get; set; }
		public DateOnly Date { get; set; }
		public float? SumPrice { get; set; }
		
		
		public int SupplierId { get; set; }
		public int PharmacyId { get; set; }


		public virtual List<ImportWithMedication> ImportWithMedications { get; set; }
        public Supplier Supplier { get; set; }
        public Pharmacy Pharmacy { get; set; }


		public Import()
		{  }
	}
}