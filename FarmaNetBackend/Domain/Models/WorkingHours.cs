using System;
using System.Data.Entity;

namespace FarmaNetBackend.Domain.Models
{
    public class WorkingHours
    {
        public int WorkingHoursId { get; set; }
        
        public int WorkerAccountId { get; set; }
        
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string Description { get; set; }

        public WorkerAccount WorkerAccount { get; set; }
    }
}
