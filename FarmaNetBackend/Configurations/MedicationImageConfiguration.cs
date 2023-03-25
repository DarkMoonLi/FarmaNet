using FarmaNetBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarmaNetBackend.Configurations
{
    public class MedicationImageConfiguration : IEntityTypeConfiguration<MedicationImage>
    {
        public void Configure(EntityTypeBuilder<MedicationImage> builder)
        {
            builder.HasKey(m => m.ImageId);

            builder.Property(m => m.Title).IsRequired().HasMaxLength(Constants.nameLength);
            builder.Property(m => m.Path).IsRequired().HasMaxLength(Constants.imagePathLength);

            builder.HasOne(m => m.Medication).WithOne(m => m.MedicationImage).IsRequired().HasForeignKey<Medication>(m => m.MedicationImageId);
        }
    }
}
