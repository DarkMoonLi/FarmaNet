using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class WorkerAccountConfiguration : EntityTypeConfiguration<WorkerAccount>
    {
        public WorkerAccountConfiguration()
        {
            this.HasKey(w => w.WorkerAccountId);

            this.Property(w => w.Login).IsRequired().HasMaxLength(Constants.loginLength);
            this.Property(w => w.Password).IsRequired().HasMaxLength(Constants.passwordLength);

            this.HasRequired(w => w.WorkerInformation).WithMany(w => w.WorkerAccounts).HasForeignKey(w => w.WorkerAccountId);
            this.HasRequired(w => w.Pharmacy).WithMany(p => p.WorkerAccounts).HasForeignKey(w => w.PharmacyId);
        }
    }
}
