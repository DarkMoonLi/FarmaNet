using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class PharmacyConfiguration : EntityTypeConfiguration<Pharmacy>
    {
        public PharmacyConfiguration()
        {
            this.HasKey(p => p.PharmacyId);    

            this.Property(p => p.Name).IsRequired().HasMaxLength(Constants.nameLength);
            
            this.Property(p => p.Adress).HasMaxLength(Constants.adressLength);
            this.Property(p => p.Email).HasMaxLength(Constants.emailLength);
            this.Property(p => p.Description).HasMaxLength(Constants.descriptionLength);
        }
    }
}
