using FarmaNetBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarmaNetBackend.Configurations
{
    public class PharmacyImageConfiguration : IEntityTypeConfiguration<PharmacyImage>
    {
        public void Configure(EntityTypeBuilder<PharmacyImage> builder)
        {
            builder.HasKey(p => p.ImageId);

            builder.Property(p => p.Title).IsRequired().HasMaxLength(Constants.nameLength);
            builder.Property(p => p.Path).IsRequired().HasMaxLength(Constants.imagePathLength);

            builder.HasOne(p => p.Pharmacy).WithOne(p => p.PharmacyImage).IsRequired().HasForeignKey<Pharmacy>(p => p.PharmacyImageId);
        }
    }
}
