using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class WorkerAccountConfiguration : EntityTypeConfiguration<WorkerAccount>
    {
        public WorkerAccountConfiguration()
        {
            this.HasKey(w => w._idWorkerAccount);

            this.Property(w => w._login).IsRequired().HasMaxLength(Constants.loginLength);
            this.Property(w => w._password).IsRequired().HasMaxLength(Constants.passwordLength);
        }
    }
}
