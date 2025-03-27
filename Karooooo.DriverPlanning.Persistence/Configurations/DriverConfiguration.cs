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
    internal sealed class DriverConfiguration : IEntityTypeConfiguration<DriverCompliance>
    {
        public void Configure(EntityTypeBuilder<DriverCompliance> builder)
        {
            builder.ToTable(nameof(DriverCompliance));
            builder.HasIndex(e => e.Uid, "UC_Driver_UID").IsUnique();
            builder.HasIndex(e => e.UserId, "UC_Driver_UserId").IsUnique();


            builder.HasOne(e => e.DriverDetails).WithOne().HasForeignKey<DriverCompliance>(e => e.DriverDetailsId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.NextOfKin).WithOne().HasForeignKey<DriverCompliance>(e => e.DriverNextOfKinId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.DriverIdentification).WithOne().HasForeignKey<DriverCompliance>(e => e.DriverIdentificationId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(builder => builder.DriverVehicle).WithOne().HasForeignKey<DriverCompliance>(e => e.DriverVehcileId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.DriverLicense).WithOne().HasForeignKey<DriverCompliance>(e => e.DriverLisenceId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.DriverAddress).WithOne().HasForeignKey<DriverCompliance>(e => e.DriverAddressId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.DriverBankingDetails).WithOne().HasForeignKey<DriverCompliance>(e => e.DriverBankingDetailsId)
                .OnDelete(DeleteBehavior.Cascade); ;

        }
    }
}
