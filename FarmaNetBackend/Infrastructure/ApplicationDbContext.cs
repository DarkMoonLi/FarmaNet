using FarmaNetBackend.Domain.IRepositories;
using FarmaNetBackend.Dto.ImportWithMedicationDto;
using FarmaNetBackend.Dto.PharmacyWithMedication;
using FarmaNetBackend.Models.Import;
using FarmaNetBackend.Models.Manufacturer;
using FarmaNetBackend.Models.Medication;
using FarmaNetBackend.Models.MedicationWithManufacturer;
using FarmaNetBackend.Models.Pharmacy;
using FarmaNetBackend.Models.Position;
using FarmaNetBackend.Models.Sale;
using FarmaNetBackend.Models.Supplier;
using FarmaNetBackend.Models.Worker;
using FarmaNetBackend.Models.WorkerAccount;
using FarmaNetBackend.Models.WorkingHours;
using FarmaNetBackend.Models.WriteDowns;
using Microsoft.EntityFrameworkCore;

namespace FarmaNetBackend.Infrastructure
{
    public class ApplicationDbContext : DbContext, IUnitOfWork
    {
        public DbSet<Medication> Medications { get; set; }
        public DbSet<TypeMedication> TypeMedications { get; set; }
        public DbSet<Import> Imports { get; set; }
        public DbSet<ImportWithMedication> ImportWithMedications { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<MedicationWithManufacturer> MedicationWithManufacturers { get; set; }
        public DbSet<Pharmacy> Pharmacies { get; set; }
        public DbSet<PharmacyWithMedication> PharmacyWithMedications { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<WorkerAccount> WorkerAccounts { get; set; }
        public DbSet<WorkingHours> WorkingHours { get; set; }
        public DbSet<WriteDowns> WriteDowns { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        void IUnitOfWork.Commit()
        {
            this.SaveChanges();
        }

        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
