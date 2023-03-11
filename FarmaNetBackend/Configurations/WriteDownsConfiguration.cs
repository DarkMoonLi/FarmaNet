using FarmaNetBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarmaNetBackend.Configurations
{
    public class WriteDownsConfiguration : IEntityTypeConfiguration<WriteDowns>
    {
        public void Configure(EntityTypeBuilder<WriteDowns> builder)
        {
            builder.HasKey(w => new { w.PharmacyId, w.MedicationId });

            builder.Property(w => w.Quantity).IsRequired().HasColumnType(Constants.columnTypeSmallInt);

            builder.HasOne(w => w.Pharmacy).WithMany(p => p.WriteDowns).IsRequired().HasForeignKey(w => w.PharmacyId);
            builder.HasOne(w => w.Medication).WithMany(m => m.WriteDowns).IsRequired().HasForeignKey(w => w.MedicationId);
        }
    }
}
