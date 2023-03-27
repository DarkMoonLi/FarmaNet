namespace FarmaNetBackend.Models
{
    public class ImportWithMedication
    {
        public int ImportId { get; set; }
        public int MedicationId { get; set; }
        
        public double? Price { get; set; }
        public int Quantity { get; set; }

        public Import Import { get; set; }
        public Medication Medication { get; set; }


        public ImportWithMedication()
        { }
    }
}