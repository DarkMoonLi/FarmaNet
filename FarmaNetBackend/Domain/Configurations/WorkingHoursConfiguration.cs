using FarmaNetBackend.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarmaNetBackend.Domain.Configurations
{
    public class WorkingHoursConfiguration : IEntityTypeConfiguration<WorkingHours>
    {
        public void Configure(EntityTypeBuilder<WorkingHours> builder)
        {
            builder.HasKey(w => w.WorkingHoursId);

            builder.Property(w => w.Date).IsRequired().HasColumnType(Constants.columnTypeDate);
            builder.Property(w => w.Time).IsRequired().HasColumnType(Constants.columnTypeTime);

            builder.Property(w => w.Description).HasMaxLength(Constants.descriptionLength);

            builder.HasOne(w => w.WorkerAccount).WithMany(w => w.WorkingHours).IsRequired().HasForeignKey(w => w.WorkerAccountId);
        }
    }
}
