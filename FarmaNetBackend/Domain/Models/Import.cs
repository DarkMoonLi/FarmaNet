using System;

namespace FarmaNetBackend.Models.Import
{
	public class Import
	{
		private int _idImport { get; set; }
        private int _number { get; set; }
        private DateOnly _date { get; set; }
        private float _sumPrice { get; set; }
        private int _idSupplier { get; set; }
        private int _idPharmacy { get; set; }
    }
}