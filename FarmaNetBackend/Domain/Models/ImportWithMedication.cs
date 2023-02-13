using System.Data.Entity;

namespace FarmaNetBackend.Domain.Models
{
    public class ImportWithMedication
    {
        //public int _idImport { get; set; }
        //public int _idMedication { get; set; }
        
        public float _price { get; set; }
        public int _quantity { get; set; }

        public Import Import { get; set; }
        public Medication Medication { get; set; }
    }
}