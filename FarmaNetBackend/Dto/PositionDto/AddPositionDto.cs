using FarmaNetBackend.Domain.Models;

namespace FarmaNetBackend.Dto.PositionDto
{
    public class AddPositionDto
    {
        public string Position { get; set; }
        public float? SalaryInHours { get; set; }

        public Position ConvertToPosition()
        {
            return new Position
            {
                Post = this.Position,
                SalaryInHours = this.SalaryInHours
            };
        }
    }
}
