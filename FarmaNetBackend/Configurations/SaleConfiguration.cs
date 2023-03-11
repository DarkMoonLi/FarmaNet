using FarmaNetBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarmaNetBackend.Configurations
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(s => new { s.PharmacyId, s.MedicationId });

            builder.Property(s => s.Quantity).IsRequired().HasColumnType(Constants.columnTypeSmallInt);

            builder.Property(s => s.Price).HasColumnType(Constants.columnTypeMoney);

            builder.HasOne(s => s.Medication).WithMany(m => m.Sales).IsRequired().HasForeignKey(s => s.MedicationId);
            builder.HasOne(s => s.Pharmacy).WithMany(p => p.Sales).IsRequired().HasForeignKey(s => s.PharmacyId);
        }
    }
}
