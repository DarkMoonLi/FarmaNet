using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class TypeMedicationConfiguration : EntityTypeConfiguration<TypeMedication>
    {
        public TypeMedicationConfiguration()
        {
            this.HasKey(t => t._idMedicationType);

            this.Property(t => t._name).IsRequired().HasMaxLength(Constants.nameLength);
        }
    }
}
