﻿using System.Collections.Generic;

namespace FarmaNetBackend.Models
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }
        
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual List<MedicationWithManufacturer> MedicationWithManufacturers { get; set; }


        public Manufacturer()
        { }
    }
}
