using Karooooo.DriverPlanning.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Karooooo.DriverPlanning.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<DriverIdentification> DriverIdentificationDetails { get; set; }
        public DbSet<DriverBankingDetails> DriverBankingDetails { get; set; }
        public DbSet<DriverAddress> DriverAddressDetils { get; set; }
        public DbSet<Residency> ResidencyDetails { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<DriverDetails> DriverDetails { get; set; }
        public DbSet<DriverNextOfKin> DriverNextOfKinDetails { get; set; }
        public DbSet<DriverVehicle> DriverVehicleDetails { get; set; }
        public DbSet<DriverLicense> DriverLicenseDetails { get; set; }
        public DbSet<DriverVehicleLicense> DriverVehicleLicenseDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            modelBuilder.Entity<Nationality>().HasNoKey();
            
            
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            
        }
    }
}
