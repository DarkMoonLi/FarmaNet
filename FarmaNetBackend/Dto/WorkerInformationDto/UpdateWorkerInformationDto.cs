using System;

namespace FarmaNetBackend.Dto.WorkerInformationDto
{
    public class UpdateWorkerInformationDto
    {
        public int WorkerInformationId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DataBirth { get; set; }
        public short SeriesPassport { get; set; }
        public short NumberPassport { get; set; }
        public float Experience { get; set; }
        public string Email { get; set; }
        public int PositionId { get; set; }
    }
}
