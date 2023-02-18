using System.Collections.Generic;

namespace FarmaNetBackend.Domain.Models
{
    public class Pharmacy
    {
        public int PharmacyId { get; set; }
        
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }

        public virtual List<WorkerAccount> WorkerAccounts { get; set; }
        public virtual List<WriteDowns> WriteDowns { get; set; }
        public virtual List<Import> Imports { get; set; }
        public virtual List<PharmacyWithMedication> PharmacyWithMedications { get; set; }
        public virtual List<Sale> Sales { get; set; }


        public Pharmacy()
        {
            
        }
    }
}
