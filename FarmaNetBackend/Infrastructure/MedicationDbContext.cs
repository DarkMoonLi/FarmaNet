using FarmaNetBackend.Domain.IRepositories;
using FarmaNetBackend.Models.Medication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FarmaNetBackend.Infrastructure
{
  public class MedicationDbContext : DbContext, IUnitOfWork
    {

        public MedicationDbContext( DbContextOptions options )
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
            //modelBuilder.Entity<Medication>().HasNoKey();
            modelBuilder.Entity<Medication>(
                m =>
                { m.HasKey("Id"); });
            modelBuilder.Entity<Medication>()
                        .HasData(new Medication[] { 
                            new Medication 
                            { 
                                Id = 1, 
                                Name = "Test", 
                                Recipe = "Recipie", 
                                IdMedicationType = 123 } 
                            });
            //Medication med = new Medication("Test", "Recipie", 123);

            //Medications.Add(med);
        }

    }
}
