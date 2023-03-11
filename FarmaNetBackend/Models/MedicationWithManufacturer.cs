namespace FarmaNetBackend.Models
{
    public class MedicationWithManufacturer
    {
        public int ManufacturerId { get; set; }
        public int MedicationId { get; set; }

        public Manufacturer Manufacturer { get; set; }
        public Medication Medication { get; set; }


        public MedicationWithManufacturer()
        { }
    }
}