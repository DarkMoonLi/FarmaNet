using FarmaNetBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarmaNetBackend.Configurations
{
    public class PharmacyWithMedicationConfiguration : IEntityTypeConfiguration<PharmacyWithMedication>
    {
        public void Configure(EntityTypeBuilder<PharmacyWithMedication> builder)
        {
            builder.HasKey(p => new { p.PharmacyId, p.MedicationId });

            builder.Property(p => p.Quantity).IsRequired().HasColumnType(Constants.columnTypeSmallInt);

            builder.Property(p => p.Price).HasColumnType(Constants.columnTypeMoney);

            builder.HasOne(p => p.Pharmacy).WithMany(p => p.PharmacyWithMedications).IsRequired().HasForeignKey(p => p.PharmacyId);
            builder.HasOne(p => p.Medication).WithMany(m => m.PharmacyWithMedications).IsRequired().HasForeignKey(p => p.MedicationId);
        }
    }
}
