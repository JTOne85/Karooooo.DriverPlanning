using Karooooo.DriverPlanning.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karooooo.DriverPlanning.Persistence.Configurations
{
    internal sealed class DriverConfiguration : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.ToTable(nameof(Driver));
            builder.HasIndex(e => e.Uid, "UC_Driver_UID").IsUnique();
            builder.HasIndex(e => e.UserId, "UC_Driver_UserId").IsUnique();


            builder.HasOne(e => e.DriverDetails).WithOne().HasForeignKey<Driver>(e => e.DriverDetailsId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.NextOfKin).WithOne().HasForeignKey<Driver>(e => e.DriverNextOfKinId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.DriverIdentification).WithOne().HasForeignKey<Driver>(e => e.DriverIdentificationId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(builder => builder.DriverVehicle).WithOne().HasForeignKey<Driver>(e => e.DriverVehcileId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.DriverLicense).WithOne().HasForeignKey<Driver>(e => e.DriverLisenceId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.DriverAddress).WithOne().HasForeignKey<Driver>(e => e.DriverAddressId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.DriverBankingDetails).WithOne().HasForeignKey<Driver>(e => e.DriverBankingDetailsId)
                .OnDelete(DeleteBehavior.Cascade); ;

        }
    }
}
