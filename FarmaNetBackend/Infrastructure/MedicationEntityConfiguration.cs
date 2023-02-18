using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FarmaNetBackend.Models;
using FarmaNetBackend.Models.Medication;

namespace FarmaNetBackend
{
    public class MedicationEntityConfiguration : IEntityTypeConfiguration<Medication>
    {
        public void Configure( EntityTypeBuilder<Medication> builder )
        {
            builder.ToTable( "Medication" )
                .HasKey( item => item._id );
        }
    }
}