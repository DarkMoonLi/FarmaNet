using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class ImportWithMedicationConfiguration : EntityTypeConfiguration<ImportWithMedication>
    {
        public ImportWithMedicationConfiguration()
        {
            this.HasKey(i => new { i.ImportId, i.MedicationId });

            this.Property(i => i.Quantity).IsRequired().HasColumnType(Constants.columnTypeSmallInt);
            
            this.Property(i => i.Price).HasColumnType(Constants.columnTypeMoney);

            this.HasRequired(i => i.Import).WithMany(i => i.ImportWithMedications).HasForeignKey(i => i.ImportId);
            this.HasRequired(i => i.Medication).WithMany(m => m.ImportWithMedications).HasForeignKey(i => i.MedicationId);
        }
    }
}
