namespace FarmaNetBackend.Domain.Models
{
    public class MedicationWithManufacturer
    {
        public int _idManufacturer { get; set; }
        public int _idMedication { get; set; }

        public Manufacturer Manufacturer { get; set; }
        public Medication Medication { get; set; }
    }
}