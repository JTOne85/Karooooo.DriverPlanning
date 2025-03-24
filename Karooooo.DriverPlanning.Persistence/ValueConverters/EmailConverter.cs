using Karooooo.Common.Domain.ResultValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karooooo.DriverPlanning.Persistence.ValueConverters;

public class EmailConverter : ValueConverter<Email, string>
{
    public EmailConverter()
        : base(
            v => v.Value,
            v => Email.Create(v).Value)
    { }
}
