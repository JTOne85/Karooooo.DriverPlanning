using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Karooooo.DriverPlanning.Persistence.Extensions;

public static class UtcDateTimeExtensions
{
    public static PropertyBuilder<DateTime> ConfigureUtcDateTime(this PropertyBuilder<DateTime> propertyBuilder)
    {
        return propertyBuilder.HasConversion(
            v => v.ToUniversalTime(),
            v => DateTime.SpecifyKind(v, DateTimeKind.Utc)
        );
    }

    public static PropertyBuilder<DateTime?> ConfigureUtcDateTime(this PropertyBuilder<DateTime?> propertyBuilder)
    {
        return propertyBuilder.HasConversion(
            v => v.HasValue ? v.Value.ToUniversalTime() : (DateTime?)null,
            v => v.HasValue ? DateTime.SpecifyKind(v.Value, DateTimeKind.Utc) : (DateTime?)null
        );
    }
}
