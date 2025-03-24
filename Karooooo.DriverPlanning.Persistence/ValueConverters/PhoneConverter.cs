using Karooooo.Common.Domain.ResultValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karooooo.DriverPlanning.Persistence.ValueConverters;

public class PhoneConverter : ValueConverter<Phone, string>
{
    public PhoneConverter()
        : base(
            v => v.Value,
            v => Phone.Create(v).Value)
    { }
}
