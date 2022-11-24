using FarmaNetBackend.Domain.IRepositories;
using FarmaNetBackend.Models.Medication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Recipes.Infrastructure
{
  public class MedicationDbContext : DbContext, IUnitOfWork
    {

        public MedicationDbContext( DbContextOptions<MedicationDbContext> options )
            : base( options )
        {
            Database.EnsureCreated();
        }

        public IConfigurationRoot Configuration { get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(Microsoft
                                        .Extensions
                                        .Configuration
                                        .ConfigurationExtensions
                                        .GetConnectionString(this.Configuration, "DefaultConnection")
                                        );
        }

        void IUnitOfWork.Commit()
        {
            this.SaveChanges();
        }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<TypeMedication> TypeMedications { get; set;}

        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            
        }

    }
}
