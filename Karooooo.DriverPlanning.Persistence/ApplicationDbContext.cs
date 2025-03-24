using Karooooo.Common.Domain.ResultValueObjects;
using Karooooo.Common.Domain.SingleValueObjects;
using Karooooo.Common.Domain.Uids;
using Karooooo.DriverPlanning.Domain.Entities;
using Karooooo.DriverPlanning.Persistence.Extensions;
using Karooooo.DriverPlanning.Persistence.ValueConverters;
using Microsoft.EntityFrameworkCore;

using System;

namespace Karooooo.DriverPlanning.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<Phone>().HaveConversion<PhoneConverter>();
            configurationBuilder.Properties<Email>().HaveConversion<EmailConverter>();
            configurationBuilder.Properties<FirebaseUid>().HaveConversion<FirebaseUidConverter>();

            configurationBuilder
           .Properties<DriverUid>()
           .HaveConversion<DriverUidConverter>();

            configurationBuilder
           .Properties<PostalCode>()
           .HaveConversion<PostalCodeConverter>();

            configurationBuilder
                .Properties<Suburb>()
                .HaveConversion<SuburbConverter>();

            configurationBuilder
            .Properties<Latitude>()
            .HaveConversion<LatitudeConverter>();

            configurationBuilder
                .Properties<Longitude>()
                .HaveConversion<LongitudeConverter>();

            configurationBuilder
            .Properties<FormattedAddress>()
            .HaveConversion<FormattedAddressConverter>();
        }


    }
}
