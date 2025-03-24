using Karooooo.Common.Domain.SingleValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karooooo.DriverPlanning.Persistence.ValueConverters;

public class SuburbConverter : ValueConverter<Suburb, string>
{
    public SuburbConverter()
        : base(
            v => v.Value,
            v => new Suburb(v))
    {
    }
}
