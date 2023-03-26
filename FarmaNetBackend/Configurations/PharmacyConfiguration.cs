using FarmaNetBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarmaNetBackend.Configurations
{
    public class PharmacyConfiguration : IEntityTypeConfiguration<Pharmacy>
    {
        public void Configure(EntityTypeBuilder<Pharmacy> builder)
        {
            builder.HasKey(p => p.PharmacyId);

            builder.Property(p => p.Name).IsRequired().HasMaxLength(Constants.nameLength);

            builder.Property(p => p.Address).HasMaxLength(Constants.addressLength);
            builder.Property(p => p.Email).HasMaxLength(Constants.emailLength);
            builder.Property(p => p.Description).HasMaxLength(Constants.descriptionLength);
        }
    }
}
