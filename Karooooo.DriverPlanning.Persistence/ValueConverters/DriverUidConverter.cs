using Karooooo.Common.Domain.Uids;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karooooo.DriverPlanning.Persistence.ValueConverters;

public class DriverUidConverter : ValueConverter<DriverUid, string>
{
    public DriverUidConverter()
        : base(
            v => v.Value,
            v => new DriverUid(v))
    {
    }
}
