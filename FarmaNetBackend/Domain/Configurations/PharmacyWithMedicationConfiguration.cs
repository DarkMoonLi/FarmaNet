using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class PharmacyWithMedicationConfiguration : EntityTypeConfiguration<PharmacyWithMedication>
    {
        public PharmacyWithMedicationConfiguration()
        {
            this.HasKey(p => new { p.PharmacyId, p.MedicationId });

            this.Property(p => p.Quantity).IsRequired().HasColumnType(Constants.columnTypeSmallInt);

            this.Property(p => p.Price).HasColumnType(Constants.columnTypeMoney);

            this.HasRequired(p => p.Pharmacy).WithMany(p => p.PharmacyWithMedications).HasForeignKey(p => p.PharmacyId);
            this.HasRequired(p => p.Medication).WithMany(m => m.PharmacyWithMedications).HasForeignKey(p => p.MedicationId);
        }
    }
}
