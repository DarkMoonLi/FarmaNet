using System.Collections.Generic;

namespace FarmaNetBackend.Domain.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string Inn { get; set; }

        public virtual List<Import> Imports { get; set; }


        public Supplier()
        { }
    }
}
