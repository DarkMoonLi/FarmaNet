using FarmaNetBackend.Models;
using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;

namespace FarmaNetBackend.Data
{
    public class PharmacyDbContext : DbContext
    {
        public PharmacyDbContext(DbContextOptions<PharmacyDbContext> options) : base(options)
        {
        }

        //public IConfigurationRoot Configuration { get; }
        public DbSet<Medication> Medications { get; set; }
        //public DbSet<TypeMedication> TypeMedications { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<MedicationWithManufacturer> MedicationsWithManufacturers { get; set; }
        //public DbSet<Pharmacy> Pharmacies { get; set; }
        //public DbSet<Worker> Workers { get; set; }

       

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                                        Configuration.GetConnectionString("DefaultConnection")
                                        );
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            InitMedicationTable(modelBuilder);
            InitManufacturerTable(modelBuilder);
            InitMedicationWithManufacturerTable(modelBuilder);
        }

        private void InitMedicationTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medication>().ToTable("Medication");
            modelBuilder.Entity<Medication>().HasKey(med => med.Id);
            //modelBuilder.Entity<Medication>().HasMany(medication => medication.Medications).WithOne().HasForeignKey(medWithManuf => medWithManuf.IdMedication);
            //modelBuilder.Entity<Medication>().HasOne(medication => medication.TypeMedication).WithMany().HasForeignKey(medType => medType.IdMedicationType);
        }

        private void InitManufacturerTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>().ToTable("Manufacturer");
            modelBuilder.Entity<Manufacturer>().HasKey(manuf => manuf.IdManufacturer);
            //modelBuilder.Entity<Manufacturer>().HasMany(manufacturer => manufacturer.Medications).WithOne().HasForeignKey(medWithManuf => medWithManuf.IdManufacturer);
        }

        private void InitMedicationWithManufacturerTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedicationWithManufacturer>().ToTable("Medication_with_manufacturer");
            modelBuilder.Entity<MedicationWithManufacturer>().HasKey(medWithManuf => new {medWithManuf.IdMedication, medWithManuf.IdManufacturer});
            modelBuilder.Entity<MedicationWithManufacturer>().HasOne(medWithManuf => medWithManuf.Manufacturer).WithMany(manuf => manuf.Medications).HasForeignKey(manufacturer => manufacturer.IdManufacturer);
            modelBuilder.Entity<MedicationWithManufacturer>().HasOne(medWithManuf => medWithManuf.Medication).WithMany(med => med.Medications).HasForeignKey(medication => medication.IdMedication);
        }
        //void IUnitOfWork.Commit()
        //{
        //    this.SaveChanges();
        //}

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Medication>().HasNoKey();
            modelBuilder.Entity<Manufacturer>(
                m =>
                { m.HasKey("_idManufacturer"); });
            modelBuilder.Entity<Manufacturer>()
                        .HasData(new Manufacturer[] {
                            new Manufacturer
                            (
                                "Test",
                                "Recipie"
                            )
                        });
            //Medication med = new Medication("Test", "Recipie", 123);

            //Medications.Add(med);
        }*/
    }
}
