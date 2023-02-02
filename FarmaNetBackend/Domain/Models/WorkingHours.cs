using System;

namespace FarmaNetBackend.Domain.Models
{
    public class WorkingHours
    {
        public int _idWorkingHours { get; set; }
        public int _idWorkerAccount { get; set; }
        public DateOnly _date { get; set; }
        public TimeOnly _time { get; set; }
        public string _description { get; set; }

        public WorkerAccount WorkerAccount { get; set; }
    }
}
