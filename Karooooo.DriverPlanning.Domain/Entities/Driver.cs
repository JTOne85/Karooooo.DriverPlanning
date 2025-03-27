using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karooooo.DriverPlanning.Domain.Entities;

public class Driver
{
    public int Id { get; private set; }
    public int UserId { get; private set; }
    public int? VendorId { get; set; }
    public string Uid { get; set; } = string.Empty;
    public int DriverDetailsId { get; set; } = -1;
    public int DriverNextOfKinId { get; set; } = -1;
    public int DriverIdentificationId { get; set; } = -1;
    public int DriverVehcileId { get; set; } = -1;
    public int DriverLisenceId { get; set; } = -1;
    public int DriverAddressId { get; set; } = -1;
    public int DriverBankingDetailsId { get; set; } = -1;

    public virtual DriverDetails? DriverDetails { get; private set; }
    public virtual DriverNextOfKin? NextOfKin { get; set; }
    public virtual DriverIdentification? DriverIdentification { get; set; }
    public virtual DriverVehicle? DriverVehicle { get; set; }
    public virtual DriverLicense? DriverLicense { get; set; }
    public virtual DriverAddress? DriverAddress { get; set; }
    public virtual DriverBankingDetails? DriverBankingDetails { get; set; }

    public static Driver CreateDriver(int id)
    {
        return new Driver
        {
            Uid = Guid.NewGuid().ToString(),
            Id = id
        };
    }

}
