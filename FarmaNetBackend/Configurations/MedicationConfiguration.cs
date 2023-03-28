using FarmaNetBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarmaNetBackend.Configurations
{
    public class MedicationConfiguration : IEntityTypeConfiguration<Medication>
    {
        public void Configure(EntityTypeBuilder<Medication> builder)
        {
            builder.HasKey(m => m.MedicationId);

            builder.Property(m => m.Name).IsRequired().HasMaxLength(Constants.nameLength);

            builder.Property(m => m.IndicationsForUse).HasMaxLength(Constants.descriptionLength).HasColumnType(Constants.columnTypeText);
            builder.Property(m => m.Composition).HasMaxLength(Constants.descriptionLength).HasColumnType(Constants.columnTypeText);
            builder.Property(m => m.Contraindications).HasMaxLength(Constants.descriptionLength).HasColumnType(Constants.columnTypeText);
            builder.Property(m => m.Instruction).HasMaxLength(Constants.descriptionLength).HasColumnType(Constants.columnTypeText);
            
            builder.HasOne(m => m.MedicationType).WithMany(m => m.Medications).IsRequired().HasForeignKey(m => m.MedicationTypeId);
        }
    }
}
