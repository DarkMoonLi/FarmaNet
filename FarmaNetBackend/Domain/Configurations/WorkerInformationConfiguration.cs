using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class WorkerInformationConfiguration : EntityTypeConfiguration<WorkerInformation>
    {
        public WorkerInformationConfiguration()
        {
            this.HasKey(w => w.WorkerInformationId);

            this.Property(w => w.Name).IsRequired().HasMaxLength(Constants.nameLength);
            this.Property(w => w.LastName).IsRequired().HasMaxLength(Constants.nameLength);

            this.Property(w => w.Email).HasMaxLength(Constants.emailLength);
            this.Property(w => w.BirthDate).HasColumnType(Constants.columnTypeDate);
            this.Property(w => w.PassportSeries).HasColumnType(Constants.columnTypeSmallInt);
            this.Property(w => w.PassportNumber).HasColumnType(Constants.columnTypeInt);
            this.Property(w => w.Experience).HasColumnType(Constants.columnTypeReal);

            this.HasRequired(w => w.Position).WithMany(p => p.WorkerInformations).HasForeignKey(w => w.PositionId);
        }
    }
}
