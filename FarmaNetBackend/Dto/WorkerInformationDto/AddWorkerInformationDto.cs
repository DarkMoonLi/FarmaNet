using FarmaNetBackend.Models;
using System;

namespace FarmaNetBackend.Dto.WorkerInformationDto
{
    public class AddWorkerInformationDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DataBirth { get; set; }
        public short SeriesPassport { get; set; }
        public short NumberPassport { get; set; }
        public float Experience { get; set; }
        public string Email { get; set; }
        public int PositionId { get; set; }

        public WorkerInformation ConvertToWorkerInformation()
        {
            return new WorkerInformation
            {
                Name = this.Name,
                LastName = this.LastName,
                BirthDate = this.DataBirth,
                PassportSeries = this.SeriesPassport,
                PassportNumber = this.NumberPassport,
                Experience = this.Experience,
                Email = this.Email,
                PositionId = this.PositionId
            };
        }
    }
}
