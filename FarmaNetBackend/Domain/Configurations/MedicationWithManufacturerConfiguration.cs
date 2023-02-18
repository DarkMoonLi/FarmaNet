using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class MedicationWithManufacturerConfiguration : EntityTypeConfiguration<MedicationWithManufacturer>
    {
        public MedicationWithManufacturerConfiguration()
        {
            this.HasKey(m => new { m.MedicationId, m.ManufacturerId });

            this.HasRequired(m => m.Manufacturer).WithMany(m => m.MedicationWithManufacturers).HasForeignKey(m => m.ManufacturerId);
            this.HasRequired(m => m.Medication).WithMany(m => m.MedicationWithManufacturers).HasForeignKey(m => m.MedicationId);
        }
    }
}
