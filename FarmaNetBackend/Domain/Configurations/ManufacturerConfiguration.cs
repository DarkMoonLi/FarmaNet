using FarmaNetBackend.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarmaNetBackend.Domain.Configurations
{
    public class ManufacturerConfiguration : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            builder.HasKey(m => m.ManufacturerId);

            builder.Property(m => m.Name).IsRequired().HasMaxLength(Constants.nameLength);

            builder.Property(m => m.Address).HasMaxLength(Constants.adressLength);
        }
    }
}
