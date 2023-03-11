using System.Collections.Generic;

namespace FarmaNetBackend.Models
{
    public class WorkerAccount
    {
        public int WorkerAccountId { get; set; }
        
        public string Login { get; set; }
        public string Password { get; set; }
        
        public int WorkerInformationId { get; set; }
        public int PharmacyId { get; set; }

        public WorkerInformation WorkerInformation { get; set; }
        public Pharmacy Pharmacy { get; set; }

        public virtual List<WorkingHours> WorkingHours { get; set; }


        public WorkerAccount()
        { }
    }
}