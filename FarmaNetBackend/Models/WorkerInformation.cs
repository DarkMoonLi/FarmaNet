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
        public short? PassportSeries { get; set; }
        public short? PassportNumber { get; set; }
        public float? Experience { get; set; }

        public Position Position { get; set; }
        public virtual List<WorkerAccount> WorkerAccounts { get; set; }


        public WorkerInformation()
        { }
    }
}