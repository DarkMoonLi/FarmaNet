using System.Data.Entity;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.Models
{
    public class Position
    {
        public int PositionId { get; set; }
        
        public string Post { get; set; }
        public float? SalaryInHours { get; set; }

        public virtual List<WorkerInformation> WorkerInformations { get; set; }


        public Position()
        { }
    }
}