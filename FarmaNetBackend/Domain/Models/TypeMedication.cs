using System.Data.Entity;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.Models
{
    public class TypeMedication
    {
        public int _idMedicationType { get; set; }
        public string _name { get; set; }

        public virtual List<Medication> Medications { get; set; }
    }
}