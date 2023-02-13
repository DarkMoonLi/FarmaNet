using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class PharmacyConfiguration : EntityTypeConfiguration<Pharmacy>
    {
        public PharmacyConfiguration()
        {
            this.HasKey(p => p._idPharmacy);    

            this.Property(p => p._name).IsRequired().HasMaxLength(Constants.nameLength);
            
            this.Property(p => p._adress).HasMaxLength(Constants.adressLength);
            this.Property(p => p._email).HasMaxLength(Constants.emailLength);
            this.Property(p => p._description).HasMaxLength(Constants.descriptionLength);
        }
    }
}
