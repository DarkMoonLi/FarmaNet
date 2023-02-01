using FarmaNetBackend.Domain.IRepositories;
using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Dto.ImportWithMedicationDto;
using FarmaNetBackend.Dto.PharmacyWithMedication;
using FarmaNetBackend.Models.Import;
using FarmaNetBackend.Models.Manufacturer;
using FarmaNetBackend.Models.Medication;
using FarmaNetBackend.Models.MedicationWithManufacturer;
using FarmaNetBackend.Models.Position;
using FarmaNetBackend.Models.Sale;
using FarmaNetBackend.Models.Supplier;
using FarmaNetBackend.Models.WorkerAccount;
using FarmaNetBackend.Models.WorkingHours;
using FarmaNetBackend.Models.WriteDowns;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FarmaNetBackend.Infrastructure
{
  public class ApplicationDbContext : DbContext, IUnitOfWork
    {
        public DbSet<Medication> Medications { get; set; }
        public DbSet<TypeMedication> TypeMedications { get; set; }
        public DbSet<Import> Import { get; set; }
        public DbSet<ImportWithMedication> ImportWithMedication { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }
        public DbSet<MedicationWithManufacturer> MedicationWithManufacturer { get; set; }
        public DbSet<Pharmacy> Pharmacy { get; set; }
        public DbSet<PharmacyWithMedication> PharmacyWithMedication { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Worker> Worker { get; set; }
        public DbSet<WorkerAccount> WorkerAccount { get; set; }
        public DbSet<WorkingHours> WorkingHours { get; set; }
        public DbSet<WriteDowns> WriteDowns { get; set; }
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options )
            : base( options )
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FarmaNet;Trusted_Connection=True;");
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
