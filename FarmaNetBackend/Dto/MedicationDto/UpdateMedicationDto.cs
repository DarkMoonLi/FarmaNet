namespace FarmaNetBackend.Dto.MedicationDto
{
    public class UpdateMedicationDto
    {
        public int MedicationId { get; set; } 
        public string Name { get; set; }
        public string Recipe { get; set; }
        public int MedicationTypeId { get; set; }
    }
}
