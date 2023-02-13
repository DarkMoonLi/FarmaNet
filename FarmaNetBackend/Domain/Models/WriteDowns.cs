using System.Data.Entity;

namespace FarmaNetBackend.Domain.Models
{
    public class WriteDowns
    {   
        public int _quantity { get; set; }

        public Pharmacy Pharmacy { get; set; }
        public Medication Medication { get; set; }
    }
}