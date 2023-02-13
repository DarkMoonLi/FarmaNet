using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class WriteDownsConfiguration : EntityTypeConfiguration<WriteDowns>
    {
        public WriteDownsConfiguration()
        {
            this.Property(w => w._quantity).IsRequired().HasColumnType(Constants.columnTypeSmallInt);
        }
    }
}
