namespace Karooooo.DriverPlanning.Domain.Entities;

public class DriverVehicle
{
    public int Id { get; set; }
    public string VehicleMake { get; set; }
    public string VehicleModel { get; set; }
    public string VehicleColour { get; set; }
    public Uri VehicleBackImageUrl { get; set; }
    public Uri VehicleFrontImageUrl { get; set; }
    public Uri VehicleSideImageUrl { get; set; }
    public int DriverVehicleLicenseId { get; set; }
    public virtual DriverVehicleLicense? DriverVehicleLicense { get; set; }

}
