using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class ImportConfiguration : EntityTypeConfiguration<Import>
    {
        public ImportConfiguration()
        {
            this.HasKey(i => i.ImportId);
            
            this.Property(i => i.Date).IsRequired().HasColumnType(Constants.columnTypeDate);
            this.Property(i => i.Number).IsRequired().HasColumnType(Constants.columnTypeInt);
            
            this.Property(i => i.SumPrice).HasColumnType(Constants.columnTypeMoney);

            this.HasRequired(i => i.Supplier).WithMany(s => s.Imports).HasForeignKey(i => i.SupplierId);
            this.HasRequired(i => i.Pharmacy).WithMany(p => p.Imports).HasForeignKey(i => i.PharmacyId);
        }
    }
}
