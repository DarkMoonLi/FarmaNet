using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class WorkerInformationConfiguration : EntityTypeConfiguration<WorkerInformation>
    {
        public WorkerInformationConfiguration()
        {
            this.HasKey(w => w._idWorkerInformation);

            this.Property(w => w._name).IsRequired().HasMaxLength(Constants.nameLength);
            this.Property(w => w._lastName).IsRequired().HasMaxLength(Constants.nameLength);

            this.Property(w => w._email).HasMaxLength(Constants.emailLength);
            this.Property(w => w._birthDate).HasColumnType(Constants.columnTypeDate);
            this.Property(w => w._passportSeries).HasColumnType(Constants.columnTypeSmallInt);
            this.Property(w => w._passportNumber).HasColumnType(Constants.columnTypeInt);
            this.Property(w => w._experience).HasColumnType(Constants.columnTypeReal);
        }
    }
}
