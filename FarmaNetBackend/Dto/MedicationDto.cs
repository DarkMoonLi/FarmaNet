namespace FarmaNetBackend.Dto.MedicationDto
{
    public class MedicationDto
    {
        public int IdMedication { get; }
        public string Name { get; set; }
        public string Recipe { get; set; }
        public int IdMedicationType { get; set; }
    }
}
