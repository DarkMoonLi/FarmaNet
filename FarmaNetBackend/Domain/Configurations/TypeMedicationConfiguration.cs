using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class TypeMedicationConfiguration : EntityTypeConfiguration<MedicationType>
    {
        public TypeMedicationConfiguration()
        {
            this.HasKey(t => t.MedicationTypeId);

            this.Property(t => t.Name).IsRequired().HasMaxLength(Constants.nameLength);
        }
    }
}
