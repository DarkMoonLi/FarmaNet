using FarmaNetBackend.Models;
using Microsoft.EntityFrameworkCore;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Configurations;

namespace FarmaNetBackend.Infrastructure
{
    public class ApplicationDbContext : DbContext, IUnitOfWork
    {
        public DbSet<Medication> Medications { get; set; }
        public DbSet<MedicationType> MedicationsTypes { get; set; }
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
        
        public DbSet<MedicationImage> MedicationImages { get; set; }
        public DbSet<PharmacyImage> PharmacyImages { get; set; }
        public DbSet<WorkerInformationImage> WorkerInformationImages { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public void Commit()
        {
            this.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
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

            modelBuilder.ApplyConfiguration(new MedicationImageConfiguration());
            modelBuilder.ApplyConfiguration(new PharmacyImageConfiguration());
            modelBuilder.ApplyConfiguration(new WorkerInformationImageConfiguration());
        }
    }
}
