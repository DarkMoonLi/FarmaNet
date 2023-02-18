using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class WorkingHoursConfiguration : EntityTypeConfiguration<WorkingHours>
    {
        public WorkingHoursConfiguration()
        {
            this.HasKey(w => w.WorkingHoursId);

            this.Property(w => w.Date).IsRequired().HasColumnType(Constants.columnTypeDate);
            this.Property(w => w.Time).IsRequired().HasColumnType(Constants.columnTypeTime);

            this.Property(w => w.Description).HasMaxLength(Constants.descriptionLength);

            this.HasRequired(w => w.WorkerAccount).WithMany(w => w.WorkingHours).HasForeignKey(w => w.WorkerAccountId);
        }
    }
}
