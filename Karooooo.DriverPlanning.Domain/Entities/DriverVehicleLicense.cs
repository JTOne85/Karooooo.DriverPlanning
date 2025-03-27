namespace Karooooo.DriverPlanning.Domain.Entities;

public class DriverVehicleLicense
{
    public int Id { get; set; }
    public string LicenseNumber { get; set; }
    public string VehicleRegisterNumber { get; set; }
    public string VIN { get; set; }
    public string VehicleEngineNumber { get; set; }
    public string LicenseType { get; set; }
    public DateTime ExpiryDate { get; set; }
    public Uri LicenseDocumentImageUrl { get; set; }
}
