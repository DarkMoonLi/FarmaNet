using FarmaNetBackend.Models;
using System;

namespace FarmaNetBackend.Dto.WorkingHoursDto
{
    public class AddWorkingHoursDto
    {
        public int WorkerAccountId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Description { get; set; }

        public WorkingHours ConvertToWorkingHours()
        {
            return new WorkingHours
            {
                WorkerAccountId = this.WorkerAccountId,
                Date = this.Date,
                Time = this.Time,
                Description = this.Description
            };
        }
    }
}
