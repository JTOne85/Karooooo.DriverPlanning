using Karooooo.DriverPlanning.Domain.Enums;

namespace Karooooo.DriverPlanning.Domain.Entities;

public class DriverLicense
{
    public int Id { get; set; }
    public string LicenseNumber { get; set; }
    public LicenseType LicenseType { get; set; }
    public LicenseCode LicenceCode { get; set; }
    public DateTime ExpiryDate { get; set; }
    public Uri LicenseDocumentImageUrl { get; set; }
}
