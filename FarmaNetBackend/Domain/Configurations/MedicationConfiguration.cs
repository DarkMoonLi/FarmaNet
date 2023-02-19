using FarmaNetBackend.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarmaNetBackend.Domain.Configurations
{
    public class MedicationConfiguration : IEntityTypeConfiguration<Medication>
    {
        public void Configure(EntityTypeBuilder<Medication> builder)
        {
            builder.HasKey(m => m.MedicationId);

            builder.Property(m => m.Name).IsRequired().HasMaxLength(Constants.nameLength);

            builder.Property(m => m.Recipe).HasMaxLength(Constants.descriptionLength);

            builder.HasOne(m => m.MedicationType).WithMany(m => m.Medications).IsRequired().HasForeignKey(m => m.MedicationTypeId);
        }
    }
}
