using FarmaNetBackend.Models;
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

        public WorkingHoursDto(WorkingHours workingHours)
        {
            WorkingHoursId = workingHours.WorkingHoursId;
            WorkerAccountId = workingHours.WorkerAccountId;
            Date = workingHours.Date;
            Time = workingHours.Time;
            Description = workingHours.Description;
        }
    }
}
