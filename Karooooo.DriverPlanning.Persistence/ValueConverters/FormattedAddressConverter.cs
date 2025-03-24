using Karooooo.Common.Domain.SingleValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Karooooo.DriverPlanning.Persistence.ValueConverters;

public class FormattedAddressConverter : ValueConverter<FormattedAddress, string>
{
    public FormattedAddressConverter()
        : base(
            v => v.Value,
            v => new FormattedAddress(v))
    {
    }
}
