using System.Collections.Generic;

namespace FarmaNetBackend.Models
{
    public class MedicationType
    {
        public int MedicationTypeId { get; set; }
        public string Name { get; set; }

        public virtual List<Medication> Medications { get; set; }


        public MedicationType()
        { }
    }
}