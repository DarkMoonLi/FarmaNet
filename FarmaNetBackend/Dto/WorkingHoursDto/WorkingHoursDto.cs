using System;

namespace FarmaNetBackend.Dto.WorkingHoursDto
{
    public class WorkingHoursDto
    {
        public int WorkingHoursId { get; set; }
        public int WorkerAccountId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Description { get; set; }
    }
}
