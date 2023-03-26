namespace FarmaNetBackend.Dto.MedicationDto
{
    public class UpdateMedicationDto
    {
        public int MedicationId { get; set; } 
        public string Name { get; set; }
        public string IndicationsForUse { get; set; }
        public string Composition { get; set; }
        public string Contraindications { get; set; }
        public string Instruction { get; set; }
        public int MedicationTypeId { get; set; }
        public int MedicationImageId { get; set; }
    }
}
