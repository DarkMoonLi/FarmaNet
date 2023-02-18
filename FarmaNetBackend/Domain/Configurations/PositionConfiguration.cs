using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class PositionConfiguration : EntityTypeConfiguration<Position>
    {
        public PositionConfiguration()
        {
            this.HasKey(p => p.PositionId);

            this.Property(p => p.Post).IsRequired().HasMaxLength(Constants.positionLength);

            this.Property(p => p.SalaryInHours).HasColumnType(Constants.columnTypeReal);
        }
    }
}
