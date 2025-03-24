using Karooooo.Common.Domain.ResultValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Karooooo.DriverPlanning.Persistence.ValueConverters;

public class FirebaseUidConverter : ValueConverter<FirebaseUid, string>
{
    public FirebaseUidConverter()
        : base(
            v => v.Value,
            v => FirebaseUid.Create(v).Value)
    { }
}
