using System.Collections.Generic;

namespace FarmaNetBackend.Models
{
    public class Medication
    {
        public int MedicationId { get; set; }
        public string Name { get; set; }
        public string Recipe { get; set; }
        public int MedicationTypeId { get; set; }
        public MedicationType MedicationType { get; set; }

        public virtual List<MedicationWithManufacturer> MedicationWithManufacturers { get; set; }
        public virtual List<ImportWithMedication> ImportWithMedications { get; set; }
        public virtual List<PharmacyWithMedication> PharmacyWithMedications { get; set; }
        public virtual List<WriteDowns> WriteDowns { get; set; }
        public virtual List<Sale> Sales { get; set; }


        public Medication()
        { }
    }
}
