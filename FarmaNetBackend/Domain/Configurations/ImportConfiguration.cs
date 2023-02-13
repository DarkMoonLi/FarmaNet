using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class ImportConfiguration : EntityTypeConfiguration<Import>
    {
        public ImportConfiguration()
        {
            this.HasKey(i => i._idImport);
            
            this.Property(i => i._date).IsRequired().HasColumnType(Constants.columnTypeDate);
            this.Property(i => i._number).IsRequired().HasColumnType(Constants.columnTypeInt);
            
            this.Property(i => i._sumPrice).HasColumnType(Constants.columnTypeMoney);
        }
    }
}
