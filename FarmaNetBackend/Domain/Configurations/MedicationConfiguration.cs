using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class MedicationConfiguration : EntityTypeConfiguration<Medication>
    {
        public MedicationConfiguration()
        {
            this.HasKey(m => m._idMedication);
            
            this.Property(m => m._name).IsRequired().HasMaxLength(Constants.nameLength);
            
            this.Property(m => m._recipe).HasMaxLength(Constants.descriptionLength);
        }
    }
}
