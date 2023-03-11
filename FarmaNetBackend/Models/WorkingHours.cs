using System;

namespace FarmaNetBackend.Models
{
    public class WorkingHours
    {
        public int WorkingHoursId { get; set; }
        
        public int WorkerAccountId { get; set; }
        
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Description { get; set; }

        public WorkerAccount WorkerAccount { get; set; }


        public WorkingHours()
        { }
    }
}
