using FarmaNetBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarmaNetBackend.Configurations
{
    public class ImportConfiguration : IEntityTypeConfiguration<Import>
    {
        public void Configure(EntityTypeBuilder<Import> builder)
        {
            builder.HasKey(i => i.ImportId);

            builder.Property(i => i.Date).IsRequired().HasColumnType(Constants.columnTypeDate);
            builder.Property(i => i.Number).IsRequired().HasColumnType(Constants.columnTypeInt);

            builder.Property(i => i.SumPrice).HasColumnType(Constants.columnTypeMoney);

            builder.HasOne(i => i.Supplier).WithMany(s => s.Imports).IsRequired().HasForeignKey(i => i.SupplierId);
            builder.HasOne(i => i.Pharmacy).WithMany(p => p.Imports).IsRequired().HasForeignKey(i => i.PharmacyId);
        }
    }
}
