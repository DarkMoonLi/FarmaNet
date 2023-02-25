using FarmaNetBackend.Domain.Configurations;
using FarmaNetBackend.Domain.IRepositories;
using FarmaNetBackend.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FarmaNetBackend.Infrastructure
{
    public class ApplicationDbContext : DbContext, IUnitOfWork
    {
        public DbSet<Medication> Medications { get; set; }
        public DbSet<MedicationType> TypeMedications { get; set; }
        public DbSet<Import> Imports { get; set; }
        public DbSet<ImportWithMedication> ImportWithMedications { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<MedicationWithManufacturer> MedicationWithManufacturers { get; set; }
        public DbSet<Pharmacy> Pharmacies { get; set; }
        public DbSet<PharmacyWithMedication> PharmacyWithMedications { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<WorkerInformation> WorkersInformation { get; set; }
        public DbSet<WorkerAccount> WorkerAccounts { get; set; }
        public DbSet<WorkingHours> WorkingHours { get; set; }
        public DbSet<WriteDowns> WriteDowns { get; set; }

        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options ) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public void Commit()
        {
            this.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder )
        {
            modelBuilder.ApplyConfiguration(new ImportConfiguration());
            modelBuilder.ApplyConfiguration(new ImportWithMedicationConfiguration());
            modelBuilder.ApplyConfiguration(new ManufacturerConfiguration());
            modelBuilder.ApplyConfiguration(new MedicationConfiguration());
            modelBuilder.ApplyConfiguration(new MedicationWithManufacturerConfiguration());
            modelBuilder.ApplyConfiguration(new PharmacyConfiguration());
            modelBuilder.ApplyConfiguration(new PharmacyWithMedicationConfiguration());
            modelBuilder.ApplyConfiguration(new PositionConfiguration());
            modelBuilder.ApplyConfiguration(new SaleConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierConfiguration());
            modelBuilder.ApplyConfiguration(new TypeMedicationConfiguration());
            modelBuilder.ApplyConfiguration(new WorkerAccountConfiguration());
            modelBuilder.ApplyConfiguration(new WorkerInformationConfiguration());
            modelBuilder.ApplyConfiguration(new WorkingHoursConfiguration());
            modelBuilder.ApplyConfiguration(new WriteDownsConfiguration());
        }
    }
}
