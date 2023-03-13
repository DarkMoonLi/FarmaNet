using FarmaNetBackend.Models;

namespace FarmaNetBackend.Dto.PositionDto
{
    public class PositionDto
    {
        public int PositionId { get; set; }
        public string Position { get; set; }
        public float? SalaryInHours { get; set; }

        public PositionDto(Position position)
        {
            PositionId = position.PositionId;
            Position = position.Post;
            SalaryInHours = position.SalaryInHours;
        }
    }
}