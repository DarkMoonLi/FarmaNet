using FarmaNetBackend.Models;
using System;

namespace FarmaNetBackend.Dto.WorkerInformationDto
{
    public class WorkerInformationDto
    {
        public int WorkerInformationId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DataBirth { get; set; }
        public short? SeriesPassport { get; set; }
        public short? NumberPassport { get; set; }
        public float? Experience { get; set; }
        public string Email { get; set; }
        public int PositionId { get; set; }

        public WorkerInformationDto(WorkerInformation workerInformation)
        {
            WorkerInformationId = workerInformation.WorkerInformationId;
            Name = workerInformation.Name;
            LastName = workerInformation.LastName;
            DataBirth = workerInformation.BirthDate;
            SeriesPassport = workerInformation.PassportSeries;
            NumberPassport = workerInformation.PassportNumber;
            Experience = workerInformation.Experience;
            Email = workerInformation.Email;
            PositionId = workerInformation.PositionId;
        }
    }
}
