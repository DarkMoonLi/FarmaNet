using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class WorkingHoursConfiguration : EntityTypeConfiguration<WorkingHours>
    {
        public WorkingHoursConfiguration()
        {
            this.HasKey(w => w._idWorkingHours);

            this.Property(w => w._date).IsRequired().HasColumnType(Constants.columnTypeDate);
            this.Property(w => w._time).IsRequired().HasColumnType(Constants.columnTypeTime);

            this.Property(w => w._description).HasMaxLength(Constants.descriptionLength);
        }
    }
}
