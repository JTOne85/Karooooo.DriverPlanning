using Karooooo.Common.Domain.SingleValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karooooo.DriverPlanning.Persistence.ValueConverters;

public class LongitudeConverter : ValueConverter<Longitude, decimal>
{
    public LongitudeConverter()
        : base(
            v => v.Value,
            v => new Longitude(v))
    {
    }
}
