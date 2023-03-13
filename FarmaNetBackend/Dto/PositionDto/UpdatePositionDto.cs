namespace FarmaNetBackend.Dto.PositionDto
{
    public class UpdatePositionDto
    {
        public int PositionId { get; set; }
        public string Position { get; set; }
        public float? SalaryInHours { get; set; }
    }
}
