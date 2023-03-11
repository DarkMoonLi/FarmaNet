using FarmaNetBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarmaNetBackend.Configurations
{
    public class TypeMedicationConfiguration : IEntityTypeConfiguration<MedicationType>
    {
        public void Configure(EntityTypeBuilder<MedicationType> builder)
        {
            builder.HasKey(t => t.MedicationTypeId);

            builder.Property(t => t.Name).IsRequired().HasMaxLength(Constants.nameLength);
        }
    }
}
