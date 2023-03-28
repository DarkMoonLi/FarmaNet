using System;
using System.Collections.Generic;

namespace FarmaNetBackend.Models
{
    public class WorkerInformation
    {
        public int WorkerInformationId { get; set; }
        
        public int PositionId { get; set; }
        
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public int? PassportSeries { get; set; }
        public int? PassportNumber { get; set; }
        public float? Experience { get; set; }
        public int WorkerInformationImageId { get; set; }
       
        public WorkerInformationImage WorkerInformationImage{ get; set; }
        public Position Position { get; set; }

        public virtual List<WorkerAccount> WorkerAccounts { get; set; }


        public WorkerInformation()
        { }
    }
}