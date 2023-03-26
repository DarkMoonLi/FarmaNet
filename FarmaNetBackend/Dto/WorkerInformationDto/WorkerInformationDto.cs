using FarmaNetBackend.Models;
using Microsoft.AspNetCore.Http;
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
        public int WorkerInformationImageId { get; set; }

        public WorkerInformationDto(WorkerInformation workerInformation)
        {
            this.WorkerInformationId      = workerInformation.WorkerInformationId;
            this.Name                     = workerInformation.Name;
            this.LastName                 = workerInformation.LastName;
            this.DataBirth                = workerInformation.BirthDate;
            this.SeriesPassport           = workerInformation.PassportSeries;
            this.NumberPassport           = workerInformation.PassportNumber;
            this.Experience               = workerInformation.Experience;
            this.Email                    = workerInformation.Email;
            this.PositionId               = workerInformation.PositionId;
            this.WorkerInformationImageId = workerInformation.WorkerInformationImageId;
        }
    }
}
