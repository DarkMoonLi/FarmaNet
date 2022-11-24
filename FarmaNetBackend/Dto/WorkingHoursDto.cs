using System;

namespace FarmaNetBackend.Dto.WorkingHours
{
    public class WorkingHoursDto
    {
        public int IdWorkingHours { get; }
        public int IdWorkerAccount { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Description { get; set; }
    }
}
