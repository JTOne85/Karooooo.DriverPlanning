using Karooooo.Common.Domain.ResultValueObjects;
using Karooooo.DriverPlanning.Domain.Enums;

namespace Karooooo.DriverPlanning.Domain.Entities;

public class User
{

    public int Id { get; private set; }
    public string FullName { get; private set; } = null!;
    public Phone Phone { get; private set; } = null!;
    public Phone? WhatsAppNumber { get; private set; }
    public Email Email { get; private set; } = null!;
    public FirebaseUid FirebaseUid { get; private set; } = null!;
    public int? DefaultBusinessId { get; private set; }
    public bool IsSuperUser { get; private set; }
    public string CreatedFromSource { get; private set; } = null!;
    public DateTime? LatestAuthTimestampUtc { get; private set; }
    public JwtAuthentication? LatestAuthAs { get; private set; }
    //TODO need to figure out TimeZoneOffset and dates in general
    public decimal? TimeZoneOffset { get; private set; }
    public short? SuperUserAccessLevelId { get; private set; }
    public DateTime? LockoutEndDateUtc { get; private set; }
    public bool IsSystemAdministrator { get; private set; }

    public virtual Driver? Driver { get; private set; }
}
