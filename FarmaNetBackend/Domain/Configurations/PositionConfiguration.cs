using FarmaNetBackend.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace FarmaNetBackend.Domain.Configurations
{
    public class PositionConfiguration : EntityTypeConfiguration<Position>
    {
        public PositionConfiguration()
        {
            this.HasKey(p => p._idPosition);

            this.Property(p => p._position).IsRequired().HasMaxLength(Constants.positionLength);

            this.Property(p => p._salaryInHours).HasColumnType(Constants.columnTypeReal);
        }
    }
}
