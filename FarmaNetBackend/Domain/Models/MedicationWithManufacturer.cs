using System.Data.Entity;

namespace FarmaNetBackend.Domain.Models
{
    public class MedicationWithManufacturer
    {
        public int ManufacturerId { get; set; }
        public int MedicationId { get; set; }

        public Manufacturer Manufacturer { get; set; }
        public Medication Medication { get; set; }
    }
}