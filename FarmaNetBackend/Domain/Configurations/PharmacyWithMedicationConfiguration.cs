using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class PharmacyWithMedicationConfiguration : EntityTypeConfiguration<PharmacyWithMedication>
    {
        public PharmacyWithMedicationConfiguration()
        {
            this.Property(p => p._quantity).IsRequired().HasColumnType(Constants.columnTypeSmallInt);

            this.Property(p => p._price).HasColumnType(Constants.columnTypeMoney);
        }
    }
}
