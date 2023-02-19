using FarmaNetBackend.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarmaNetBackend.Domain.Configurations
{
    public class WorkerAccountConfiguration : IEntityTypeConfiguration<WorkerAccount>
    {
        public void Configure(EntityTypeBuilder<WorkerAccount> builder)
        {
            builder.HasKey(w => w.WorkerAccountId);

            builder.Property(w => w.Login).IsRequired().HasMaxLength(Constants.loginLength);
            builder.Property(w => w.Password).IsRequired().HasMaxLength(Constants.passwordLength);

            builder.HasOne(w => w.WorkerInformation).WithMany(w => w.WorkerAccounts).IsRequired().HasForeignKey(w => w.WorkerAccountId);
            builder.HasOne(w => w.Pharmacy).WithMany(p => p.WorkerAccounts).IsRequired().HasForeignKey(w => w.PharmacyId);
        }
    }
}
