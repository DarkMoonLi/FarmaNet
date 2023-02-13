using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class ManufacturerConfiguration : EntityTypeConfiguration<Manufacturer>
    {
        public ManufacturerConfiguration()
        {
            this.HasKey(m => m._idManufacturer);    

            this.Property(m => m._name).IsRequired().HasMaxLength(Constants.nameLength);
            
            this.Property(m => m._address).HasMaxLength(Constants.adressLength);
        }
    }
}
