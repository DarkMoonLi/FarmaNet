using System.Collections.Generic;

namespace FarmaNetBackend.Domain.Models
{
    public class WorkerAccount
    {
        public int _idWorkerAccount { get; set; }
        public string _login   { get; set; }
        public string _password { get; set; }
        public int _idWorkerInformation { get; set; }
        public int _idPharmacy { get; set; }

        public WorkerInformation WorkerInformation { get; set; }
        public Pharmacy Pharmacy { get; set; }

        public virtual List<WorkingHours> WorkingHours { get; set; }
    }
}