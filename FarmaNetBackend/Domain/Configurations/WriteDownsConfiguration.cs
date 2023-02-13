using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class WriteDownsConfiguration : EntityTypeConfiguration<WriteDowns>
    {
        public WriteDownsConfiguration()
        {
            this.HasKey(w => new {w.PharmacyId, w.MedicationId});

            this.Property(w => w.Quantity).IsRequired().HasColumnType(Constants.columnTypeSmallInt);

            this.HasRequired(w => w.Pharmacy).WithMany(p => p.WriteDowns).HasForeignKey(w => w.PharmacyId);
            this.HasRequired(w => w.Medication).WithMany(m => m.WriteDowns).HasForeignKey(w => w.MedicationId);
        }
    }
}
