using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class MedicationConfiguration : EntityTypeConfiguration<Medication>
    {
        public MedicationConfiguration()
        {
            this.HasKey(m => m.MedicationId);
            
            this.Property(m => m.Name).IsRequired().HasMaxLength(Constants.nameLength);
            
            this.Property(m => m.Recipe).HasMaxLength(Constants.descriptionLength);

            this.HasRequired(m => m.MedicationType).WithMany(m => m.Medications).HasForeignKey(m => m.MedicationTypeId);
        }
    }
}
