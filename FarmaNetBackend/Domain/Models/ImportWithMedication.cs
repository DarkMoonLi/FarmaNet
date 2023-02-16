using System.Data.Entity;

namespace FarmaNetBackend.Domain.Models
{
    public class ImportWithMedication
    {
        public int ImportId { get; set; }
        public int MedicationId { get; set; }
        
        public float? Price { get; set; }
        public int Quantity { get; set; }

        public Import Import { get; set; }
        public Medication Medication { get; set; }


        public ImportWithMedication()
        { }
    }
}