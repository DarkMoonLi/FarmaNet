using System.Data.Entity;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.Models
{
    public class Supplier
    {
        public int _idSupplier { get; set; }
        public string _name { get; set; }
        public string _inn { get; set; }

        public virtual List<Import> Imports { get; set; }
    }
}
