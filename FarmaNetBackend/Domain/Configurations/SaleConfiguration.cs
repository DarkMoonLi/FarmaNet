using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class SaleConfiguration : EntityTypeConfiguration<Sale>
    {
        public SaleConfiguration()
        {
            this.Property(s => s._quantity).IsRequired().HasColumnType(Constants.columnTypeSmallInt);

            this.Property(s => s._price).HasColumnType(Constants.columnTypeMoney);
        }
    }
}
