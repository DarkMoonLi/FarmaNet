using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class SaleConfiguration : EntityTypeConfiguration<Sale>
    {
        public SaleConfiguration()
        {
            this.HasKey(s => new { s.PharmacyId, s.MedicationId });    

            this.Property(s => s.Quantity).IsRequired().HasColumnType(Constants.columnTypeSmallInt);

            this.Property(s => s.Price).HasColumnType(Constants.columnTypeMoney);

            this.HasRequired(s => s.Medication).WithMany(m => m.Sales).HasForeignKey(s => s.MedicationId);
            this.HasRequired(s => s.Pharmacy).WithMany(p => p.Sales).HasForeignKey(s => s.PharmacyId);
        }
    }
}
