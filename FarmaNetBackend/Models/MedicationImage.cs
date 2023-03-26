using System.Collections.Generic;

namespace FarmaNetBackend.Models
{
    public class MedicationImage
    {
        public int ImageId { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }

        public Medication Medication { get; set; }

        
        public MedicationImage()
        { }
    }
}
