using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class ImportWithMedicationConfiguration : EntityTypeConfiguration<ImportWithMedication>
    {
        public ImportWithMedicationConfiguration()
        {
            this.Property(i => i._quantity).IsRequired().HasColumnType(Constants.columnTypeSmallInt);
            
            this.Property(i => i._price).HasColumnType(Constants.columnTypeMoney);
        }
    }
}
