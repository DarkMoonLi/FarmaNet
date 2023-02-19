using FarmaNetBackend.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarmaNetBackend.Domain.Configurations
{
    public class MedicationWithManufacturerConfiguration : IEntityTypeConfiguration<MedicationWithManufacturer>
    {
        public void Configure(EntityTypeBuilder<MedicationWithManufacturer> builder)
        {
            builder.HasKey(m => new { m.MedicationId, m.ManufacturerId });

            builder.HasOne(m => m.Manufacturer).WithMany(m => m.MedicationWithManufacturers).IsRequired().HasForeignKey(m => m.ManufacturerId);
            builder.HasOne(m => m.Medication).WithMany(m => m.MedicationWithManufacturers).IsRequired().HasForeignKey(m => m.MedicationId);
        }
    }
}
