using Karooooo.DriverPlanning.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karooooo.DriverPlanning.Persistence.Configurations
{
    internal sealed class DriverDetailsConfiguration : IEntityTypeConfiguration<DriverDetails>
    {
        public void Configure(EntityTypeBuilder<DriverDetails> builder)
        {
            builder.ToTable(nameof(DriverDetails));
        }
    }
}
