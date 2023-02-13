using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class SupplierConfiguration : EntityTypeConfiguration<Supplier>
    {
        public SupplierConfiguration()
        {
            this.HasKey(s => s._idSupplier);

            this.Property(s => s._name).IsRequired().HasMaxLength(Constants.nameLength);

            this.Property(s => s._inn).HasMaxLength(Constants.innLength);
        }
    }
}
