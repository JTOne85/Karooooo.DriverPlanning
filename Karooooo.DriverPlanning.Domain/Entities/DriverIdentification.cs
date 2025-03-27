using Karooooo.DriverPlanning.Domain.Enums;

namespace Karooooo.DriverPlanning.Domain.Entities;

public class DriverIdentification
{
    public int Id { get; private set; } = 0;
    public string? IdentificationNumber { get; private set; } = "";
    public string? PassportNumber { get; private set; } = "";
    public IdentityType IdentityType { get; private set; }
    public bool IsForeignNational { get; set; } = false;
    public WorkPermitType WorkPermit { get; set; }
    public int ResidencyId { get; set; } = 0;
    public string Race { get; private set; } = "";
    public Gender Gender { get; private set; }    
    public string CreatedBy { get; private set; } = "";
    public DateTime CreatedDate { get; private set; }
    public Uri DriverIdentificationUrl { get; set; }
    public Uri DriverWorkPermitUrl { get; set; }

    public virtual Residency Residency { get; private set; }

}
