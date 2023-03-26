using FarmaNetBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FarmaNetBackend.Configurations
{
    public class WorkerInformationImageConfiguration : IEntityTypeConfiguration<WorkerInformationImage>
    {
        public void Configure(EntityTypeBuilder<WorkerInformationImage> builder)
        {
            builder.HasKey(w => w.ImageId);

            builder.Property(w => w.Title).IsRequired().HasMaxLength(Constants.nameLength);
            builder.Property(w => w.Path).IsRequired().HasMaxLength(Constants.imagePathLength);

            builder.HasOne(w => w.WorkerInformation).WithOne(w => w.WorkerInformationImage).IsRequired().HasForeignKey<WorkerInformation>(w => w.WorkerInformationImageId);
        }
    }
}
