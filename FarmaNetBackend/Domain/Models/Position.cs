using System.Collections.Generic;

namespace FarmaNetBackend.Domain.Models
{
    public class Position
    {
        public int _idPosition { get; set; }
        public string _position { get; set; }
        public float _salaryInHours { get; set; }

        public virtual List<WorkerInformation> WorkerInformations { get; set; }
    }
}