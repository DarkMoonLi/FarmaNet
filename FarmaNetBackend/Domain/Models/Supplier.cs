using System.Collections.Generic;

namespace FarmaNetBackend.Domain.Models
{
    public class Supplier
    {
        public int _idSupplier { get; set; }
        public int _name { get; set; }
        public int _inn { get; set; }

        public virtual List<Import> Imports { get; set; }
    }
}
