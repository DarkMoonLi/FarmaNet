using FarmaNetBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarmaNetBackend.Configurations
{
    public class ImportWithMedicationConfiguration : IEntityTypeConfiguration<ImportWithMedication>
    {
        public void Configure(EntityTypeBuilder<ImportWithMedication> builder)
        {
            builder.HasKey(i => new { i.ImportId, i.MedicationId });

            builder.Property(i => i.Quantity).IsRequired().HasColumnType(Constants.columnTypeSmallInt);

            builder.Property(i => i.Price).HasColumnType(Constants.columnTypeMoney);

            builder.HasOne(i => i.Import).WithMany(i => i.ImportWithMedications).IsRequired().HasForeignKey(i => i.ImportId);
            builder.HasOne(i => i.Medication).WithMany(m => m.ImportWithMedications).IsRequired().HasForeignKey(i => i.MedicationId);
        }
    }
}
