using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class SupplierConfiguration : EntityTypeConfiguration<Supplier>
    {
        public SupplierConfiguration()
        {
            this.HasKey(s => s.SupplierId);

            this.Property(s => s.Name).IsRequired().HasMaxLength(Constants.nameLength);

            this.Property(s => s.Inn).HasMaxLength(Constants.innLength);
        }
    }
}
