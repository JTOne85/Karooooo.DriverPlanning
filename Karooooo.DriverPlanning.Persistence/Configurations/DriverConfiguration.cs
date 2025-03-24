using Karooooo.Common.Domain.Enums;
using Karooooo.DriverPlanning.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore;
using Karooooo.DriverPlanning.Persistence.Extensions;
using System.Text.Json;


namespace Karooooo.DriverPlanning.Persistence.Configurations;

internal sealed class DriverConfiguration : IEntityTypeConfiguration<Driver>
{
    public void Configure(EntityTypeBuilder<Driver> builder)
    {
        //chain a call to IgnoreQueryFilters() to see deleted records
        builder.HasQueryFilter(filter => !filter.IsDeleted);

        builder.ToTable(nameof(Driver),
            b => b.IsTemporal(b => b.UseHistoryTable(name: $"{nameof(Driver)}_History", schema: "hist")));

        builder.HasIndex(e => e.Uid, "UC_Driver_Uid").IsUnique();
        builder.HasIndex(e => e.UserId, "UC_Driver_UserId").IsUnique();
        builder.Property(e => e.AccountNumber).HasMaxLength(50).IsUnicode(false);
        builder.Property(e => e.Fleet).HasMaxLength(50).IsUnicode(false).HasConversion(new EnumToStringConverter<Fleet>());
        builder.Property(e => e.Bank).HasMaxLength(50).IsUnicode(false);
        builder.Property(e => e.BranchCode).HasMaxLength(50).IsUnicode(false);
        builder.Property(e => e.ProfileUrl).HasMaxLength(255).IsUnicode(false);
        builder.Property(e => e.Uid).HasMaxLength(43).IsUnicode(false).IsFixedLength();
        builder.Property(e => e.UniqueDeviceIdentifier).HasMaxLength(255).IsUnicode(false);
        builder.Property(e => e.V2vehicleId).HasMaxLength(255).IsUnicode(false).HasColumnName("V2VehicleId");

        builder.Property(e => e.VehicleVinNumber).HasMaxLength(20).IsUnicode(false);
        builder.Property(e => e.VehicleLicensePlateNumber).HasMaxLength(20).IsUnicode(false);
        builder.Property(e => e.IdentificationExpiryDate).HasPrecision(2);
        builder.Property(e => e.VehicleMake).HasMaxLength(20).IsUnicode(false);
        builder.Property(e => e.VehicleModel).HasMaxLength(50).IsUnicode(false);
        builder.Property(e => e.VehicleColour).HasMaxLength(20).IsUnicode(false);
        builder.Property(e => e.VehiclePhotoFrontUrl).HasMaxLength(255).IsUnicode(false);
        builder.Property(e => e.VehiclePhotoSideUrl).HasMaxLength(255).IsUnicode(false);
        builder.Property(e => e.VehiclePhotoBackUrl).HasMaxLength(255).IsUnicode(false);
        builder.Property(e => e.VehicleLicenseExpiryDate).HasPrecision(2);
        builder.Property(e => e.IdentificationType).HasMaxLength(20).IsUnicode(false);
        builder.Property(e => e.IdentificationNumber).HasMaxLength(20).IsUnicode(false);
        builder.Property(e => e.Gender).HasMaxLength(10).IsUnicode(false);
        builder.Property(e => e.DriversLicenseExpiryDate).HasPrecision(2);
        builder.Property(e => e.Nationality).HasMaxLength(60).IsUnicode(false);
        builder.Property(e => e.Race).HasMaxLength(20).IsUnicode(false);
        builder.Property(e => e.PhoneModel).HasMaxLength(100).IsUnicode(false);

        builder.HasOne(d => d.User).WithOne(p => p.Driver)
            .HasForeignKey<Driver>(d => d.UserId)
            .OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_dbo_Driver_UserId");

        builder.Property(e => e.CreatedAtUtc)
            .HasDefaultValueSql("(getutcdate())")
            .HasPrecision(2)
            .ConfigureUtcDateTime();
        builder.Property(e => e.UpdatedAtUtc)
            .HasPrecision(2)
            .ConfigureUtcDateTime();

        builder.Property(e => e.IsDeleted);

        builder.Property(e => e.Labels)
            .HasConversion(
                v => JsonSerializer.Serialize(v, typeof(string[]), JsonSerializerOptions.Default),
                v => JsonSerializer.Deserialize<string[]?>(v, JsonSerializerOptions.Default));
    }
}