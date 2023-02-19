using FarmaNetBackend.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarmaNetBackend.Domain.Configurations
{
    public class WorkerInformationConfiguration : IEntityTypeConfiguration<WorkerInformation>
    {
        public void Configure(EntityTypeBuilder<WorkerInformation> builder)
        {
            builder.HasKey(w => w.WorkerInformationId);

            builder.Property(w => w.Name).IsRequired().HasMaxLength(Constants.nameLength);
            builder.Property(w => w.LastName).IsRequired().HasMaxLength(Constants.nameLength);

            builder.Property(w => w.Email).HasMaxLength(Constants.emailLength);
            builder.Property(w => w.BirthDate).HasColumnType(Constants.columnTypeDate);
            builder.Property(w => w.PassportSeries).HasColumnType(Constants.columnTypeSmallInt);
            builder.Property(w => w.PassportNumber).HasColumnType(Constants.columnTypeInt);
            builder.Property(w => w.Experience).HasColumnType(Constants.columnTypeReal);

            builder.HasOne(w => w.Position).WithMany(p => p.WorkerInformations).IsRequired().HasForeignKey(w => w.PositionId);
        }
    }
}
