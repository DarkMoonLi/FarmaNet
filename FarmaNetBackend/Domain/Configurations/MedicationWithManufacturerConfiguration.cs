using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class MedicationWithManufacturerConfiguration : EntityTypeConfiguration<MedicationWithManufacturer>
    {
        public MedicationWithManufacturerConfiguration()
        {

        }
    }
}
