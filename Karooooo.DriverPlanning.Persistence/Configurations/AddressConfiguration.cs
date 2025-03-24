using Karooooo.DriverPlanning.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Karooooo.DriverPlanning.Persistence.Extensions;


namespace Karooooo.DriverPlanning.Persistence.Configurations;

internal sealed class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable(nameof(Address));
        builder.ToTable(nameof(Address),
            b => b.IsTemporal(b => b.UseHistoryTable(name: $"{nameof(Address)}_History", schema: "hist")));
        builder.Property(e => e.CreatedAtUtc)
            .HasDefaultValueSql("(getutcdate())")
            .HasPrecision(2)
            .ConfigureUtcDateTime();
        builder.Property(e => e.UpdatedAtUtc)
            .HasPrecision(2)
            .ConfigureUtcDateTime();

        builder.Property(e => e.FormattedAddress).HasMaxLength(1000);
        builder.Property(e => e.Suburb).HasMaxLength(255);
        builder.Property(e => e.PostalCode).HasMaxLength(10);
        builder.Property(e => e.Country).HasMaxLength(100);
        builder.Property(e => e.CountryCode).HasMaxLength(10);
        builder.Property(e => e.Latitude).HasColumnType("decimal(8, 5)");
        builder.Property(e => e.Longitude).HasColumnType("decimal(8, 5)");
        builder.Property(e => e.Area).HasMaxLength(255);
        builder.Property(e => e.City).HasMaxLength(255);
        builder.Property(e => e.Complex).HasMaxLength(100);
        builder.Property(e => e.Street).HasMaxLength(255);
        builder.Property(e => e.StreetNr).HasMaxLength(255);
        builder.Property(e => e.UnitNr).HasMaxLength(255);
    }
}
